using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace ManualInsert
{
    public partial class frmMain : Form
    {
        List<Tabla> tablas;
        Dictionary<String, List<String>> dataTypes;
        Tabla activeTabla;


        public frmMain()
        {
            InitializeComponent();
            this.tablas = new List<Tabla>();
            this.dataTypes = new Dictionary<String, List<String>>();

            this.dataTypes.Add("String", new List<string>(new String[] { "varchar", "char", "nchar", "ntext", "nvarchar", "text" }));
            this.dataTypes.Add("int64", new List<string>(new String[] { "bigint" }));
            this.dataTypes.Add("int", new List<string>(new String[] { "int" }));
            this.dataTypes.Add("Int16", new List<string>(new String[] { "smallint" }));
            this.dataTypes.Add("Double", new List<string>(new String[] { "float" }));
            this.dataTypes.Add("Byte[]", new List<string>(new String[] { "binary" }));
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigConnection form = new frmConfigConnection();
            form.ShowDialog();

            this.tablas.Clear();
            this.chlTablas.Items.Clear();

            Tabla tabla;
            if (GenericDataBase.conexion.State == ConnectionState.Open)
            {
                DataTable tableNames = GenericDataBase.conexion.GetSchema("Tables");
                
                foreach (DataRow row in tableNames.Rows)
                {                                                                        
                    tabla = new Tabla(this.dataTypes);
                    tabla.nombre = (String)row["TABLE_NAME"];

                    //chlTablas.Items.Add((String)row["TABLE_NAME"], false);
                    chlTablas.Items.Add(tabla, false);
                    this.tablas.Add(tabla);
                }
                this.chlTablas.Sorted = true;        
            }            
        }

        private void tiposDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCfgDataTypes frmDataTypes = new frmCfgDataTypes();
            frmDataTypes.SetDictionaryOfDataTypes(this.dataTypes);
            frmDataTypes.ShowDialog();
            this.dataTypes = frmDataTypes.GetDataTypes();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void chlTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.activeTabla =(Tabla) this.chlTablas.SelectedItem;
            this.txtWhere.Text = this.activeTabla.whereClausure;
            this.grpConfiguracion.Text = "Configuracion de " + this.activeTabla.nombre;
        }

        private void txtWhere_TextChanged(object sender, EventArgs e)
        {
            this.activeTabla.whereClausure = this.txtWhere.Text;
        }

        private void btnProcesarTablas_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = "";

            try
            {
                foreach (Tabla item in this.tablas)
                {
                    if (item.active == CheckState.Checked)
                    {
                        this.txtResultado.Text += item.GenerateInsertClause() + "\n";
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            this.chlTablas.Items.Clear();
            foreach (var item in this.tablas)
            {
                if (item.nombre.Contains(this.txtFiltro.Text))
                {
                    this.chlTablas.Items.Add(item, item.active);
                }
            }            
        }

        private void chlTablas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Tabla itemChange = (Tabla) chlTablas.Items[e.Index];
            foreach (var item in this.tablas)
            {
                if (item.nombre == itemChange.nombre)
                {
                    item.active = e.NewValue;
                    break;
                }
            }
        }
    }
}
