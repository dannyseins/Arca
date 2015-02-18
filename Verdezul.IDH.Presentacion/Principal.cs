using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using Verdezul.Utilidades.Formas;
using Verdezul.Utilidades.Configuracion;
using Verdezul.IDH.Configuracion;
using Verdezul.IDH.Configuracion.Enumerados;
using Verdezul.IDH.Presentacion.Reportes;
using Verdezul.IDH.Presentacion.Seguridad;
using Verdezul.IDH.Presentacion.Sistema;
using Verdezul.IDH.Presentacion.Administracion;
using Verdezul.Utilidades;
using System.Transactions;
using System.Threading;
using System.Net.Mail;

namespace Verdezul.IDH.Presentacion
{
    public partial class Principal : FormaContenedora
    {
        #region Constructor
        public Principal()
        {
            InitializeComponent();
        }
        #endregion

        #region Propiedades
        private TipoRol _TipoRolAutenticado;
        public TipoRol TipoRolAutenticado
        {
            get { return _TipoRolAutenticado; }
            set { _TipoRolAutenticado = value; }
        }
        #endregion

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                VerificarAccesoMenu();

                // Registro de Eventos de Ingreso
                RegistroEvento.Escribir(String.Format("Aplicación Iniciada por Usuario {0} en {1}", IdUsuario, DateTime.Now), EventLogEntryType.Information);

                // Pedir configuraciones Verdezul
                VerdezulConfiguration ConfVerdezul = ConfigurationManager.GetSection("Verdezul") as VerdezulConfiguration;

                // Pedir configuraciones Recaudaciones
                RecaudacionesConfiguracion ConfCaja = ConfigurationManager.GetSection("IDH.Recaudaciones") as RecaudacionesConfiguracion;
                string nombreConexion = ConfVerdezul.Conexiones.BaseDatos.NombreConexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Configuración");
            }
        }
        #endregion

        #region Opciones de Menú
        #region Opciones de Menú - Sistema
        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(PagosForma));
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(InscripcionesForma));
        }

        private void cambiarNivelAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AlumnoNivelForma));
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AlumnoForma));
        }

        private void correosElectrónicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(CorreosElectronicosForma));
        }

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(ObservacionesAlumnoForma));
        }
        #endregion

        #region Opciones de Menú - Administración
        private void conferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(ConferenciaForma));
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(CursosForma));
        }

        private void horariosDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(HorarioCursosForma));
        }

        private void horariosDeNivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(HorarioNivelesForma));
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(RubroForma));
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AulasForma));
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(DocentesForma));
        }

        private void secuenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(SecuenciasForma));
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(CajaForma));
        }

        private void areasNivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AreaNivelForma));
        }

        private void estadosDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(EstadoAlumnoForma));
        }
        #endregion

        #region Opciones de Menú - Seguridad
        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta sección configura el sistema.\nSu mal uso puede ocasionar que el sistema no funcione correctamente\nDesea Continuar ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                MostrarForma(typeof(ConfiguracionForma));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(UsuarioForma));
        }

        private void cambioClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(CambioClaveForma));
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(ParametrosForma));
        }

        private void respaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SacarRespaldos();
        }
        #endregion

        #region Opciones de Menú - Reportes - Recaudaciones
        private void cierresDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(CierresDeCajaFormaReporte));
        }

        private void deudasAlumnoEnCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(DeudasCursosFormaReporte));
        }

        private void deudasAlumnoEnNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(DeudasNivelesFormaReporte), FormWindowState.Maximized);
        }

        private void revisionFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(ReimpresionFacturaFormaReporte));
        }

        private void pagosAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(DeudasAlumnoFormaReporte));
        }
        #endregion

        #region Opciones de Menú - Reportes - Académicos
        private void alumnosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AlumnosPorCursoFormaReporte));
        }

        private void alumnosPorNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AlumnosPorNivelFormaReporte));
        }

        private void reporteHorariosDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(HorariosCursosFormaReporte));
        }

        private void reporteHorariosDeNivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(HorariosNivelesFormaReporte));
        }

        private void observacionesDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(ObservacionesAlumnoFormaReporte));
        }
        #endregion

        #region Opciones de Menú - Reportes - Listados Generales
        private void listadoDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(DocentesFormaReporte));
        }

        private void listadoConferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(ConferenciasFormaReporte));
        }

        private void listadoRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(RubrosFormaReporte));
        }

        private void listadoAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AulasFormaReporte));
        }

        private void cumpleanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(CumpleanosFormaReporte));
        }
        #endregion

        private void estadisticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todavía no se encuentran realizadas");
        }

        #region Opciones de Menú - Ventana
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ordenarIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion

        #region Opciones de Menú - Otros
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForma(typeof(AcercaDeForm));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #endregion

        #region Métodos
        private void VerificarAccesoMenu()
        {
            switch (TipoRolAutenticado)
            {
                case TipoRol.Administrador:
                    break;
                case TipoRol.Cajero:
                    break;
            }
        }

        private void SacarRespaldos()
        {
            if (MessageBox.Show(@"Esta opción permite respaldar la información de la base de datos
y enviarla a un correo electrónico para asegurar su almacenamiento.
El programa de compresión le puede pedir su participación pulsando alguna tecla.
Puede tomar algunos minutos, mientras tanto espere hasta mostrar un mensaje de éxito.
Desea Continuar ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
            {
                Process ProcesoZIP = new Process();
                int pasos = 0;
                try
                {
                    VerdezulConfiguration conf = ConfigurationManager.GetSection("Verdezul") as VerdezulConfiguration;
                    Properties.Settings configLocal = new Properties.Settings();
                    DateTime fechaRespaldo = DateTime.Now;

                    string baseDatosComprimida = string.Format(@"{0}{1}\DatosIDH-{2:ddMMyy-HHmm}.zip",
                        Application.StartupPath,
                        conf.Respaldos.ArgumentosZIP.CarpetaRespaldos,
                        fechaRespaldo);

                    string fotosComprimidas = string.Format(@"{0}{1}\FotosIDH-{2:ddMMyy-HHmm}.zip",
                        Application.StartupPath,
                        conf.Respaldos.ArgumentosZIP.CarpetaRespaldos,
                        fechaRespaldo);

                    string argumentosBaseDatos = string.Format(conf.Respaldos.AplicacionZIP.FormatoArgumentos,
                        baseDatosComprimida,
                        string.Format("{0}{1}", Application.StartupPath, conf.Respaldos.ArgumentosZIP.CarpetaDatos));

                    string argumentosFotos = string.Format(conf.Respaldos.AplicacionZIP.FormatoArgumentos,
                        fotosComprimidas,
                        string.Format("{0}{1}", Application.StartupPath, configLocal.CarpetaFotos));

                    using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew, new TimeSpan(0, 0, conf.Respaldos.AplicacionZIP.TiempoEspera * 3000)))
                    {
                        ProcesoZIP = Process.Start(conf.Respaldos.AplicacionZIP.Nombre, argumentosBaseDatos);

                        Thread.Sleep(conf.Respaldos.AplicacionZIP.TiempoEspera * 1000);
                        if (ProcesoZIP.ExitCode == 0)
                        {
                            if (!ProcesoZIP.HasExited)
                                ProcesoZIP.Kill();

                            ProcesoZIP = Process.Start(conf.Respaldos.AplicacionZIP.Nombre, argumentosFotos);
                            Thread.Sleep(conf.Respaldos.AplicacionZIP.TiempoEspera * 1000);
                        }
                        else
                        {
                            throw new Exception(string.Format("{0}\n{1}{2}",
                                "El proceso de compresión no se completó",
                                "La aplicación de compresión devolvió : ", ProcesoZIP.ExitCode));
                        }

                        if (ProcesoZIP.ExitCode == 0)
                        {
                            pasos = 1;
                            MailMessage correo = new MailMessage();
                            correo.To.Add(conf.Respaldos.CorreoZIP.Direccion);
                            correo.Subject = string.Format("Respaldo Base de Datos - {0} {1}", fechaRespaldo.ToLongDateString(), fechaRespaldo.ToShortTimeString());
                            correo.Body = string.Format("<h1>Respaldo Base de Datos<h1><h2>{0} {1}</h2>{2}{3}{4}{5}{6}{7}{8}",
                                fechaRespaldo.ToLongDateString(),
                                fechaRespaldo.ToShortTimeString(),
                                "La información respaldada se encuentra en los archivos '.zip' adjuntos.<br />",
                                "Se ha respaldado la información de Base de Datos y Fotografias.<br />",
                                "Este mail ha sido enviado automáticamente.<br />",
                                "No responda a este correo.<br /><br />",
                                "<a href='http://www.idhecuador.org/'>IDH Ecuador</a><br /><hr />",
                                "Cualquier duda escriba a <a href='mailto:danny.gutierrez@verdezul.org'>Danny Guti&eacute;rrez</a> / ",
                                "<a href='http://www.verdezul.org'>Verdezul</a>");

                            correo.Attachments.Add(new Attachment(baseDatosComprimida));
                            correo.Attachments.Add(new Attachment(fotosComprimidas));
                            correo.IsBodyHtml = true;

                            CorreoElectronico.EnviarMail(correo);
                            pasos = 2;
                            ts.Complete();
                            MostrarMensaje("La base de datos actual ha sido respaldada con éxito,\npor seguridad revise el correo electrónico");
                        }
                        else
                        {
                            throw new Exception(string.Format("{0}\n{1}{2}",
                                "El proceso de compresión no se completó",
                                "La aplicación de compresión devolvió : ", ProcesoZIP.ExitCode));
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!ProcesoZIP.HasExited)
                        ProcesoZIP.Kill();
                    switch (pasos)
                    {
                        case 0:
                            MostrarMensaje("El programa de respaldos no logró comprimir la base de datos", ex);
                            break;
                        case 1:
                            MostrarMensaje("El respaldo se ejecutó pero no se pudo enviar el correo electrónico.", ex);
                            break;
                        case 2:
                            MostrarMensaje("El proceso de respaldo no se completó.", ex);
                            break;
                    }
                }
            }
        }
        #endregion
    }
}