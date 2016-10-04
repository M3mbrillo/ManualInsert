namespace ManualInsert
{
    partial class frmConfigConnection
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
            this.grpAutoConnection = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUsarTruestedConnection = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBaseDeDatos = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.grpManualConnection = new System.Windows.Forms.GroupBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.chkConnectionStringAutomatico = new System.Windows.Forms.CheckBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpAutoConnection.SuspendLayout();
            this.grpManualConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAutoConnection
            // 
            this.grpAutoConnection.Controls.Add(this.label4);
            this.grpAutoConnection.Controls.Add(this.label3);
            this.grpAutoConnection.Controls.Add(this.label2);
            this.grpAutoConnection.Controls.Add(this.label1);
            this.grpAutoConnection.Controls.Add(this.chkUsarTruestedConnection);
            this.grpAutoConnection.Controls.Add(this.txtContraseña);
            this.grpAutoConnection.Controls.Add(this.txtUsuario);
            this.grpAutoConnection.Controls.Add(this.txtBaseDeDatos);
            this.grpAutoConnection.Controls.Add(this.txtServidor);
            this.grpAutoConnection.Location = new System.Drawing.Point(12, 36);
            this.grpAutoConnection.Name = "grpAutoConnection";
            this.grpAutoConnection.Size = new System.Drawing.Size(496, 154);
            this.grpAutoConnection.TabIndex = 0;
            this.grpAutoConnection.TabStop = false;
            this.grpAutoConnection.Text = "Automatico Connection String";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Base de datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servidor";
            // 
            // chkUsarTruestedConnection
            // 
            this.chkUsarTruestedConnection.AutoSize = true;
            this.chkUsarTruestedConnection.Location = new System.Drawing.Point(112, 123);
            this.chkUsarTruestedConnection.Name = "chkUsarTruestedConnection";
            this.chkUsarTruestedConnection.Size = new System.Drawing.Size(145, 17);
            this.chkUsarTruestedConnection.TabIndex = 4;
            this.chkUsarTruestedConnection.Text = "Usar truested connection";
            this.chkUsarTruestedConnection.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(112, 97);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(261, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(112, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(261, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtBaseDeDatos
            // 
            this.txtBaseDeDatos.Location = new System.Drawing.Point(112, 45);
            this.txtBaseDeDatos.Name = "txtBaseDeDatos";
            this.txtBaseDeDatos.Size = new System.Drawing.Size(261, 20);
            this.txtBaseDeDatos.TabIndex = 1;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(112, 19);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(261, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // grpManualConnection
            // 
            this.grpManualConnection.Controls.Add(this.txtConnectionString);
            this.grpManualConnection.Location = new System.Drawing.Point(12, 196);
            this.grpManualConnection.Name = "grpManualConnection";
            this.grpManualConnection.Size = new System.Drawing.Size(496, 48);
            this.grpManualConnection.TabIndex = 1;
            this.grpManualConnection.TabStop = false;
            this.grpManualConnection.Text = "Manual Connetion String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(6, 19);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(484, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // chkConnectionStringAutomatico
            // 
            this.chkConnectionStringAutomatico.AutoSize = true;
            this.chkConnectionStringAutomatico.Checked = true;
            this.chkConnectionStringAutomatico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConnectionStringAutomatico.Location = new System.Drawing.Point(12, 12);
            this.chkConnectionStringAutomatico.Name = "chkConnectionStringAutomatico";
            this.chkConnectionStringAutomatico.Size = new System.Drawing.Size(185, 17);
            this.chkConnectionStringAutomatico.TabIndex = 2;
            this.chkConnectionStringAutomatico.Text = "Usar Connetion String Automatico";
            this.chkConnectionStringAutomatico.UseVisualStyleBackColor = true;
            this.chkConnectionStringAutomatico.CheckedChanged += new System.EventHandler(this.chkConnectionStringAutomatico_CheckedChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 251);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(185, 23);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(203, 248);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(118, 29);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "ESTADO";
            // 
            // frmConfigConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 286);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.chkConnectionStringAutomatico);
            this.Controls.Add(this.grpManualConnection);
            this.Controls.Add(this.grpAutoConnection);
            this.Name = "frmConfigConnection";
            this.Text = "Configurar Conexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfigConnection_FormClosing);
            this.Load += new System.EventHandler(this.frmConfigConnection_Load);
            this.grpAutoConnection.ResumeLayout(false);
            this.grpAutoConnection.PerformLayout();
            this.grpManualConnection.ResumeLayout(false);
            this.grpManualConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutoConnection;
        private System.Windows.Forms.GroupBox grpManualConnection;
        private System.Windows.Forms.CheckBox chkConnectionStringAutomatico;
        private System.Windows.Forms.CheckBox chkUsarTruestedConnection;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtBaseDeDatos;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblEstado;
    }
}