using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ManualInsert
{
    public partial class frmCfgDataTypes : Form
    {
        private Dictionary<String, List<String>> dataTypes;

        public frmCfgDataTypes()
        {
            InitializeComponent();
        }

        public void SetDictionaryOfDataTypes(Dictionary<String, List<String>> _dataTypes)
        {
            this.dataTypes = _dataTypes;
        }

        private void frmCfgDataTypes_Load(object sender, EventArgs e)
        {
            foreach (var kvp in this.dataTypes)
            {
                ListViewItem lvi = this.lvwDataTypes.Items.Add(kvp.Key);
                string temp = string.Join(", ", kvp.Value);
                lvi.SubItems.Add(temp);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lvwItem = new ListViewItem(this.txtDatoC.Text);
            lvwItem.SubItems.Add(this.txtDatoSQL.Text);
            this.lvwDataTypes.Items.Add(lvwItem);

            List<String> tiposSQL = new List<string>(this.txtDatoSQL.Text.Split(",".ToCharArray()));
            this.dataTypes.Add(this.txtDatoC.Text, tiposSQL);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.lvwDataTypes.SelectedItems)
            {
                item.Remove();
                this.dataTypes.Remove(item.Text);
            }
        }

        public Dictionary<String, List<String>> GetDataTypes()
        {
            return this.dataTypes;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://msdn.microsoft.com/en-us/library/cc716729(v=vs.110).aspx");
            Process.Start(sInfo);            
        }
    }
}
