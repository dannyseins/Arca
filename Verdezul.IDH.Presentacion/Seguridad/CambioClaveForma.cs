using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Business;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Presentacion.Seguridad
{
    public partial class CambioClaveForma : FormaBase
    {
        #region Campos
        private UsuarioManager UsuarioServicio;
        private UsuarioDataSet.UsuarioRow Usuario;
        #endregion

        #region Botones
        private ToolStripButton GrabarBoton;
        #endregion

        #region Constructores e Inicialización
        public CambioClaveForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public CambioClaveForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, Grabar_Click);
            UsuarioServicio = new UsuarioManager();
        }
        #endregion

        #region Eventos
        private void CambioClaveForma_Load(object sender, EventArgs e)
        {
            Usuario = UsuarioServicio.SeleccionarxId(IdUsuario)[0];
            UsuarioTextBox.Text = Usuario.NickName;
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            string clave = ClaveTextBox.Text;
            string nuevaClave = NuevaClaveTextBox.Text;
            string confirmarNuevaClave = ConfirmarNuevaClaveTextBox.Text;

            string mensaje = "";
            MarcaError.Clear();
            if ((nuevaClave == confirmarNuevaClave) && (nuevaClave != ""))
            {
                if (Encriptacion.MD5(clave) == Usuario.Clave)
                    try
                    {
                        UsuarioServicio.CambiarClave(Usuario.Id, Encriptacion.MD5(nuevaClave));
                        MostrarMensaje("La clave ha sido cambiada.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("La clave no pudo ser cambiada.", ex);
                    }
                else
                {
                    mensaje = "La clave actual no es correcta.";
                    MarcaError.SetError(ClaveTextBox, mensaje);
                    MostrarMensaje(mensaje);
                }
            }
            else
            {
                mensaje = "La nueva clave y su confirmación no son iguales o están vacías.";
                MarcaError.SetError(NuevaClaveTextBox, mensaje);
                MarcaError.SetError(ConfirmarNuevaClaveTextBox, mensaje);
                MostrarMensaje(mensaje);
            }
        }
        #endregion

        #region Métodos
        private bool ValidarCampos()
        {
            bool datosCorrectos = true;
            MarcaError.Clear();

            if (!ValidarTextBox(ClaveTextBox)) datosCorrectos = false;
            if (!ValidarTextBox(NuevaClaveTextBox)) datosCorrectos = false;
            if (!ValidarTextBox(ConfirmarNuevaClaveTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion

    }
}