using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Configuracion.Enumerados;

namespace Verdezul.IDH.Presentacion.Seguridad
{
    public partial class UsuarioForma : FormaBase
    {
        #region Campos
        private UsuarioManager objUsuario;
        private UsuarioDataSet.UsuarioDataTable UsuariosDataTable;
        private int _IdUsuarioEdicion = 0;
        private string _Clave = "";
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        ToolStripButton ResetearClaveBoton;
        #endregion

        #region Constructores e Inicialización
        public UsuarioForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.GrabarBoton.Visible = true;
        }

        public UsuarioForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.GrabarBoton.Visible = true;
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, GrabarBoton_Click);
            BorrarBoton = AgregarBotonAccion("Borrar", "Borrar", Imagenes.Borrar, BorrarBoton_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);
            ResetearClaveBoton = AgregarBotonAccion("ResetearClave", "Resetear Clave", Imagenes.ResetearClave, ResetearClaveBoton_Click);
            objUsuario = new UsuarioManager();
            UsuariosDataTable = new UsuarioDataSet.UsuarioDataTable();
            RolRubroBox.DataSource = PedirTipoRoles();
        }
        #endregion

        #region Eventos
        private void UsuarioForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                UsuariosDataGridView.Columns["NickName"].HeaderText = "Nick";
                UsuariosDataGridView.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
                UsuariosDataGridView.Columns["NombreCompleto"].HeaderText = "Usuario";
                UsuariosDataGridView.Columns["NombreCompleto"].Width = 200;
                UsuariosDataGridView.Columns["Telefono"].HeaderText = "Teléfono";
                UsuariosDataGridView.Columns["Telefono"].Width = 70;
                UsuariosDataGridView.Columns["Direccion"].HeaderText = "Direccion";
                UsuariosDataGridView.Columns["Direccion"].Width = 200;
                UsuariosDataGridView.Columns["CI"].HeaderText = "CI";
                UsuariosDataGridView.Columns["CI"].Width = 100;
                UsuariosDataGridView.Columns["Email"].Width = 70;

                UsuariosDataGridView.Columns["Id"].Visible = false;
                UsuariosDataGridView.Columns["Clave"].Visible = false;
                UsuariosDataGridView.Columns["Activo"].Visible = false;
                UsuariosDataGridView.Columns["TipoRol"].Visible = false;
            }
            else
                CerrarFormaAlCargar = true;
        }

        private void GrabarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GrabarDatos();
                    //MostrarMensaje("Grabación Correcta");
                    LimpiarCampos();
                    TraerDatos();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void BorrarBoton_Click(object sender, EventArgs e)
        {
            if (_IdUsuarioEdicion != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objUsuario.Borrar(_IdUsuarioEdicion);
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo borrar", ex);
                    }
                    LimpiarCampos();
                    TraerDatos();
                }
            }
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ResetearClaveBoton_Click(object sender, EventArgs e)
        {
            if (_IdUsuarioEdicion != 0)
            {
                if (Preguntar("Está seguro que desea resetear la clave del usuario " + NickNameTextBox.Text + " ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        string nuevaClave = Encriptacion.MD5(NickNameTextBox.Text);
                        objUsuario.CambiarClave(_IdUsuarioEdicion, nuevaClave);
                        _Clave = nuevaClave;
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo resetear la clave", ex);
                    }
                }
            }
        }
        
        private void UsuariosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                UsuarioDataSet.UsuarioRow dr = (UsuariosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as UsuarioDataSet.UsuarioRow;

                _IdUsuarioEdicion = dr.Id;
                _Clave = "";
                NickNameTextBox.Text = dr.NickName;
                NombreCompletoTextBox.Text = dr.NombreCompleto; 
                CITextBox.Text = dr.CI;
                DireccionTextBox.Text = dr.Direccion;
                TelefonoTextBox.Text = dr.Telefono;
                EmailTextBox.Text = dr.Email;
                Activo.Checked = dr.Activo;
                RolRubroBox.SelectedValue = dr.TipoRol;
                NickNameTextBox.ReadOnly = true;
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                UsuariosDataTable = objUsuario.SeleccionarTodos();
                UsuariosDataGridView.DataSource = UsuariosDataTable;
                return true;
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se pudo recuperar los datos", ex);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            _IdUsuarioEdicion = 0;
            _Clave = "";
            NickNameTextBox.Text = "";
            NombreCompletoTextBox.Text = "";
            CITextBox.Text = "";
            DireccionTextBox.Text = "";
            TelefonoTextBox.Text = "";
            EmailTextBox.Text = "";
            Activo.Checked = true;
            RolRubroBox.SelectedValue = 1;
            NickNameTextBox.ReadOnly = false;
        }

        private void GrabarDatos()
        {
            UsuarioDataSet cds = new UsuarioDataSet();
            UsuarioDataSet.UsuarioRow cr = cds.Usuario.NewUsuarioRow();
            cr.NickName = NickNameTextBox.Text;
            cr.NombreCompleto = NombreCompletoTextBox.Text;
            cr.CI = CITextBox.Text;
            cr.Direccion = DireccionTextBox.Text;
            cr.Telefono = TelefonoTextBox.Text;
            cr.Email = EmailTextBox.Text;
            cr.Activo = Activo.Checked;
            cr.Clave = _Clave;
            cr.TipoRol = (int)RolRubroBox.SelectedValue;
            cds.Usuario.Rows.Add(cr);
            try
            {
                if (_IdUsuarioEdicion == 0)
                {
                    cr.Clave = Encriptacion.MD5(cr.NickName);
                    _IdUsuarioEdicion = objUsuario.Insertar(cds);
                }
                else
                {
                    cr.Id = _IdUsuarioEdicion;
                    objUsuario.Modificar(cds);
                }
            }
            catch
            {
                throw;
            }
        }

        private bool ValidarCampos()
        {
            bool datosCorrectos = true;
            MarcaError.Clear();

            if (!ValidarTextBox(NickNameTextBox)) datosCorrectos = false;
            if (!ValidarTextBox(NombreCompletoTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }

        protected DataTable PedirTipoRoles()
        {
            DataTable TipoRolDataTable = new DataTable();
            TipoRolDataTable.Columns.Add(new DataColumn("Valor", typeof(int)));
            TipoRolDataTable.Columns.Add(new DataColumn("Texto", typeof(string)));
            foreach (TipoRol tr in Enum.GetValues(typeof(TipoRol)))
            {
                DataRow dr = TipoRolDataTable.NewRow();
                dr["Valor"] = tr;
                dr["Texto"] = tr;
                TipoRolDataTable.Rows.Add(dr);
            }
            return TipoRolDataTable;
        }
        #endregion
    }
}