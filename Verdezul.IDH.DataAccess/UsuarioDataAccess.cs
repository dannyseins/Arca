using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Verdezul.IDH.DataAccess
{
    public partial class UsuarioDataAccess
    {
        public int Autenticar(string nickName, string clave)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("NickName", nickName),
                SqlParameterInput("Clave", clave),
                SqlParameterOutput("IdUsuario", DbType.Int32),
            };
            return (int)SQLConexion.Ejecutar("Usuario_Autenticar", parametros, "IdUsuario");
        }

        public void CambiarClave(int idUsuario, string clave)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdUsuario", idUsuario),
                SqlParameterInput("Clave", clave),
            };
            SQLConexion.Ejecutar("Usuario_CambiarClave", parametros);
        }

        public int PedirTipoRolxUsuario(int idUsuario)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdUsuario", idUsuario),
                SqlParameterOutput("TipoRol", DbType.Int32),
            };
            return (int)SQLConexion.Ejecutar("Usuario_PedirTipoRolxUsuario", parametros, "TipoRol");
        }
    }
}
