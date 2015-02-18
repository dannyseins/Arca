using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Clases;

namespace Verdezul.Utilidades.Formas
{
    public partial class FormaContenedora : Form
    {
        #region Costructor
        public FormaContenedora()
        {
            InitializeComponent();
        }
        #endregion

        #region Campos
        private ToolStripSeparator Separador = new ToolStripSeparator();
        private int NumeroItemsInicialesVentana = 0;
        #endregion

        #region Propiedades
        private int _IdUsuario;
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private string _NickNameUsuario;
        public string NickNameUsuario
        {
            get { return _NickNameUsuario; }
            set { _NickNameUsuario = value; }
        }

        private string _NombreCompletoUsuario;
        public string NombreCompletoUsuario
        {
            get { return _NombreCompletoUsuario; }
            set { _NombreCompletoUsuario = value; }
        }

        private ToolStripMenuItem _VentanasMenuItem;
        public ToolStripMenuItem VentanasMenuItem
        {
            get { return _VentanasMenuItem; }
            set
            {
                _VentanasMenuItem = value;
                NumeroItemsInicialesVentana = _VentanasMenuItem.DropDownItems.Count;
            }
        }
        #endregion

        #region Métodos Globales
        protected void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(this, mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void MostrarMensaje(string mensaje, Exception exception)
        {
            MessageBox.Show(this, mensaje + "\nLa Excepción generada dice:\n" + exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        #endregion

        #region Métodos Forma
        protected void MostrarForma(Type tipoForma)
        {
            MostrarForma(tipoForma, 1, FormWindowState.Normal);
        }

        protected void MostrarForma(Type tipoForma, FormWindowState estadoForma)
        {
            MostrarForma(tipoForma, 1, estadoForma);
        }

        public void MostrarForma(Type tipoForma, params object[] args)
        {
            MostrarForma(tipoForma, 1, FormWindowState.Normal, args);
        }

        public void MostrarForma(Type tipoForma, FormWindowState estadoForma, params object[] args)
        {
            MostrarForma(tipoForma, 1, estadoForma, args);
        }

        protected void MostrarForma(Type tipoForma, int numeroInstancias, FormWindowState estadoForma, params object[] args)
        {
            bool formaEncontrada = false;
            int instanciasEncontradas = 0;
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.GetType() == tipoForma)
                {
                    instanciasEncontradas++;
                    if (instanciasEncontradas == numeroInstancias)
                    {
                        formaEncontrada = true;
                        childForm.Focus();
                        break;
                    }
                }
            }

            if (!formaEncontrada)
            {
                try
                {
                    if (args == null) args = new object[] { IdUsuario };

                    FormaBase forma = (FormaBase)Activator.CreateInstance(tipoForma, args);

                    forma.MdiParent = this;
                    forma.StartPosition = FormStartPosition.CenterScreen;
                    forma.WindowState = estadoForma;
                    forma.Disposed += new EventHandler(forma_Disposed);
                    if (instanciasEncontradas > 0)
                        forma.Text = string.Format("{0} ({1})", forma.Text, instanciasEncontradas + 1);
                    forma.Show();

                    if (VentanasMenuItem != null)
                    {
                        if (!VentanasMenuItem.DropDownItems.Contains(Separador))
                            VentanasMenuItem.DropDownItems.Add(Separador);

                        VentanasMenuItem.DropDownItems.Add(forma.MenuItem);
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensaje("No se pudo abrir la ventana", ex);
                }
            }
        }

        internal void MostrarReporte(ElementosReporte elementos)
        {
            bool formaEncontrada = false;
            int instanciasEncontradas = 0;
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.GetType() == typeof(VisorReportes))
                {
                    VisorReportes reporteForma = (VisorReportes)childForm;
                    if (reporteForma.Elementos.Titulo == elementos.Titulo)
                    {
                        formaEncontrada = true;
                        reporteForma.Elementos = elementos;
                        reporteForma.Refrescar = true;
                        reporteForma.Focus();
                        break;
                    }
                }
            }

            if (!formaEncontrada)
            {
                try
                {
                    FormaBase forma = (FormaBase)Activator.CreateInstance(typeof(VisorReportes), elementos);

                    forma.MdiParent = this;
                    forma.StartPosition = FormStartPosition.CenterScreen;
                    forma.Disposed += new EventHandler(forma_Disposed);
                    forma.Show();

                    if (VentanasMenuItem != null)
                    {
                        if (!VentanasMenuItem.DropDownItems.Contains(Separador))
                            VentanasMenuItem.DropDownItems.Add(Separador);

                        VentanasMenuItem.DropDownItems.Add(forma.MenuItem);
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensaje("No se pudo abrir la ventana", ex);
                }
            }
        }

        private void forma_Disposed(object sender, EventArgs e)
        {
            if (VentanasMenuItem != null)
            {
                VentanasMenuItem.DropDownItems.Remove(((FormaBase)sender).MenuItem);

                if (VentanasMenuItem.DropDownItems.Count == NumeroItemsInicialesVentana + 1)
                    VentanasMenuItem.DropDownItems.Remove(Separador);
            }
        }
        #endregion
    }
}