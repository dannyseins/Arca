using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Formas;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace Verdezul.Utilidades.Formas
{
    public partial class FormaBase : Form
    {
        #region Propiedades
        private int _IdUsuario = 0;
        protected int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public ToolStripMenuItem MenuItem
        {
            get { return _MenuItem; }
        }

        protected FormaContenedora FormaContenedora
        {
            get { return this.MdiParent as FormaContenedora; }
        }

        private bool _CerrarFormaAlCargar = false;
        protected bool CerrarFormaAlCargar
        {
            get { return _CerrarFormaAlCargar; }
            set { _CerrarFormaAlCargar = value; }
        }
        #endregion

        #region Constructor
        public FormaBase()
        {
            InitializeComponent();
        }

        public FormaBase(int idUsuario)
        {
            InitializeComponent();
            this.IdUsuario = idUsuario;
        }
        #endregion

        #region Eventos
        private void FormaBase_Activated(object sender, EventArgs e)
        {
            MenuItem.Checked = true;
        }

        private void FormaBase_Deactivate(object sender, EventArgs e)
        {
            MenuItem.Checked = false;
        }

        private void FormaBase_TextChanged(object sender, EventArgs e)
        {
            MenuItem.Text = this.Text;
        }

        private void FormaBase_Shown(object sender, EventArgs e)
        {
            if (CerrarFormaAlCargar) this.Close();
        }

        private void MenuItemForma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }
        #endregion

        #region Eventos Virtuales
        protected virtual void BotonEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Barra de Botones
        /// <summary>
        /// Agrega un Botón Normal a la Barra de Botones.
        /// </summary>
        /// <param name="nombre">Nombre del Botón</param>
        /// <param name="texto">Texto Visible del Botón</param>
        /// <param name="imagen">Imagen del Bótón.</param>
        /// <param name="click">Evento de Click del Botón.</param>
        /// <returns>ToolStripButton</returns>
        protected ToolStripButton AgregarBotonAccion(string nombre, string texto, Bitmap imagen, EventHandler click)
        {
            ToolStripButton BotonAccion = new ToolStripButton();
            BotonAccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BotonAccion.Image = imagen;
            BotonAccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            BotonAccion.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            BotonAccion.Name = nombre;
            BotonAccion.Size = new System.Drawing.Size(23, 22);
            BotonAccion.Text = texto;
            BotonAccion.Click += click;
            this.BarraBotones.Items.Add(BotonAccion);
            return BotonAccion;
        }

        /// <summary>
        /// Agrega una Lista Desplegable la Barra de Botones.
        /// </summary>
        /// <param name="nombre">Nombre del Botón</param>
        /// <param name="texto">Texto Visible del Botón</param>
        /// <param name="imagen">Imagen del Bótón.</param>
        /// <param name="toolStripDropDown">Listado a Desplegar</param>
        /// <param name="DropDownItemClicked">Evento al hacer Click en Elemento de la lista.</param>
        /// <param name="DoubleClick">Evento al hacer Click en el Botón de Lista Desplegable.</param>
        /// <returns>ToolStripDropDownButton</returns>
        protected ToolStripDropDownButton AgregarDropDown(string nombre, string texto, Bitmap imagen, ToolStripDropDown toolStripDropDown,
            ToolStripItemClickedEventHandler DropDownItemClicked, EventHandler DoubleClick)
        {
            ToolStripDropDownButton DropDownButton = new ToolStripDropDownButton();

            DropDownButton.DoubleClickEnabled = true;
            DropDownButton.DropDown = toolStripDropDown;
            DropDownButton.Image = imagen;
            DropDownButton.Name = nombre;
            DropDownButton.Text = texto;
            DropDownButton.DropDownItemClicked += DropDownItemClicked;
            DropDownButton.DoubleClick += DoubleClick;
            this.BarraBotones.Items.Add(DropDownButton);
            return DropDownButton;
        }

        /// <summary>
        /// Agrega una Lista Desplegable la Barra de Botones.
        /// </summary>
        /// <param name="nombre">Nombre del Botón</param>
        /// <param name="texto">Texto Visible del Botón</param>
        /// <param name="imagen">Imagen del Bótón.</param>
        /// <returns>ToolStripDropDownButton</returns>
        protected ToolStripDropDownButton AgregarDropDown(string nombre, string texto, Bitmap imagen)
        {
            ToolStripDropDownButton DropDownButton = new ToolStripDropDownButton();

            DropDownButton.DoubleClickEnabled = true;
            DropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DropDownButton.Image = imagen;
            DropDownButton.Name = nombre;
            DropDownButton.Text = texto;
            this.BarraBotones.Items.Add(DropDownButton);
            return DropDownButton;
        }

        /// <summary>
        /// Agrega una etiqueta a la Barra de Botones.
        /// </summary>
        /// <param name="nombre">Nombre de la Etiqueta</param>
        /// <param name="texto">Texto Visible de la Etiqueta</param>
        /// <param name="imagen">Imagen de la Etiqueta</param>
        /// <returns>ToolStripLabel</returns>
        protected ToolStripLabel AgregarEtiqueta(string nombre, string texto, Bitmap imagen)
        {
            ToolStripLabel Etiqueta = new ToolStripLabel();
            Etiqueta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            Etiqueta.Image = imagen;
            Etiqueta.ImageTransparentColor = System.Drawing.Color.Magenta;
            Etiqueta.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            Etiqueta.Name = nombre;
            Etiqueta.Size = new System.Drawing.Size(23, 22);
            Etiqueta.Text = texto;
            this.BarraBotones.Items.Add(Etiqueta);
            return Etiqueta;
        }
        #endregion 

        #region Métodos Globales
        protected DataTable PedirTipoIdentificaciones()
        {
            DataTable TipoIdentificacionDataTable = new DataTable();
            TipoIdentificacionDataTable.Columns.Add(new DataColumn("Valor", typeof(int)));
            TipoIdentificacionDataTable.Columns.Add(new DataColumn("Texto", typeof(string)));
            foreach (TipoIdentificacion ti in Enum.GetValues(typeof(TipoIdentificacion)))
            {
                DataRow dr = TipoIdentificacionDataTable.NewRow();
                dr["Valor"] = ti;
                dr["Texto"] = ti;
                TipoIdentificacionDataTable.Rows.Add(dr);
            }
            return TipoIdentificacionDataTable;
        }

        protected DataTable PedirFormasPago()
        {
            DataTable FormasPagoDataTable = new DataTable();
            FormasPagoDataTable.Columns.Add(new DataColumn("Valor", typeof(int)));
            FormasPagoDataTable.Columns.Add(new DataColumn("Texto", typeof(string)));
            foreach (FormasPago fp in Enum.GetValues(typeof(FormasPago)))
            {
                DataRow dr = FormasPagoDataTable.NewRow();
                dr["Valor"] = fp;
                dr["Texto"] = fp;
                FormasPagoDataTable.Rows.Add(dr);
            }
            return FormasPagoDataTable;
        }

        protected DialogResult ImpresionPrevia(string tituloImpresion, PrintPageEventHandler eventoImpresionPagina, double porcentaje)
        {
            FormaImpresionPrevia formaImpresionPrevia = new FormaImpresionPrevia(tituloImpresion, eventoImpresionPagina, porcentaje);
            return formaImpresionPrevia.ShowDialog();
        }
        #endregion

        #region Validadores de Campos
        protected bool ValidarTextBox(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MarcaError.SetError(textBox, "Este campo no puede ser vacío.");
                return false;
            }
            else
            {
                if (textBox.Tag != null)
                {
                    try
                    {
                        object valorReal = Convert.ChangeType(textBox.Text, Type.GetType(textBox.Tag.ToString()));
                    }
                    catch
                    {
                        MarcaError.SetError(textBox, "El valor del parámetro es incorrecto.");
                        return false;
                    }
                }
            }
            return true;
        }

        protected bool ValidarNumericUpDown(NumericUpDown numericUpDown)
        {
            if (numericUpDown.Value == 0)
            {
                MarcaError.SetError(numericUpDown, "Este Valor debe ser mayor a 0.");
                return false;
            }
            return true;
        }

        protected bool ValidarComboBox(ComboBox comboBox)
        {
            if ((int)comboBox.SelectedValue == 0)
            {
                MarcaError.SetError(comboBox, "Debe elegir un valor de la lista.");
                return false;
            }
            return true;
        }

        protected bool ValidarMail(string direccionCorreo)
        {
            return Regex.IsMatch(direccionCorreo, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        protected bool ValidarMail(TextBox textBoxMail)
        {
            if (textBoxMail.Text != "")
            {
                if (!ValidarMail(textBoxMail.Text))
                {
                    MarcaError.SetError(textBoxMail, "No es una dirección de correo válida.");
                    return false;
                }
            }
            return true;
        }

        protected bool ValidarTelefonoEcuador(string telefono)
        {
            return Regex.IsMatch(telefono, @"^[0-9]{7,10}$");
        }

        protected bool ValidarTelefonoEcuador(TextBox textBoxTelefono)
        {
            if (textBoxTelefono.Text != "")
            {
                if (!ValidarTelefonoEcuador(textBoxTelefono.Text))
                {
                    MarcaError.SetError(textBoxTelefono, "No es una número de teléfono válido.");
                    return false;
                }
            }
            return true;
        }

        protected bool ValidarCedula(string cedula)
        {
            return Regex.IsMatch(cedula, @"^[0-9]{10}$");
        }

        protected bool ValidarCedula(TextBox textBoxCedula)
        {
            if (textBoxCedula.Text != "")
            {
                if (!ValidarCedula(textBoxCedula.Text))
                {
                    MarcaError.SetError(textBoxCedula, "No es una cédula con formato correcto.");
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Métodos de ClaseNueva
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(this, mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarMensaje(string mensaje, Exception exception)
        {
            MessageBox.Show(this, mensaje + "\nLa Excepción generada dice:\n" + exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public DialogResult Preguntar(string pregunta)
        {
            return MessageBox.Show(this, pregunta, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        #endregion
    }
}