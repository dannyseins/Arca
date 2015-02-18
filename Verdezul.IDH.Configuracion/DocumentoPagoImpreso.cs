using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Configuracion
{
    public class DocumentoPagoImpreso
    {
        #region Campos
        private PagoDataSet DatosPago;
        private AlumnoDataSet.AlumnoRow DatosAlumno;
        private EmpresaInformacion DatosEmpresa;
        private int ancho = 48;
        #endregion

        #region Constructor
        public DocumentoPagoImpreso(PagoDataSet datosPago, AlumnoDataSet.AlumnoRow alumno, EmpresaInformacion datosEmpresa)
        {
            DatosPago = datosPago;
            DatosAlumno = alumno;
            DatosEmpresa = datosEmpresa;
        }
        #endregion

        #region Impresion
        public void Factura_PrintPage(object sender, PrintPageEventArgs e)
        {
            RecaudacionesConfiguracion ConfCaja = ConfigurationManager.GetSection("IDH.Recaudaciones") as RecaudacionesConfiguracion;
            Font fontImpresion = new Font(ConfCaja.Facturas.TipoLetra.FuenteTexto, ConfCaja.Facturas.TipoLetra.Tamano);
            PointF puntoInicio = new PointF(ConfCaja.Facturas.Posicion.TextoX, ConfCaja.Facturas.Posicion.TextoY);

            int charactersOnPage = 0;
            int linesPerPage = 0;

            //e.Graphics.MeasureString(textoFactura, fontImpresion,
            //    e.MarginBounds.Size, StringFormat.GenericTypographic,
            //    out charactersOnPage, out linesPerPage);

            string textoFactura = CrearTexto();
            e.Graphics.DrawString(textoFactura, fontImpresion,
                Brushes.Black, puntoInicio, StringFormat.GenericTypographic);
        }
        #endregion

        #region Métodos
        private string CrearTexto()
        {
            string textoFactura = "";
            // Descripcion 30
            // Cantidad     3
            // Precio       6
            // Total        6
            // Espacios     3
            // --------------
            // TOTAL       48

            StringBuilder sb = new StringBuilder();
            // Datos de la Empresa.
            sb.Append(string.Format("{0}\n", CentrarTexto(DatosEmpresa.Nombre, ancho)));
            sb.Append(string.Format("{0}\n", CentrarTexto(DatosEmpresa.RUC, ancho)));
            sb.Append(string.Format("{0}\n", CentrarTexto(DatosEmpresa.Direccion, ancho)));
            sb.Append(string.Format("{0}\n", CentrarTexto(DatosEmpresa.Telefono, ancho)));

            // Datos del Cliente.
            sb.Append(string.Format("Factura: {0}\n", DatosPago.Pago[0].NumeroDocumento));
            sb.Append(string.Format("Cliente: {0} {1}\n", DatosAlumno.Nombre, DatosAlumno.Apellido));
            sb.Append(string.Format("RUC: {0}\n", DatosAlumno.NumeroIdentificacion));
            sb.Append(string.Format("Dirección: {0}\n", DatosAlumno.Direccion));
            sb.Append(string.Format("Teléfono: {0}\n", DatosAlumno.TelefonoDomicilio));
            sb.Append(string.Format("Fecha: {0}\n", DatosPago.Pago[0].Fecha));
            sb.AppendLine();

            // Detalle de Factura
            sb.Append("Descripción                    Can Precio Total \n");
            sb.Append(string.Format("{0}\n", RepetirCaracter('-', ancho)));
            Decimal total = 0;
            foreach (PagoDataSet.DetallePagoRow dpr in DatosPago.DetallePago.Rows)
            {
                sb.Append(string.Format("{0} {1} {2} {3}\n",
                    DevolverStringFormateado(dpr.Descripcion, 30, true),
                    DevolverStringFormateado(dpr.Cantidad, 3, false),
                    DevolverStringFormateado(dpr.Valor, 6, false),
                    DevolverStringFormateado(dpr.PVP, 6, false)));
                total += dpr.Valor;
            }
            sb.Append(string.Format("{0}\n", RepetirCaracter('-', ancho)));
            sb.Append(string.Format("Total{0}{1}", RepetirCaracter(' ', 37), DevolverStringFormateado(total, 6, false)));
            textoFactura = sb.ToString();
            return textoFactura;
        }

        /// <summary>
        /// Pone un texto del formato de tamaño parejo.
        /// </summary>
        /// <param name="texto">Texto a formatear.</param>
        /// <param name="tamano">Tamaño del texto a devolver</param>
        /// <param name="posicion">Indica si se agrega espacios a la derecha (true) o izquierda (false).</param>
        /// <returns>Texto de tamaño formateado</returns>
        private string DevolverStringFormateado(object texto, int tamano, bool posicion)
        {
            if (texto.ToString().Length <= tamano)
            {
                if (posicion)
                    return texto.ToString().PadRight(tamano, ' ');
                else
                    return texto.ToString().PadLeft(tamano, ' ');
            }
            else
            {
                return texto.ToString().Substring(1, tamano);
            }
        }

        private string CentrarTexto(string texto, int tamano)
        {
            return texto.PadLeft(texto.Length + ((tamano - texto.Length) / 2), ' ');
        }

        private string RepetirCaracter(char car, int cantidad)
        {
            string cadena = "";
            for (int i = 1; i <= cantidad; i++)
                cadena += car;
            return cadena;

        }
        #endregion

        #region Métodos Estáticos
        public static string NumeroFacturaImpresion(string prefijo, int numero, int longitud)
        {
            return String.Format("{0}{1}", prefijo, numero.ToString().PadLeft(longitud, '0'));
        }
        #endregion
    }
}
