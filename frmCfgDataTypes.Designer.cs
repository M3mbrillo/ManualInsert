namespace ManualInsert
{
    partial class frmCfgDataTypes
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
            this.lvwDataTypes = new System.Windows.Forms.ListView();
            this.DataCSharp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataSQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatoC = new System.Windows.Forms.TextBox();
            this.txtDatoSQL = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lvwDataTypes
            // 
            this.lvwDataTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataCSharp,
            this.DataSQL});
            this.lvwDataTypes.Location = new System.Drawing.Point(13, 89);
            this.lvwDataTypes.Name = "lvwDataTypes";
            this.lvwDataTypes.Size = new System.Drawing.Size(321, 303);
            this.lvwDataTypes.TabIndex = 0;
            this.lvwDataTypes.UseCompatibleStateImageBehavior = false;
            this.lvwDataTypes.View = System.Windows.Forms.View.Details;
            // 
            // DataCSharp
            // 
            this.DataCSharp.Text = "Tipo de Dato CSharp";
            this.DataCSharp.Width = 138;
            // 
            // DataSQL
            // 
            this.DataSQL.Text = "Tipo de dato SQL";
            this.DataSQL.Width = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dato SQL";
            // 
            // txtDatoC
            // 
            this.txtDatoC.Location = new System.Drawing.Point(66, 10);
            this.txtDatoC.Name = "txtDatoC";
            this.txtDatoC.Size = new System.Drawing.Size(268, 20);
            this.txtDatoC.TabIndex = 3;
            // 
            // txtDatoSQL
            // 
            this.txtDatoSQL.Location = new System.Drawing.Point(66, 34);
            this.txtDatoSQL.Name = "txtDatoSQL";
            this.txtDatoSQL.Size = new System.Drawing.Size(268, 20);
            this.txtDatoSQL.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(179, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 399);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Conversion de SQL a C#.NET";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmCfgDataTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 419);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDatoSQL);
            this.Controls.Add(this.txtDatoC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwDataTypes);
            this.Name = "frmCfgDataTypes";
            this.Text = "Tipos de Datos";
            this.Load += new System.EventHandler(this.frmCfgDataTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwDataTypes;
        private System.Windows.Forms.ColumnHeader DataSQL;
        private System.Windows.Forms.ColumnHeader DataCSharp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatoC;
        private System.Windows.Forms.TextBox txtDatoSQL;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}