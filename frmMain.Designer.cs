namespace ManualInsert
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chlTablas = new System.Windows.Forms.CheckedListBox();
            this.grpConfiguracion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnProcesarTablas = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpConfiguracion.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexionToolStripMenuItem,
            this.tiposDeDatosToolStripMenuItem});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conexionToolStripMenuItem.Text = "Conexion";
            this.conexionToolStripMenuItem.Click += new System.EventHandler(this.conexionToolStripMenuItem_Click);
            // 
            // tiposDeDatosToolStripMenuItem
            // 
            this.tiposDeDatosToolStripMenuItem.Name = "tiposDeDatosToolStripMenuItem";
            this.tiposDeDatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tiposDeDatosToolStripMenuItem.Text = "Tipos de Datos";
            this.tiposDeDatosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDatosToolStripMenuItem_Click);
            // 
            // chlTablas
            // 
            this.chlTablas.FormattingEnabled = true;
            this.chlTablas.Location = new System.Drawing.Point(12, 72);
            this.chlTablas.Name = "chlTablas";
            this.chlTablas.Size = new System.Drawing.Size(192, 394);
            this.chlTablas.TabIndex = 1;
            this.chlTablas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlTablas_ItemCheck);
            this.chlTablas.SelectedIndexChanged += new System.EventHandler(this.chlTablas_SelectedIndexChanged);
            // 
            // grpConfiguracion
            // 
            this.grpConfiguracion.Controls.Add(this.label1);
            this.grpConfiguracion.Controls.Add(this.txtWhere);
            this.grpConfiguracion.Location = new System.Drawing.Point(211, 42);
            this.grpConfiguracion.Name = "grpConfiguracion";
            this.grpConfiguracion.Size = new System.Drawing.Size(646, 159);
            this.grpConfiguracion.TabIndex = 3;
            this.grpConfiguracion.TabStop = false;
            this.grpConfiguracion.Text = "Configuracion de Tabla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clausula WHERE";
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(7, 40);
            this.txtWhere.Multiline = true;
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(633, 113);
            this.txtWhere.TabIndex = 0;
            this.txtWhere.TextChanged += new System.EventHandler(this.txtWhere_TextChanged);
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.txtResultado);
            this.grpResultado.Location = new System.Drawing.Point(211, 208);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(646, 225);
            this.grpResultado.TabIndex = 4;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(7, 20);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(633, 199);
            this.txtResultado.TabIndex = 0;
            // 
            // btnProcesarTablas
            // 
            this.btnProcesarTablas.Location = new System.Drawing.Point(211, 442);
            this.btnProcesarTablas.Name = "btnProcesarTablas";
            this.btnProcesarTablas.Size = new System.Drawing.Size(176, 23);
            this.btnProcesarTablas.TabIndex = 5;
            this.btnProcesarTablas.Text = "Procesar Tablas";
            this.btnProcesarTablas.UseVisualStyleBackColor = true;
            this.btnProcesarTablas.Click += new System.EventHandler(this.btnProcesarTablas_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(394, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(13, 42);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(191, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 477);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProcesarTablas);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpConfiguracion);
            this.Controls.Add(this.chlTablas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Insert Manuall";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpConfiguracion.ResumeLayout(false);
            this.grpConfiguracion.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox chlTablas;
        private System.Windows.Forms.GroupBox grpConfiguracion;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Button btnProcesarTablas;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}

