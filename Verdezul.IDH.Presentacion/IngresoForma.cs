using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using Verdezul.Utilidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Presentacion.Seguridad;
using Verdezul.IDH.Configuracion.Enumerados;
using Verdezul.IDH.Configuracion;
using Verdezul.IDH.Presentacion;

namespace Verdezul.IDH.Presentacion
{
    public partial class IngresoForma : Form
    {
        #region Campos
        private Principal FormaPrincipal;
        private UsuarioManager objUsuario;
        private Int32 NumeroIntentos;
        #endregion

        #region Constructor
        public IngresoForma()
        {
            InitializeComponent();
            FormaPrincipal = new Principal();
            FormaPrincipal.Disposed += new EventHandler(FormaPrincipal_Disposed);
            objUsuario = new UsuarioManager();
            NumeroIntentos = 0;
        }
        #endregion

        #region Ingreso
        private void Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = objUsuario.Autenticar(Usuario.Text, Encriptacion.MD5(Clave.Text));
                if (idUsuario != 0)
                {
                    this.Visible = false;
                    FormaPrincipal.IdUsuario = idUsuario;
                    FormaPrincipal.TipoRolAutenticado = (TipoRol)objUsuario.PedirTipoRolxUsuario(idUsuario);
                    FormaPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Clave incorrectos", "Error");
                    NumeroIntentos++;
                }
                if (NumeroIntentos == 3)
                {
                    RegistroEvento.Escribir(string.Format("Se ha intentado ingresar a la aplicaci�n digitando m�s de tres veces la clave en {0}", DateTime.Now), EventLogEntryType.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("No se puede conectar a la Base de Datos.\n\n �Se est� us�ndola en alg�n otro lado ? \n\nConsulte con el Administrador", "Error");
                RegistroEvento.Escribir(string.Format("Se ha intentado ingresar a la aplicaci�n pero no hubo respuesta de la Base de Datos en {0}", DateTime.Now), EventLogEntryType.Warning);
                Application.Exit();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Eventos
        private void IngresoForma_Load(object sender, EventArgs e)
        {
            RecaudacionesConfiguracion ConfCaja = ConfigurationManager.GetSection("IDH.Recaudaciones") as RecaudacionesConfiguracion;
            if (!ConfCaja.Start)
            {
                if (MessageBox.Show("La aplicaci�n va a iniciarse por primera vez." +
                    "\n\nA continuaci�n se ingresar� a una ventana de Configuraci�n del Sistema." +
                    "\nLuego de esta ventana deber� ingresar sus credenciales de inicio de sesi�n." +
                    "\nPulse 'OK' para continuar", "IDH - Recaudaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    ConfiguracionForma conf = new ConfiguracionForma();
                    conf.ShowDialog();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void FormaPrincipal_Disposed(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}