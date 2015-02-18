using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Usuario
    /// </summary>
    public partial class UsuarioDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Usuarios.
        /// </summary>
        /// <param name="Id">Id de Usuario</param>
        /// <returns>UsuarioDataSet</returns>
        public UsuarioDataSet.UsuarioDataTable Seleccionar(int id)
        {
            return ((UsuarioDataSet)SQLConexion.Seleccionar("Usuario_Seleccionar", id, typeof(UsuarioDataSet))).Usuario;
        }

        /// <summary>
        /// Inserta un nuevo Usuario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Usuario a Insertar.</param>
        /// <returns>Id de Usuario Insertado</returns>
        public int Insertar(UsuarioDataSet ds)
        {
            UsuarioDataSet.UsuarioRow cr = ds.Usuario[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("TipoRol", cr.TipoRol),
                SqlParameterInput("NickName", cr.NickName),
                SqlParameterInput("Clave", cr.Clave),
                SqlParameterInput("NombreCompleto", cr.NombreCompleto),
                SqlParameterInput("CI", cr.CI),
                SqlParameterInput("Direccion", cr.Direccion),
                SqlParameterInput("Telefono", cr.Telefono),
                SqlParameterInput("Email", cr.Email),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Insertar("Usuario_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Usuario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Usuario a Modificar.</param>
        public int Modificar(UsuarioDataSet ds)
        {
            UsuarioDataSet.UsuarioRow cr = ds.Usuario[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("TipoRol", cr.TipoRol),
                SqlParameterInput("NickName", cr.NickName),
                SqlParameterInput("Clave", cr.Clave),
                SqlParameterInput("NombreCompleto", cr.NombreCompleto),
                SqlParameterInput("CI", cr.CI),
                SqlParameterInput("Direccion", cr.Direccion),
                SqlParameterInput("Telefono", cr.Telefono),
                SqlParameterInput("Email", cr.Email),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Modificar("Usuario_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Usuario
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Usuario a Borrar.</param>
        public int Borrar(UsuarioDataSet ds)
        {
            UsuarioDataSet.UsuarioRow cr = ds.Usuario[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Usuario_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Usuario
        /// </summary>
        /// <param name="id">Identificador de Usuario</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Usuario_Borrar", parametros);
        }
    }
}