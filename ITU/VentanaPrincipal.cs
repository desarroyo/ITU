#region Importaciones
using FtpLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

/**
 * Autor:   David Arroyo
 * Fecha:   29/12/2014
 * Versión: 1.00.00
**/

namespace ITU
{
    public partial class VentanaPrincipal : Form
    {
        #region Variables y Constantes Globales
        private const int AL_ACRONIMO = 0;
        private const int AL_NOMBRE = 1;
        private const int AL_FECHA_INI = 2;
        private const int AL_FECHA_FIN = 3;
        private const int AL_EXT = 4;
        #endregion

        #region Constructor Principal VentanaPrincipal()
        public VentanaPrincipal()
        {
            InitializeComponent();

            // Put the Main thread to sleep for 1 millisecond to allow oThread
            // to do some work:
            Thread.Sleep(100);

            #region Inicializacion Hilo Verifica Pendientes

            Control.CheckForIllegalCrossThreadCalls = false;
            // Create the thread object, passing in the Alpha.Beta method
            // via a ThreadStart delegate. This does not start the thread.
            hiloVerificar = new Thread(new ThreadStart(this.HiloVerificaPendientes));
            getTiempoRefrescar();


            // Start the thread
            hiloVerificar.Start();

            // Spin for a while waiting for the started thread to become
            // alive:
            while (!hiloVerificar.IsAlive) ;

            // Put the Main thread to sleep for 1 millisecond to allow oThread
            // to do some work:
            Thread.Sleep(500);

            #endregion inicializacionHiloVerificaPendientes

            #region Habilitar Drag & Drop

            this.AllowDrop = true;

            // Add event handlers for the drag & drop functionality
            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);

            #endregion

            txtConsola.AppendText(" Transparencia Uloader - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm") + Environment.NewLine +
                   "------------------------------------------------------------------------------" + Environment.NewLine);

            #region Ocultar Formulario al Iniciar
            //this.BeginInvoke((MethodInvoker)delegate
            //{
            //MostrarNotificacionIcono();
            //this.Hide();


            //});
            #endregion

        }
        #endregion       

        #region Eventos

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            hiloVerificar.Abort();
            Application.Exit();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            muestraNotificacionIconoTexto("Transparencia Uploader", "Ejecutandose en Segundo Plano", 1000);
            BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                this.Hide();
            }));
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            this.Show();
            hiloVerificar.Abort();
            Application.Exit();
        }
        private void menuItemAbrir_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void menuItemRefrescarPendientes_Click(object sender, EventArgs e)
        {
            this.Show();

            verificaPendientes();
        }

        private void iconoNotificacion_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void refrescarPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verificaPendientes();
        }

        private void configuraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaConfiguracion ventanaConfiguracion = new VentanaConfiguracion();
            ventanaConfiguracion.ShowDialog();

            getTiempoRefrescar();
        }

        //Cancelar ALT + F4
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        } 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TransparenciaEntities tm = new TransparenciaEntities();
            //CatalogoTransparenciaReportes archivo = new CatalogoTransparenciaReportes();
            //archivo.CTR_DescripcionArchivo = "x.txt";
            //archivo.CTR_MR_MapeoId = new Guid("55d16f9f-87e8-4a23-adb2-3b58e88f6097");
            //archivo.CTR_NombreArchivo = "x.txt";
            //archivo.CTR_DescripcionArchivo = "X";
            //archivo.CTR_FechaInicio = DateTime.Now;
            //archivo.CTR_FechaFin = DateTime.Now;
            //archivo.CTR_FechaFin = DateTime.Now;
            //archivo.CTR_USU_ModificadoPorId = new Guid("55d16f9f-87e8-4a23-adb2-3b58e88f6097");
            //archivo.CTR_USU_SubidoPorId = new Guid("55d16f9f-87e8-4a23-adb2-3b58e88f6097");

            //tm.CatalogoTransparenciaReportes.Add(archivo);
            //tm.SaveChanges();

            //txtConsola.AppendText(Environment.NewLine + " Archivo '" + archivo.CTR_DescripcionArchivo + "' Guardado");
            //muestraNotificacionIconoTexto("Archivos", " Archivo '" + archivo.CTR_DescripcionArchivo + "' Guardado", 1000);            

        }

        // Drag de Archivos
        void Form_DragEnter(object sender, DragEventArgs e)
        {
            // Checa que sean Archivos
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Ok
            else
                e.Effect = DragDropEffects.None; // Datos Desconocidos

        }

        // Drop de Archivos
        void Form_DragDrop(object sender, DragEventArgs e)
        {
            this.txtConsola.Text += "\nAgregar Archivos: \n\n";
            // Extrae los datos de DataObject-Container en un arreglo
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // Do something with the data...


            // manda los archivos al text field
            foreach (string File in FileList)
                this.txtConsola.Text += File + "\n";

            if (FileList.Length > 0)
                procesarArchivos(FileList, true);
        
        }

        private void btnFTP_Click(object sender, EventArgs e)
        {
            /* Instancia FTP */
            FTP ftp = new FTP(@"ftp://127.0.0.1:81/", "PIXVS", "sapo133x10");

            /* Subir Archivo */
            ftp.upload("PENDIENTES/test.txt", @"C:\ARCHIVOS\TMP\test.txt");

        }

        #endregion



        #region Guardar en Base de Datos
        public void guardarArchivosBD(string ruta, string nombre, ArrayList alDatos)
        {
            try
            {
                TransparenciaEntities tm = new TransparenciaEntities();
                //CatalogoTransparenciaReportes reporte = new CatalogoTransparenciaReportes();

                //reporte.CTR_ReporteId = Guid.NewGuid();
                //reporte.CTR_MR_MapeoId = new Guid("55d16f9f-87e8-4a23-adb2-3b58e88f6097");
                //reporte.CTR_NombreArchivo = nombre;
                //reporte.CTR_DescripcionArchivo = nombre;
                ////archivo.CTR_FechaRegistro = DateTime.Now;
                ////archivo.CTR_FechaUltimaModificacion = null;
                //reporte.CTR_FechaInicio = null;
                //reporte.CTR_FechaFin = new DateTime(2015, 1, 1);
                //reporte.CTR_USU_ModificadoPorId = new Guid("4b4a8da6-45af-482a-a574-7208de0f0668");
                //reporte.CTR_USU_SubidoPorId = new Guid("4b4a8da6-45af-482a-a574-7208de0f0668");
                //reporte.CTR_Visible = true;
                //reporte.CTR_Borrado = false;

                DateTime? fechaInicio = (DateTime?)alDatos[AL_FECHA_INI];
                DateTime? fechaFin = (DateTime?)alDatos[AL_FECHA_FIN];
                string acronimo = (string)alDatos[AL_ACRONIMO];

                tm.sp_CreaCatalogoTransparenciaReportes(null, nombre, null, fechaInicio, fechaFin, false, null, true);


                //MapeosReportes archivo = new MapeosReportes();
                //archivo.MR_MapeoId = Guid.NewGuid();
                //archivo.MR_RutaFisicaReporte = "x.txt";
                //archivo.MR_CT_NodoId = new Guid("aa5478a2-a3ee-406d-bbbe-f2fc998bc368");
                //archivo.MR_Acronimo = "x.txt";

                //tm.MapeosReportes.Add(archivo);

                tm.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityCommandExecutionException ex) { throw ex; }
            catch (System.Data.Entity.Core.EntityException ex) { throw ex; }
            catch (System.Net.WebException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region Procesar Archivos ( FTP - SQL - io )
        public void procesarArchivos(string[] FileList, bool preguntar)
        {
            btnPausar.Enabled = false;
            ignoraVerificaPendientes = true;
            DialogResult result1 = DialogResult.Yes;
            
            if(preguntar)
            result1 = MessageBox.Show("¿Deseas Subir estos Archivos?",
               "Subir Archivos",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);


            if (result1 == DialogResult.Yes)
            {
                limpiaPendientes();
                String filename = "";
                String rutaAceptados = "";
                int cont = 0;
                int mal = 0;
                try
                {
                    /* Instancia FTP */
                    FTP ftp = new FTP(@getFtpServidor(), getFtpUsuario(), getFtpPass());
                    
                    //sube los archivos por FTP
                    foreach (string File in FileList)
                    {
                        filename = System.IO.Path.GetFileName(File);

                        ArrayList alDatos = procesarNombreArchivo(filename);

                        if (alDatos == null || alDatos[AL_ACRONIMO] == null || alDatos[AL_FECHA_FIN] == null || alDatos[AL_EXT] == null)
                        {
                            MessageBox.Show("Formato Incorrecto: '" + filename + "'" + (alDatos == null ? "" : ("\n   ACRONIMO='" + alDatos[AL_ACRONIMO] + "'\n   FECHA INICIO='" + alDatos[AL_FECHA_INI] + "'\n   FECHA FIN='" + alDatos[AL_FECHA_FIN] + "'\n   EXTENSION='" + alDatos[AL_EXT])) + "' \n(ej. ACRO_AAAAMMDD_AAAAMMDD.ext o ACRO_AAAAMMDD.ext)", "ITU - Error al Subir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tblPendientes.Rows.Add(new object[] { System.IO.Path.GetDirectoryName(File), filename, "FORMATO INCORRECTO" });
                            mal++;
                        }
                        else { 

                            /* Subir Archivo */
                            AppendConsola("\nSubiendo (" + (cont + 1) + "/" + FileList.Length + ") ->" + filename + "");
                            ftp.upload("PENDIENTES/" + filename, @File);
                            AppendConsola("...Subido");

                            AppendConsola("...Registrando... ");                        
                            guardarArchivosBD(File, filename, alDatos);
                            AppendConsola("Registrado");

                            AppendConsola("...Moviendo... ");
                            rutaAceptados = getRutaReportesAceptados();
                            moverArchivo(filename, File, rutaAceptados);
                            AppendConsola("Movido");


                            tblAceptados.Rows.Add(new object[] { rutaAceptados, filename, alDatos[AL_FECHA_INI], alDatos[AL_FECHA_FIN], alDatos[AL_ACRONIMO], "ACEPTADO" });
                        }
                        

                        cont++;
                    }
                    /* Release Resources */
                    ftp = null;
                    AppendConsola("\n\n( " + (cont - mal) + " ) Archivo(s) Subido(s)... \n");
                    if (mal > 0)
                    {
                        AppendConsola("( " + (mal) + " ) Archivo(s) Cancelados(s)... \n");
                    }
                    this.tabPage2.Text = "(" + (mal) + ") Pendientes";
                    this.tabAceptados.Text = "(" + (cont - mal) + ") Aceptados";

                    //if(cont != FileList.Length){
                    //    muestraNotificacionIconoTexto("Error al Subir", "Faltaron " + (cont - FileList.Length) + " Archivo(s) de subi(s)", 1000);
                    //    MessageBox.Show( "Faltaron "+(cont-FileList.Length)+" Archivo(s) de subir", "Error al Subir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //else
                    //{
                    muestraNotificacionIconoTexto("Archivos", "Se subieron (" + ((cont - mal)) + "/" + cont + ") Archivo(s)", 300);
                    //}

                }
                catch (System.Data.Entity.Core.EntityCommandExecutionException ex) {
                    MessageBox.Show("No fue posible generar el Registro '" + filename + "' en la Base de Datos, Favor de contactar asistencia. \n\n" + ex.ToString().Substring(0, (ex.ToString().Length >= 500 ? 500 : ex.ToString().Length)) + "...", ex.Source + " - Error al Subir los Archivos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AppendConsola("\n\n( " + FileList.Length + " ) Archivos Cancelados... \n");
                    muestraNotificacionIconoTexto("Archivos", "Se subieron (" + ((cont - mal)) + "/" + cont + ") Archivo(s)", 300);
                }
                catch (System.Data.Entity.Core.EntityException ex)
                {
                    MessageBox.Show("No se pudo Conectar a la Base de Datos, Favor de Verificar. \n\n" + ex.ToString().Substring(0, (ex.ToString().Length >= 500 ? 500 : ex.ToString().Length)) + "...", ex.Source + " - Error al Subir los Archivos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AppendConsola("\n\n( " + FileList.Length + " ) Archivos Cancelados... \n");
                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show("No se pudo Conectar al Servidor de FTP, Favor de Verificar. \n\n" + ex.ToString().Substring(0, (ex.ToString().Length >= 500 ? 500 : ex.ToString().Length)) + "...", ex.Source + " - Error al Subir los Archivos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AppendConsola("\n\n( " + FileList.Length + " ) Archivos Cancelados... \n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Source+ " - Error al Subir los Archivos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AppendConsola("\n\n( " + FileList.Length + " ) Archivos Cancelados... \n");
                }
            }
            else
            {
                AppendConsola("\n( " + FileList.Length + " ) Archivos Cancelados... \n");
            }
            ignoraVerificaPendientes = false;
            btnPausar.Enabled = true;
        }
        #endregion

        #region Append Consola
        public void AppendConsola(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendConsola), new object[] { value });
                return;
            }
            txtConsola.Text += value;
            txtConsola.SelectionStart = txtConsola.Text.Length;
            txtConsola.ScrollToCaret();
        }
        #endregion

        #region Hilo Verifica Pendientes
        // This method that will be called when the thread is started
        public void HiloVerificaPendientes()
        {
            Thread.Sleep(3000);
            while (true)
            {
                if (!ignoraVerificaPendientes)
                {
                    verificaPendientes();
                }

                /* Dormir N segundos */
                Thread.Sleep(this.tiempoRefrescar * 1000);
            }
        }
        #endregion

        #region Verifica si existen archivos pendientes
        private void verificaPendientes()
        {
            string[] dirFiles = null;
            try
            {
                dirFiles = System.IO.Directory.GetFiles(getRutaReportesPendientes(), "*.*",
                                System.IO.SearchOption.AllDirectories);


                AppendConsola("\nSe encontraron (" + dirFiles.Length + ") Archivos Pendientes.\n");

                if (dirFiles.Length > 0)
                    procesarArchivos(dirFiles, false);

            }
            catch(Exception ex) {
                MessageBox.Show("Ocurrio un error al recuperar la Ruta de los Reportes, favor de verificar que exista la ruta:\n'" + getRutaReportesPendientes() + "'", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.tabPage2.Text = "(" + dirFiles.Length + ") Pendientes";

            for (int fila = 0; fila < tblPendientes.Rows.Count; fila++)
            {
                tblPendientes.Rows.RemoveAt(fila);
            }
            for (int fila = 0; fila < dirFiles.Length; fila++)
            {
                tblPendientes.Rows.Add(new object[] { System.IO.Path.GetDirectoryName(dirFiles[fila]), System.IO.Path.GetFileName(dirFiles[fila]) , "PENDIENTE"});                
            }

        }
        #endregion

        #region Getters y Setters

        private int getTiempoRefrescar()
        {
            try
            {
                var tiempo = (string)ConfigurationManager.AppSettings["tiempoRefrescar"];
                this.tiempoRefrescar = Convert.ToInt32(tiempo);
            }
            catch (System.FormatException ex) {
                MessageBox.Show("Ocurrio un error al recuperar el tiempo de refrescar pendientes, se regresara al tiempo Original: \n" + "60 seg.", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.tiempoRefrescar = 60; 
            }
            return tiempoRefrescar;
        }

        private string getRutaReportesPendientes()
        {
            try
            {
                var ruta = (string)ConfigurationManager.AppSettings["rutaReportesPendientes"];
                if (!String.IsNullOrEmpty(ruta) && ruta.Substring(ruta.Length - 1, 1) != "\\")
                {
                    ruta += "\\";
                }
                this.rutaReportes = ruta;
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ocurrio un error al recuperar la Ruta de los Reportes Pendientes, se regresara a la Ruta Original: \n" + "C:\\Reportes Pendientes\\", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.rutaReportes = "C:\\Reportes Pendientes\\";
            }
            return rutaReportes;
        }

        private string getRutaReportesAceptados()
        {
            try
            {
                var ruta = (string)ConfigurationManager.AppSettings["rutaReportesAceptados"];
                if (!String.IsNullOrEmpty(ruta) && ruta.Substring(ruta.Length - 1, 1) != "\\")
                {
                    ruta += "\\";
                }
                this.rutaReportes = ruta;
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ocurrio un error al recuperar la Ruta de los Reportes Aceptados, se regresara a la Ruta Original: \n" + "C:\\Reportes Aceptados\\", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.rutaReportes = "C:\\Reportes Aceptados\\";
            }
            return rutaReportes;
        }

        private string getFtpServidor()
        {
            var valor = "";
            try
            {
                valor = (string)ConfigurationManager.AppSettings["ftpServidor"];

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ocurrio un error al recuperar el Servidor de FTP, Favor de Verificar", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return valor;
        }

        private string getFtpUsuario()
        {
            var valor = "";
            try
            {
                valor = (string)ConfigurationManager.AppSettings["ftpUsuario"];

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ocurrio un error al recuperar el Usuario de FTP, Favor de Verificar", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return valor;
        }

        private string getFtpPass()
        {
            var valor = "";
            try
            {
                valor = (string)ConfigurationManager.AppSettings["ftpPass"];

            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ocurrio un error al recuperar el Pass de FTP, Favor de Verificar", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return valor;
        }

        #endregion

        #region Mover Archivo
        public static void moverArchivo(string nombreArchivo, string archivoOrigen, string rutaDestino)
        {
            string path = @archivoOrigen ;
            string path2 = @rutaDestino+nombreArchivo;
            try
            {
                if (!File.Exists(path))
                {
                    // This statement ensures that the file is created, 
                    // but the handle is not kept. 
                    using (FileStream fs = File.Create(path)) { }
                }

                // Ensure that the target does not exist. 
                if (File.Exists(path2))
                    File.Delete(path2);

                // Move the file.
                File.Move(path, path2);
                Console.WriteLine("{0} was moved to {1}.", path, path2);

                // See if the original exists now. 
                if (File.Exists(path))
                {
                    Console.WriteLine("The original file still exists, which is unexpected.");
                }
                else if (File.Exists(path2) && File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("The original file no longer exists, which is expected.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        #endregion

        #region Icono Mostrar Notificaciones
        private void MostrarNotificacionIcono()
        {
            this.iconoNotificacion.Visible = true;
            this.iconoNotificacion.ShowBalloonTip(1000);
        }
        #endregion

        #region Icono Mostrar Notificaciones Texto
        private void muestraNotificacionIconoTexto(String titulo, String mensaje, int tiempo)
        {
            this.iconoNotificacion.BalloonTipText = mensaje;
            this.iconoNotificacion.BalloonTipTitle = titulo;
            this.iconoNotificacion.Visible = true;
            this.iconoNotificacion.ShowBalloonTip(tiempo);
        }
        #endregion

        #region Verifica si es un numero una Expresion
        public static System.Boolean IsNumeric (System.Object Expression)
        {
            if(Expression == null || Expression is DateTime)
                return false;

            if(Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try 
            {
                if(Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                    return true;
                } catch {} // just dismiss errors but return false
                return false;
         }
        #endregion

        #region Procesar Nombre Archivo
        private ArrayList procesarNombreArchivo(string nombreArchivo)
        {
            #region Variables
            ArrayList alArchivos = new ArrayList();
            string ext = null;
            string acro = null;
            string nombre = null;
            DateTime? fechaIni = null;
            DateTime? fechaFin = null;
            string cadena = null;
            #endregion

            #region Inicializa Array
            alArchivos.Add(acro);
            alArchivos.Add(nombre);
            alArchivos.Add(fechaIni);
            alArchivos.Add(fechaFin);
            alArchivos.Add(ext);
            #endregion

            #region Separar Extension del Nombre
            if (nombreArchivo.Contains('.'))
            {
                string[] alCadenaExtension = nombreArchivo.Split('.');
                cadena = alCadenaExtension[0];
                ext = alCadenaExtension[1];
                alArchivos[AL_EXT] = ext;

            }
            else
            {
                cadena = nombreArchivo;
            }
            #endregion

            #region Separa Cadenas
            if (cadena.Contains('_'))
            {
                string[] alCadena = cadena.Split('_');
                acro = alCadena[0];
                alArchivos[AL_ACRONIMO] = acro;

                if (alCadena.Length >= 2)
                {
                    try
                    {
                        if (alCadena[alCadena.Length - 1].Length == 8 && IsNumeric(alCadena[alCadena.Length - 1]))
                        {
                            string fecha = alCadena[alCadena.Length - 1];
                            int a = Convert.ToInt32(Char.ToString(fecha[0]) + Char.ToString(fecha[1]) + Char.ToString(fecha[2]) + Char.ToString(fecha[3]));
                            int m = Convert.ToInt32(Char.ToString(fecha[4]) + Char.ToString(fecha[5]));
                            int d = Convert.ToInt32(Char.ToString(fecha[6]) + Char.ToString(fecha[7]));
                            
                            fechaFin = new DateTime(a,m,d);
                            alArchivos[AL_FECHA_FIN] = fechaFin;
                        }
                    }catch(Exception ex){}
                }
                if (alCadena.Length >= 3)
                {
                    try
                    {
                        if (alCadena[alCadena.Length - 2].Length == 8 && IsNumeric(alCadena[alCadena.Length - 2]))
                        {
                            string fecha = alCadena[alCadena.Length - 2];
                            string x = Char.ToString(fecha[0]);
                            int a = Convert.ToInt32(Char.ToString(fecha[0]) + Char.ToString(fecha[1]) + Char.ToString(fecha[2]) + Char.ToString(fecha[3]));
                            int m = Convert.ToInt32(Char.ToString(fecha[4]) + Char.ToString(fecha[5]));
                            int d = Convert.ToInt32(Char.ToString(fecha[6]) + Char.ToString(fecha[7]));

                            fechaIni = new DateTime(a, m, d);
                            alArchivos[AL_FECHA_INI] = fechaIni;
                        }
                    }catch(Exception ex){}
                }

            }
            else
            {
                /*No tiene Acronimo ni Fechas*/
                return null;
            }
            #endregion

            return alArchivos;
        }
        #endregion

        #region Limpia Tabla Pendientes
        private void limpiaPendientes()
        {
            for (int fila = 0; fila < tblPendientes.Rows.Count; fila++)
            {
                tblPendientes.Rows.RemoveAt(fila);
            }
        }
        #endregion

        #region Limpia Tabla Aceptados
        private void limpiaAceptados()
        {
            for (int fila = 0; fila < tblAceptados.Rows.Count; fila++)
            {
                tblAceptados.Rows.RemoveAt(fila);
            }
        }
        #endregion

        #region Boton Pausar Verificar Pendientes
        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (!ignoraVerificaPendientes)
            {
                btnPausar.Text = "►";
                ignoraVerificaPendientes = true;
            }
            else
            {
                btnPausar.Text = "ll";
                ignoraVerificaPendientes = false;
            }
        }
        #endregion

    }




}
