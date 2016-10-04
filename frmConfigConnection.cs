using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

namespace ManualInsert
{
    public partial class frmConfigConnection : Form
    {
        public frmConfigConnection()
        {
            InitializeComponent();
        }

        private void chkConnectionStringAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkConnectionStringAutomatico.CheckState == CheckState.Checked)
            {
                this.SetEnableAllControl(this.grpAutoConnection.Controls, true);
                this.SetEnableAllControl(this.grpManualConnection.Controls, false);
            }
            else
            {
                this.SetEnableAllControl(this.grpAutoConnection.Controls, false);
                this.SetEnableAllControl(this.grpManualConnection.Controls, true);
            }
        }

        private void SetEnableAllControl(Control.ControlCollection controles, bool estado)
        {
            foreach (Control control in controles)
            {
                control.Enabled = estado;
            }
        }

        private void frmConfigConnection_Load(object sender, EventArgs e)
        {
            this.chkConnectionStringAutomatico_CheckedChanged(null, null);
            this.txtBaseDeDatos.Text = GenericDataBase.conectionString.InitialCatalog;
            this.txtServidor.Text = GenericDataBase.conectionString.DataSource;
            this.txtUsuario.Text = GenericDataBase.conectionString.UserID;
            this.txtContraseña.Text = GenericDataBase.conectionString.Password;

            this.txtConnectionString.Text = GenericDataBase.conexion.ConnectionString;

            this.SetLabelState();

            this.LoadConfigFromRegistry();
        }

        public void LoadConfigFromRegistry()
        {
            RegistryKey root_key = Registry.CurrentUser.CreateSubKey("BirdCode");
            RegistryKey app = root_key.CreateSubKey("DatabaseConnection");


            if (app.GetValue("BaseDeDator") != null)
            {
                this.txtBaseDeDatos.Text = app.GetValue("BaseDeDator").ToString();
                this.txtServidor.Text = app.GetValue("Servidor").ToString();
                this.txtUsuario.Text = app.GetValue("Usuario").ToString();
            }            
        }

        public void SaveConfigInRegistry()
        {
            RegistryKey root_key = Registry.CurrentUser.CreateSubKey("BirdCode");
            RegistryKey app = root_key.CreateSubKey("DatabaseConnection");
            app.SetValue("BaseDeDator", this.txtBaseDeDatos.Text);
            app.SetValue("Servidor", this.txtServidor.Text);
            app.SetValue("Usuario", this.txtUsuario.Text);            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            this.lblEstado.Text = "CONECTANDO...";
            this.lblEstado.ForeColor = Color.Black;

            try
            {         
                if (this.chkConnectionStringAutomatico.CheckState == CheckState.Checked)
                {
                    GenericDataBase.conectionString.DataSource = txtServidor.Text;
                    GenericDataBase.conectionString.InitialCatalog = txtBaseDeDatos.Text;
                    GenericDataBase.conectionString.UserID = txtUsuario.Text;
                    GenericDataBase.conectionString.Password = txtContraseña.Text;

                    GenericDataBase.Connectar();
                }
                else
                {
                    GenericDataBase.Connectar(this.txtConnectionString.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.SetLabelState();
        }

        private void SetLabelState()
        {
            if (GenericDataBase.conexion.State == ConnectionState.Open)
            {
                this.lblEstado.Text = "CONECTADO";
                this.lblEstado.ForeColor = Color.LawnGreen;
            }
            else
            {
                this.lblEstado.Text = "DESCONECTADO";
                this.lblEstado.ForeColor = Color.Red;
            }
        }

        private void frmConfigConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveConfigInRegistry();
        }
    }
}
