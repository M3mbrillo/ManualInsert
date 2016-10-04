using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace ManualInsert
{
    class Tabla
    {
        public Dictionary<String, List<String>> diccionarioDatos;
        public String nombre { get; set; }
        public String whereClausure { get; set; }
        public System.Windows.Forms.CheckState check;

        public System.Windows.Forms.CheckState active { get; set; }

        public Tabla(Dictionary<String, List<String>> dataType)
        {
            this.diccionarioDatos = dataType; //no me gusta tenerlo aca, pero son las 1:50 am
            this.check = System.Windows.Forms.CheckState.Unchecked;
            this.nombre = "";
            this.whereClausure = "";
        }

        public override string ToString()
        {
            return this.nombre;
        }

        internal string GenerateInsertClause()
        {
            DataTable dataTable;
            try
            {
                dataTable = GenericDataBase.GetTableProperty(this.nombre);
            }
            catch (Exception ex)
            {
                throw ex;                
            }

            Dictionary<String, String> columnas = new Dictionary<string, string>();

            String insert = "INSERT INTO " + this.nombre + "( ";
            foreach (DataRow row in dataTable.Rows)
            {
                columnas.Add(row["COLUMN_NAME"].ToString().ToLower(), row["DATA_TYPE"].ToString().ToLower());
                insert += row["COLUMN_NAME"] + ", " ;
            }
            insert = insert.Remove(insert.Length - 2, 2) + ") VALUES ";

            try
            {
                dataTable = GenericDataBase.GetRecords(this.nombre, this.whereClausure);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            String values = "";
            foreach (DataRow row in dataTable.Rows)
            {
                values += "( ";
                foreach (KeyValuePair<String, String> item in columnas)
                {           
                    //NULL    
                    if (row[item.Key].GetType() == typeof(System.DBNull))
                    {
                        values += "NULL, ";
                    }                         
                    //STRING                                                                            
                    else if (item.Value == "VARCHAR".ToLower() ||
                        item.Value == "CHAR".ToLower() ||
                        item.Value == "nchar".ToLower() ||
                        item.Value == "ntext".ToLower() ||
                        item.Value == "nvarchar".ToLower() ||
                        item.Value == "text".ToLower() 
                        )                        
                    {
                        values += "N'" + ((String) row[item.Key]).Replace("\'", "\'\'") + "', ";
                    }
                    //FECHAS
                    else if (
                        item.Value == "date".ToLower() ||
                        item.Value == "datetime".ToLower() ||
                        item.Value == "datetime2".ToLower() ||
                        item.Value == "datetimeoffset".ToLower() ||
                        item.Value == "smalldatetime".ToLower() ||
                        item.Value == "DATETIME".ToLower()
                        )
                    {
                        values += "'" + row[item.Key]+ "', ";
                    }                    

                    else if (item.Value == "bit".ToLower())
                    {
                        if (row[item.Key].ToString() == "True")
                        {
                            values += "1, ";
                        }
                        else
                        {
                            values += "0, ";
                        }
                    }
                    //NUMEROS
                    else
                    {
                        values += row[item.Key] + ", ";
                    }
                }
                values = values.Remove(values.Length -2, 2);
                values += " ),\n";
            }
            values = values.Remove(values.Length - 2, 2);
            return insert + values;
        }       

    }
}
