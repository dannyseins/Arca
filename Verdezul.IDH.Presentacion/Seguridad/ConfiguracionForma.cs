using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Verdezul.Utilidades.Formas;
using Verdezul.Utilidades.Configuracion;
using Verdezul.IDH.Configuracion;
using Verdezul.IDH.Business;

using System.IO;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Presentacion.Seguridad
{
    public partial class ConfiguracionForma : FormaBase
    {
        #region Campos
        private Configuration ConfiguracionLocal;
        private VerdezulConfiguration ConfiguracionVerdezul;
        private RecaudacionesConfiguracion ConfiguracionRecaudaciones;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton ImpresionPruebaBoton;
        #endregion

        #region Constructores e Inicialización
        public ConfiguracionForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, GrabarBoton_Click);
            ImpresionPruebaBoton = AgregarBotonAccion("Impresion", "Impresión de Prueba", Imagenes.Imprimir, ImpresionBoton_Click);
            ImpresionPruebaBoton.Enabled = false;
        }
        #endregion

        #region Eventos Generales
        private void ConfiguracionForma_Load(object sender, EventArgs e)
        {
            // Creación de objetos de Configuración
            ConfiguracionLocal = ConfigurationManager.OpenExeConfiguration("IDH.exe");
            ConfiguracionVerdezul = ConfiguracionLocal.Sections["Verdezul"] as VerdezulConfiguration;
            ConfiguracionRecaudaciones = ConfiguracionLocal.Sections["IDH.Recaudaciones"] as RecaudacionesConfiguracion;

            // Conexiones
            List<string> listaConexiones = new List<string>();
            foreach (ConnectionStringSettings css in ConfigurationManager.ConnectionStrings)
            {
                listaConexiones.Add(css.Name);
            }
            ConexionComboBox.DataSource = listaConexiones;
            ConexionComboBox.SelectedItem = String.Format(ConfiguracionVerdezul.Conexiones.BaseDatos.NombreConexion);
            ReportesTextBox.Text = ConfiguracionVerdezul.Conexiones.Reportes.Carpeta;
            CajaNumericUpDown.Value = ConfiguracionRecaudaciones.CajaLocal;

            // Caja Local
            ImpresoraTextBox.Text = ConfiguracionRecaudaciones.Facturas.Impresora.Nombre;
            BandejaTextBox.Text = ConfiguracionRecaudaciones.Facturas.Impresora.Bandeja;
            MostrarDialogoCheckBox.Checked = ConfiguracionRecaudaciones.Facturas.Impresora.MostrarDialogoImpresion;
            TipoLetraTextBox.Text = ConfiguracionRecaudaciones.Facturas.TipoLetra.FuenteTexto;
            TamanoLetraNumericUpDown.Value = ConfiguracionRecaudaciones.Facturas.TipoLetra.Tamano;
            XNumericUpDown.Value = Convert.ToDecimal(ConfiguracionRecaudaciones.Facturas.Posicion.TextoX);
            YNumericUpDown.Value = Convert.ToDecimal(ConfiguracionRecaudaciones.Facturas.Posicion.TextoY);
        }

        private void GrabarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                //// Conexiones
                ConfiguracionVerdezul.Conexiones.BaseDatos.NombreConexion = ConexionComboBox.Text;
                ConfiguracionVerdezul.Conexiones.Reportes.Carpeta = ReportesTextBox.Text;

                //// Caja Local
                ConfiguracionRecaudaciones.CajaLocal = Convert.ToInt32(CajaNumericUpDown.Value);
                ConfiguracionRecaudaciones.Start = true;
                ConfiguracionRecaudaciones.Facturas.Impresora.Nombre = ImpresoraTextBox.Text;
                ConfiguracionRecaudaciones.Facturas.Impresora.Bandeja = BandejaTextBox.Text;
                ConfiguracionRecaudaciones.Facturas.Impresora.MostrarDialogoImpresion = MostrarDialogoCheckBox.Checked;
                ConfiguracionRecaudaciones.Facturas.TipoLetra.FuenteTexto = TipoLetraTextBox.Text;
                ConfiguracionRecaudaciones.Facturas.TipoLetra.Tamano = Convert.ToInt32(Math.Round(TamanoLetraNumericUpDown.Value, 0));
                ConfiguracionRecaudaciones.Facturas.Posicion.TextoX = float.Parse(XNumericUpDown.Value.ToString());
                ConfiguracionRecaudaciones.Facturas.Posicion.TextoY = float.Parse(YNumericUpDown.Value.ToString());

                //// Grabación local
                ConfiguracionLocal.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("Verdezul");
                ConfigurationManager.RefreshSection("IDH.Recaudaciones");
                MostrarMensaje("La configuración local ha sido grabada\nPara que los cambios tomen efecto debe reiniciar la aplicación.");
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardó la configuración local", ex);
            }
        }

        private void ConfiguracionTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImpresionPruebaBoton.Enabled = (ConfiguracionTabControl.SelectedTab == CajaLocal);
        }

        private void ImpresionBoton_Click(object sender, EventArgs e)
        {
            PagoDataSet pds = new PagoDataSet();
            PagoDataSet.PagoRow prow = pds.Pago.NewPagoRow();
            prow.Fecha = DateTime.Now;
            prow.NumeroDocumento = "502644";
            prow.IdAlumno = 1;
            prow.IdCierreDeCaja = 1;
            prow.Estado = 1;
            prow.FormaPago = 1;
            prow.TipoDocumentoPago = 1;
            prow.IdSecuencia = 2;
            pds.Pago.Rows.Add(prow);

            for (int i = 1; i <= 20; i++)
            {
                PagoDataSet.DetallePagoRow dprow = pds.DetallePago.NewDetallePagoRow();
                dprow.Descripcion = string.Format("Detalle de Prueba {0}", i);
                dprow.Cantidad = 2;
                dprow.Valor = 3;
                dprow.IVA = 4;
                dprow.PVP = 5;
                dprow.Descuento = 8;
                dprow.IdMotivoPago = 1;
                dprow.IdPago = 1;
                dprow.IdRubro = 1;
                dprow.TipoAbono = 1;
                pds.DetallePago.Rows.Add(dprow);
            }

            AlumnoDataSet ads = new AlumnoDataSet();
            AlumnoDataSet.AlumnoRow arow = ads.Alumno.NewAlumnoRow();
            arow.Nombre = "NombrePrueba";
            arow.Apellido = "ApellidoPrueba";
            arow.Direccion = "Direccion Prueba";
            arow.TelefonoDomicilio = "022222222";
            arow.NumeroIdentificacion = "1111111111111";

            EmpresaInformacion de = new EmpresaInformacion("Empresa", "Dirección N12-34 y Cruce", "02 2589 578", "1717171790001");
            DocumentoPagoImpreso facturaPrueba = new DocumentoPagoImpreso(pds, arow, de);

            ImpresionPrevia(prow.NumeroDocumento, facturaPrueba.Factura_PrintPage, 100);
        }
        #endregion

        #region Eventos Conexiones
        private void BaseProbarBoton_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings[ConexionComboBox.SelectedValue.ToString()].ConnectionString);

            SqlCommand sqlcommand = new SqlCommand("SELECT TOP 1 Id FROM Parametro", conexion);
            sqlcommand.CommandType = CommandType.Text;
            try
            {
                conexion.Open();
                sqlcommand.ExecuteScalar();
                MostrarMensaje("Conexión Correcta");
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se pudo conectar a la base de datos, es posible que sea una base de datos incorrecta o esté dañada.", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void ExaminarCarpetaBoton_Click(object sender, EventArgs e)
        {
            CarpetaDialogo.SelectedPath = ReportesTextBox.Text;
            if (CarpetaDialogo.ShowDialog().Equals(DialogResult.OK))
                ReportesTextBox.Text = CarpetaDialogo.SelectedPath;
        }

        private void ReporteProbarBoton_Click(object sender, EventArgs e)
        {
            if (File.Exists(string.Format(@"{0}\{1}", ReportesTextBox.Text, "ReportePrueba.rdlc")))
                MostrarMensaje("La carpeta de reportes es correcta.");
            else
                MostrarMensaje("La carpeta de reportes no es la correcta o no conntiene todos los reportes.");
        }
        #endregion

        #region Eventos Caja Local
        private void ImpresoraButton_Click(object sender, EventArgs e)
        {
            try
            {
                VentanaImpresion.PrinterSettings.PrinterName = ImpresoraTextBox.Text;
                VentanaImpresion.PrinterSettings.DefaultPageSettings.PaperSource.SourceName = BandejaTextBox.Text;
            }
            catch(Exception ex)
            {
                MostrarMensaje("La impresora actual no es correcta.", ex);
            }
            if (VentanaImpresion.ShowDialog() == DialogResult.OK)
            {
                ImpresoraTextBox.Text = VentanaImpresion.PrinterSettings.PrinterName;
                BandejaTextBox.Text = VentanaImpresion.PrinterSettings.DefaultPageSettings.PaperSource.SourceName.Trim();
            }
        }

        private void TipoLetraButton_Click(object sender, EventArgs e)
        {
            VentanaFuentes.Font = new Font(new FontFamily(TipoLetraTextBox.Text), (float)Convert.ChangeType(TamanoLetraNumericUpDown.Value, typeof(float)));
            if (VentanaFuentes.ShowDialog().Equals(DialogResult.OK))
            {
                TipoLetraTextBox.Text = VentanaFuentes.Font.Name;
                TamanoLetraNumericUpDown.Value = Convert.ToDecimal(VentanaFuentes.Font.Size);
            }
        }
        #endregion
    }
}
