using System.Configuration;
namespace ITU
{
    partial class VentanaConfiguracion
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
            this.lblTiempoRefrescar = new System.Windows.Forms.Label();
            this.spnTiempo = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo02 = new System.Windows.Forms.Label();
            this.lblRutaReportes = new System.Windows.Forms.Label();
            this.txtRutaPendientes = new System.Windows.Forms.TextBox();
            this.btnGuardarSalir = new System.Windows.Forms.Button();
            this.btnRutaPendientes = new System.Windows.Forms.Button();
            this.lblFTP = new System.Windows.Forms.Label();
            this.lblFTPServidor = new System.Windows.Forms.Label();
            this.lblFTPUsuario = new System.Windows.Forms.Label();
            this.lblFTPPass = new System.Windows.Forms.Label();
            this.txtFTPServidor = new System.Windows.Forms.TextBox();
            this.txtFTPUsuario = new System.Windows.Forms.TextBox();
            this.txtFTPPass = new System.Windows.Forms.TextBox();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaAceptados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spnTiempo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTiempoRefrescar
            // 
            this.lblTiempoRefrescar.AutoSize = true;
            this.lblTiempoRefrescar.Location = new System.Drawing.Point(3, 10);
            this.lblTiempoRefrescar.Name = "lblTiempoRefrescar";
            this.lblTiempoRefrescar.Size = new System.Drawing.Size(119, 13);
            this.lblTiempoRefrescar.TabIndex = 0;
            this.lblTiempoRefrescar.Text = "Verificar Archivos cada:";
            // 
            // spnTiempo
            // 
            this.spnTiempo.Location = new System.Drawing.Point(128, 8);
            this.spnTiempo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spnTiempo.Name = "spnTiempo";
            this.spnTiempo.Size = new System.Drawing.Size(51, 20);
            this.spnTiempo.TabIndex = 1;
            this.spnTiempo.ThousandsSeparator = true;
            this.spnTiempo.Leave += new System.EventHandler(this.spnTiempo_Leave);
            // 
            // lblTiempo02
            // 
            this.lblTiempo02.AutoSize = true;
            this.lblTiempo02.Location = new System.Drawing.Point(185, 10);
            this.lblTiempo02.Name = "lblTiempo02";
            this.lblTiempo02.Size = new System.Drawing.Size(24, 13);
            this.lblTiempo02.TabIndex = 2;
            this.lblTiempo02.Text = "seg";
            // 
            // lblRutaReportes
            // 
            this.lblRutaReportes.AutoSize = true;
            this.lblRutaReportes.Location = new System.Drawing.Point(33, 37);
            this.lblRutaReportes.Name = "lblRutaReportes";
            this.lblRutaReportes.Size = new System.Drawing.Size(89, 13);
            this.lblRutaReportes.TabIndex = 3;
            this.lblRutaReportes.Text = "Ruta Pendientes:";
            this.lblRutaReportes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRutaPendientes
            // 
            this.txtRutaPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRutaPendientes.Location = new System.Drawing.Point(128, 34);
            this.txtRutaPendientes.Name = "txtRutaPendientes";
            this.txtRutaPendientes.Size = new System.Drawing.Size(219, 20);
            this.txtRutaPendientes.TabIndex = 4;
            this.txtRutaPendientes.Text = "C:\\Reportes Pendientes\\";
            // 
            // btnGuardarSalir
            // 
            this.btnGuardarSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarSalir.Location = new System.Drawing.Point(333, 260);
            this.btnGuardarSalir.Name = "btnGuardarSalir";
            this.btnGuardarSalir.Size = new System.Drawing.Size(94, 23);
            this.btnGuardarSalir.TabIndex = 5;
            this.btnGuardarSalir.Text = "Guardar y Salir";
            this.btnGuardarSalir.UseVisualStyleBackColor = true;
            this.btnGuardarSalir.Click += new System.EventHandler(this.btnGuardarSalir_Click);
            // 
            // btnRutaPendientes
            // 
            this.btnRutaPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRutaPendientes.Location = new System.Drawing.Point(350, 34);
            this.btnRutaPendientes.Name = "btnRutaPendientes";
            this.btnRutaPendientes.Size = new System.Drawing.Size(27, 22);
            this.btnRutaPendientes.TabIndex = 6;
            this.btnRutaPendientes.Text = "...";
            this.btnRutaPendientes.UseVisualStyleBackColor = true;
            this.btnRutaPendientes.Click += new System.EventHandler(this.btnRutaReportes_Click);
            // 
            // lblFTP
            // 
            this.lblFTP.AutoSize = true;
            this.lblFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTP.Location = new System.Drawing.Point(14, 133);
            this.lblFTP.Name = "lblFTP";
            this.lblFTP.Size = new System.Drawing.Size(32, 15);
            this.lblFTP.TabIndex = 7;
            this.lblFTP.Text = "FTP";
            // 
            // lblFTPServidor
            // 
            this.lblFTPServidor.AutoSize = true;
            this.lblFTPServidor.Location = new System.Drawing.Point(70, 15);
            this.lblFTPServidor.Name = "lblFTPServidor";
            this.lblFTPServidor.Size = new System.Drawing.Size(49, 13);
            this.lblFTPServidor.TabIndex = 8;
            this.lblFTPServidor.Text = "Servidor:";
            this.lblFTPServidor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFTPUsuario
            // 
            this.lblFTPUsuario.AutoSize = true;
            this.lblFTPUsuario.Location = new System.Drawing.Point(73, 41);
            this.lblFTPUsuario.Name = "lblFTPUsuario";
            this.lblFTPUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblFTPUsuario.TabIndex = 9;
            this.lblFTPUsuario.Text = "Usuario:";
            this.lblFTPUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFTPPass
            // 
            this.lblFTPPass.AutoSize = true;
            this.lblFTPPass.Location = new System.Drawing.Point(55, 67);
            this.lblFTPPass.Name = "lblFTPPass";
            this.lblFTPPass.Size = new System.Drawing.Size(64, 13);
            this.lblFTPPass.TabIndex = 10;
            this.lblFTPPass.Text = "Contraseña:";
            this.lblFTPPass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFTPServidor
            // 
            this.txtFTPServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTPServidor.Location = new System.Drawing.Point(125, 12);
            this.txtFTPServidor.Name = "txtFTPServidor";
            this.txtFTPServidor.Size = new System.Drawing.Size(252, 20);
            this.txtFTPServidor.TabIndex = 11;
            this.txtFTPServidor.Text = "ftp://127.0.0.1:81/";
            // 
            // txtFTPUsuario
            // 
            this.txtFTPUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTPUsuario.Location = new System.Drawing.Point(125, 38);
            this.txtFTPUsuario.Name = "txtFTPUsuario";
            this.txtFTPUsuario.Size = new System.Drawing.Size(252, 20);
            this.txtFTPUsuario.TabIndex = 12;
            this.txtFTPUsuario.Text = "PIXVS";
            // 
            // txtFTPPass
            // 
            this.txtFTPPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTPPass.Location = new System.Drawing.Point(125, 64);
            this.txtFTPPass.Name = "txtFTPPass";
            this.txtFTPPass.PasswordChar = '*';
            this.txtFTPPass.Size = new System.Drawing.Size(252, 20);
            this.txtFTPPass.TabIndex = 13;
            this.txtFTPPass.Text = "sapo133x10";
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivos.Location = new System.Drawing.Point(14, 9);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(60, 15);
            this.lblArchivos.TabIndex = 14;
            this.lblArchivos.Text = "Archivos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(233, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFTPServidor);
            this.panel1.Controls.Add(this.lblFTPUsuario);
            this.panel1.Controls.Add(this.txtFTPPass);
            this.panel1.Controls.Add(this.lblFTPPass);
            this.panel1.Controls.Add(this.txtFTPUsuario);
            this.panel1.Controls.Add(this.txtFTPServidor);
            this.panel1.Location = new System.Drawing.Point(17, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 103);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAceptados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtRutaAceptados);
            this.panel2.Controls.Add(this.lblTiempoRefrescar);
            this.panel2.Controls.Add(this.spnTiempo);
            this.panel2.Controls.Add(this.lblTiempo02);
            this.panel2.Controls.Add(this.btnRutaPendientes);
            this.panel2.Controls.Add(this.lblRutaReportes);
            this.panel2.Controls.Add(this.txtRutaPendientes);
            this.panel2.Location = new System.Drawing.Point(17, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 94);
            this.panel2.TabIndex = 17;
            // 
            // btnAceptados
            // 
            this.btnAceptados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptados.Location = new System.Drawing.Point(350, 60);
            this.btnAceptados.Name = "btnAceptados";
            this.btnAceptados.Size = new System.Drawing.Size(27, 22);
            this.btnAceptados.TabIndex = 17;
            this.btnAceptados.Text = "...";
            this.btnAceptados.UseVisualStyleBackColor = true;
            this.btnAceptados.Click += new System.EventHandler(this.btnAceptados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ruta Aceptados:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRutaAceptados
            // 
            this.txtRutaAceptados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRutaAceptados.Location = new System.Drawing.Point(128, 60);
            this.txtRutaAceptados.Name = "txtRutaAceptados";
            this.txtRutaAceptados.Size = new System.Drawing.Size(219, 20);
            this.txtRutaAceptados.TabIndex = 16;
            this.txtRutaAceptados.Text = "C:\\Reportes Aceptados\\";
            // 
            // VentanaConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 295);
            this.ControlBox = false;
            this.Controls.Add(this.lblFTP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.btnGuardarSalir);
            this.Name = "VentanaConfiguracion";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.spnTiempo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempoRefrescar;
        private System.Windows.Forms.NumericUpDown spnTiempo;
        private System.Windows.Forms.Label lblTiempo02;
        private System.Windows.Forms.Label lblRutaReportes;
        private System.Windows.Forms.TextBox txtRutaPendientes;
        private System.Windows.Forms.Button btnGuardarSalir;
        private System.Windows.Forms.Button btnRutaPendientes;
        private System.Windows.Forms.Label lblFTP;
        private System.Windows.Forms.Label lblFTPServidor;
        private System.Windows.Forms.Label lblFTPUsuario;
        private System.Windows.Forms.Label lblFTPPass;
        private System.Windows.Forms.TextBox txtFTPServidor;
        private System.Windows.Forms.TextBox txtFTPUsuario;
        private System.Windows.Forms.TextBox txtFTPPass;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAceptados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaAceptados;
    }
}