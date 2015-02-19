using System.Drawing;
namespace ITU
{
    partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.txtConsola = new System.Windows.Forms.RichTextBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRefrescarPendientes = new System.Windows.Forms.ToolStripMenuItem();
            this.iconoNotificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.tiraMenuIcono = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.btnFTP = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblPendientes = new System.Windows.Forms.DataGridView();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAceptados = new System.Windows.Forms.TabPage();
            this.tblAceptados = new System.Windows.Forms.DataGridView();
            this.aceptadoRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptadoArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptadoFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptadoFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptadoAcronimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptadoEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPausar = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.tiraMenuIcono.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPendientes)).BeginInit();
            this.tabAceptados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAceptados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsola
            // 
            this.txtConsola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsola.EnableAutoDragDrop = true;
            this.txtConsola.Location = new System.Drawing.Point(0, 0);
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.ReadOnly = true;
            this.txtConsola.Size = new System.Drawing.Size(480, 205);
            this.txtConsola.TabIndex = 0;
            this.txtConsola.Text = "";
            // 
            // btnOcultar
            // 
            this.btnOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcultar.Location = new System.Drawing.Point(429, 264);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(75, 23);
            this.btnOcultar.TabIndex = 1;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(516, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrescarPendientesToolStripMenuItem,
            this.configuraciónToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // refrescarPendientesToolStripMenuItem
            // 
            this.refrescarPendientesToolStripMenuItem.Name = "refrescarPendientesToolStripMenuItem";
            this.refrescarPendientesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.refrescarPendientesToolStripMenuItem.Text = "Refrescar Pendientes";
            this.refrescarPendientesToolStripMenuItem.Click += new System.EventHandler(this.refrescarPendientesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.configuraciónToolStripMenuItem1.Text = "Configuración";
            this.configuraciónToolStripMenuItem1.Click += new System.EventHandler(this.configuraciónToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // menuItemRefrescarPendientes
            // 
            this.menuItemRefrescarPendientes.Name = "menuItemRefrescarPendientes";
            this.menuItemRefrescarPendientes.Size = new System.Drawing.Size(183, 22);
            this.menuItemRefrescarPendientes.Text = "Refrescar Pendientes";
            this.menuItemRefrescarPendientes.Click += new System.EventHandler(this.menuItemRefrescarPendientes_Click);
            // 
            // iconoNotificacion
            // 
            this.iconoNotificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconoNotificacion.BalloonTipText = "Uploader...";
            this.iconoNotificacion.BalloonTipTitle = "Indetec Transparencia Uploader";
            this.iconoNotificacion.ContextMenuStrip = this.tiraMenuIcono;
            this.iconoNotificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("iconoNotificacion.Icon")));
            this.iconoNotificacion.Text = "ITU";
            this.iconoNotificacion.Visible = true;
            this.iconoNotificacion.DoubleClick += new System.EventHandler(this.iconoNotificacion_DoubleClick);
            // 
            // tiraMenuIcono
            // 
            this.tiraMenuIcono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbrir,
            this.menuItemRefrescarPendientes,
            this.menuItemSalir});
            this.tiraMenuIcono.Name = "tiraMenuIcono";
            this.tiraMenuIcono.Size = new System.Drawing.Size(184, 70);
            // 
            // menuItemAbrir
            // 
            this.menuItemAbrir.Name = "menuItemAbrir";
            this.menuItemAbrir.Size = new System.Drawing.Size(183, 22);
            this.menuItemAbrir.Text = "Abrir";
            this.menuItemAbrir.Click += new System.EventHandler(this.menuItemAbrir_Click);
            // 
            // menuItemSalir
            // 
            this.menuItemSalir.Name = "menuItemSalir";
            this.menuItemSalir.Size = new System.Drawing.Size(183, 22);
            this.menuItemSalir.Text = "Salir";
            this.menuItemSalir.Click += new System.EventHandler(this.menuItemSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(348, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDragDrop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragDrop.Location = new System.Drawing.Point(13, 264);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(74, 16);
            this.lblDragDrop.TabIndex = 4;
            this.lblDragDrop.Text = "Drag / Drop";
            // 
            // btnFTP
            // 
            this.btnFTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTP.Location = new System.Drawing.Point(267, 264);
            this.btnFTP.Name = "btnFTP";
            this.btnFTP.Size = new System.Drawing.Size(75, 23);
            this.btnFTP.TabIndex = 5;
            this.btnFTP.Text = "FTP";
            this.btnFTP.UseVisualStyleBackColor = true;
            this.btnFTP.Click += new System.EventHandler(this.btnFTP_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabAceptados);
            this.tabControl.Location = new System.Drawing.Point(16, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(488, 231);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtConsola);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consola";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tblPendientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblPendientes
            // 
            this.tblPendientes.AllowUserToAddRows = false;
            this.tblPendientes.AllowUserToDeleteRows = false;
            this.tblPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ruta,
            this.Archivo,
            this.Estatus});
            this.tblPendientes.Location = new System.Drawing.Point(0, 0);
            this.tblPendientes.Name = "tblPendientes";
            this.tblPendientes.Size = new System.Drawing.Size(480, 205);
            this.tblPendientes.TabIndex = 0;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.Name = "Archivo";
            this.Archivo.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // tabAceptados
            // 
            this.tabAceptados.Controls.Add(this.tblAceptados);
            this.tabAceptados.Location = new System.Drawing.Point(4, 22);
            this.tabAceptados.Name = "tabAceptados";
            this.tabAceptados.Padding = new System.Windows.Forms.Padding(3);
            this.tabAceptados.Size = new System.Drawing.Size(480, 205);
            this.tabAceptados.TabIndex = 2;
            this.tabAceptados.Text = "Aceptados";
            this.tabAceptados.UseVisualStyleBackColor = true;
            // 
            // tblAceptados
            // 
            this.tblAceptados.AllowUserToAddRows = false;
            this.tblAceptados.AllowUserToDeleteRows = false;
            this.tblAceptados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAceptados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblAceptados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAceptados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aceptadoRuta,
            this.aceptadoArchivo,
            this.aceptadoFechaInicio,
            this.aceptadoFechaFin,
            this.aceptadoAcronimo,
            this.aceptadoEstatus});
            this.tblAceptados.Location = new System.Drawing.Point(0, 3);
            this.tblAceptados.Name = "tblAceptados";
            this.tblAceptados.Size = new System.Drawing.Size(480, 202);
            this.tblAceptados.TabIndex = 1;
            // 
            // aceptadoRuta
            // 
            this.aceptadoRuta.FillWeight = 82.75449F;
            this.aceptadoRuta.HeaderText = "Ruta";
            this.aceptadoRuta.Name = "aceptadoRuta";
            this.aceptadoRuta.ReadOnly = true;
            // 
            // aceptadoArchivo
            // 
            this.aceptadoArchivo.FillWeight = 82.75449F;
            this.aceptadoArchivo.HeaderText = "Archivo";
            this.aceptadoArchivo.Name = "aceptadoArchivo";
            this.aceptadoArchivo.ReadOnly = true;
            // 
            // aceptadoFechaInicio
            // 
            this.aceptadoFechaInicio.FillWeight = 152.2843F;
            this.aceptadoFechaInicio.HeaderText = "Fecha Inicio";
            this.aceptadoFechaInicio.Name = "aceptadoFechaInicio";
            this.aceptadoFechaInicio.ReadOnly = true;
            // 
            // aceptadoFechaFin
            // 
            this.aceptadoFechaFin.FillWeight = 134.6371F;
            this.aceptadoFechaFin.HeaderText = "Fecha Fin";
            this.aceptadoFechaFin.Name = "aceptadoFechaFin";
            this.aceptadoFechaFin.ReadOnly = true;
            // 
            // aceptadoAcronimo
            // 
            this.aceptadoAcronimo.FillWeight = 72.88136F;
            this.aceptadoAcronimo.HeaderText = "Acronimo";
            this.aceptadoAcronimo.Name = "aceptadoAcronimo";
            this.aceptadoAcronimo.ReadOnly = true;
            // 
            // aceptadoEstatus
            // 
            this.aceptadoEstatus.FillWeight = 74.68827F;
            this.aceptadoEstatus.HeaderText = "Estatus";
            this.aceptadoEstatus.Name = "aceptadoEstatus";
            this.aceptadoEstatus.ReadOnly = true;
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPausar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(186, 264);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 7;
            this.btnPausar.Text = "ll";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 299);
            this.ControlBox = false;
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnFTP);
            this.Controls.Add(this.lblDragDrop);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "VentanaPrincipal";
            this.Text = "Indetec Transparencia Uploader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tiraMenuIcono.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPendientes)).EndInit();
            this.tabAceptados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAceptados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.RichTextBox txtConsola;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon iconoNotificacion;
        private System.Windows.Forms.ContextMenuStrip tiraMenuIcono;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefrescarPendientes;
        private System.Windows.Forms.ToolStripMenuItem menuItemSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.Button btnFTP;
        private System.Threading.Thread hiloVerificar;
        private System.Windows.Forms.ToolStripMenuItem refrescarPendientesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tblPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private int tiempoRefrescar = 60;
        private string rutaReportes = "C:\\Reportes Pendientes\\";
        private bool ignoraVerificaPendientes = false;
        private System.Windows.Forms.TabPage tabAceptados;
        private System.Windows.Forms.DataGridView tblAceptados;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptadoRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptadoArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptadoFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptadoFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptadoAcronimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptadoEstatus;
        private System.Windows.Forms.Button btnPausar;
    }
}

