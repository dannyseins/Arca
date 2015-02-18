using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Usuario.
    /// </summary>
    public partial class UsuarioManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        UsuarioDataAccess objUsuario;

        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioManager()
        {
            this.objUsuario = new UsuarioDataAccess();
        }

        /// <summary>
        /// Selecciona Usuarios dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Usuario</param>
        /// <returns>UsuarioDataSet</returns>
        public UsuarioDataSet.UsuarioDataTable SeleccionarxId(int id)
        {
            return objUsuario.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Usuarios
        /// </summary>
        /// <returns>UsuarioDataSet</returns>
        public UsuarioDataSet.UsuarioDataTable SeleccionarTodos()
        {
            return objUsuario.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Usuario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Usuario a Insertar.</param>
        /// <returns>Id de Usuario Insertado</returns>
        public int Insertar(UsuarioDataSet ds)
        {
            return objUsuario.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Usuario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Usuario a Modificar.</param>
        public void Modificar(UsuarioDataSet ds)
        {
            objUsuario.Modificar(ds);
        }

        /// <summary>
        /// Borra un Usuario
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Usuario a Borrar.</param>
        public void Borrar(UsuarioDataSet ds)
        {
            objUsuario.Borrar(ds);
        }

        /// <summary>
        /// Borra un Usuario
        /// </summary>
        /// <param name="id">Identificador de Usuario</param>
        public void Borrar(int id)
        {
            objUsuario.Borrar(id);
        }
    }
}
