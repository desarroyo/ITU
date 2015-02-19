#region Importaciones
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
#endregion

/**
 * Autor:   David Arroyo
 * Fecha:   29/12/2014
 * Versión: 1.00.00
**/

namespace ITU
{
    public partial class VentanaConfiguracion : Form
    {
        #region Variables Globales
        FolderBrowserDialog dialogPendientes = null;
        FolderBrowserDialog dialogAceptados = null;
        #endregion

        #region Constructor Principal VentanaConfiguracion()
        public VentanaConfiguracion()
        {
            InitializeComponent();
            dialogPendientes = new System.Windows.Forms.FolderBrowserDialog();
            dialogAceptados = new System.Windows.Forms.FolderBrowserDialog();


            //Crea Objeto Configuration
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Modifica el Valor
            spnTiempo.Value = config.AppSettings.Settings["tiempoRefrescar"].Value == null ? 0 : decimal.Parse(config.AppSettings.Settings["tiempoRefrescar"].Value);
            txtRutaAceptados.Text = config.AppSettings.Settings["rutaReportesAceptados"].Value;
            txtRutaPendientes.Text = config.AppSettings.Settings["rutaReportesPendientes"].Value;



            txtFTPServidor.Text = config.AppSettings.Settings["ftpServidor"].Value;
            txtFTPUsuario.Text = config.AppSettings.Settings["ftpUsuario"].Value;
            txtFTPPass.Text = config.AppSettings.Settings["ftpPass"].Value;



        }
        #endregion

        #region Load Principal
        private void VentanaConfiguracion_Load(object sender, EventArgs e)
        {           
        }
        #endregion

        #region Eventos
        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            if (verificaCamposRequeridos())
            {
                //Crea Objeto Configuration
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                //Modifica el Valor
                config.AppSettings.Settings["tiempoRefrescar"].Value = "" + Convert.ToInt32(spnTiempo.Value);
                config.AppSettings.Settings["rutaReportesPendientes"].Value = "" + txtRutaPendientes.Text.Trim();
                config.AppSettings.Settings["rutaReportesAceptados"].Value = "" + txtRutaAceptados.Text.Trim();

                //Modifica el Valor FTP
                config.AppSettings.Settings["ftpServidor"].Value = "" + txtFTPServidor.Text.Trim();
                config.AppSettings.Settings["ftpUsuario"].Value = "" + txtFTPUsuario.Text.Trim();
                config.AppSettings.Settings["ftpPass"].Value = "" + txtFTPPass.Text.Trim();

                //Guarda el Cambio
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                this.Close();
            }
        }

        private void btnRutaReportes_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = dialogPendientes.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtRutaPendientes.Text = dialogPendientes.SelectedPath.ToString();
            }
        }

        private void spnTiempo_Leave(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(spnTiempo.Value);
            spnTiempo.Value = 0;
            spnTiempo.Value = valor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptados_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = dialogAceptados.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtRutaAceptados.Text = dialogAceptados.SelectedPath.ToString();
            }
        }
        #endregion


        #region verificaCamposRequeridos
        private bool verificaCamposRequeridos()
        {
            try
            {
                spnTiempo.Focus();
                Convert.ToInt32(spnTiempo.Value);
            }catch (Exception ex) {
                MessageBox.Show("Favor de llenar el campo de Verificar Archivos", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Directory.Exists(txtRutaPendientes.Text))
            {
                txtRutaPendientes.Focus();
                txtRutaPendientes.SelectAll();
                MessageBox.Show("La Ruta especificada para los Reportes Pendientes no pudo ser encontrada", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Directory.Exists(txtRutaAceptados.Text))
            {
                txtRutaAceptados.Focus();
                txtRutaAceptados.SelectAll();
                MessageBox.Show("La Ruta especificada para los Reportes Aceptados no pudo ser encontrada", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            
            if(String.IsNullOrEmpty(txtFTPServidor.Text)) {
                txtFTPServidor.Focus();
                txtFTPServidor.SelectAll();
                MessageBox.Show("Favor de especificar un Servidor FTP", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                return false;
            }

            if(String.IsNullOrEmpty(txtFTPUsuario.Text)) {
                txtFTPUsuario.Focus();
                txtFTPUsuario.SelectAll();
                MessageBox.Show("Favor de especificar un Usuario FTP", "Datos Faltantes",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            return true;
        }
        #endregion


    }
}
