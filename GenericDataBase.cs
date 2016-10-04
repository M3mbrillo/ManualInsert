using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ManualInsert
{
    class GenericDataBase
    {
        public static SqlConnection conexion = new SqlConnection();
        public static SqlConnectionStringBuilder conectionString = new SqlConnectionStringBuilder();

        private static SqlCommand command = new SqlCommand();        

        public static void Connectar(String _connectionString)
        {
            GenericDataBase.GenericConn(_connectionString);
        }

        public static void Connectar()
        {
            GenericDataBase.GenericConn(GenericDataBase.conectionString.ConnectionString);
        }

        private static void GenericConn(string _connectionString)
        {
            if (GenericDataBase.conexion.State == System.Data.ConnectionState.Open)
            {
                GenericDataBase.conexion.Close();
            }
            GenericDataBase.conexion.ConnectionString = _connectionString;

            try
            {
                GenericDataBase.conexion.Open();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public static System.Data.DataTable GetTableProperty(String tableName)
        {
            
            GenericDataBase.command.Connection = GenericDataBase.conexion;
            GenericDataBase.command.CommandText = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "'";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable.Load(GenericDataBase.command.ExecuteReader());

            return dataTable;
        }

        public static System.Data.DataTable GetRecords(string tableName, string where = "")
        {
            GenericDataBase.command.Connection = GenericDataBase.conexion;
            GenericDataBase.command.CommandText = "SELECT * FROM " + tableName;
            if (where != "")
            {
                GenericDataBase.command.CommandText += " WHERE " + where;
            }
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable.Load(GenericDataBase.command.ExecuteReader());

            return dataTable;
        }

    }
}
