using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Configuracion.Enumerados;

namespace Verdezul.IDH.Business
{
    public partial class UsuarioManager
    {
        public int Autenticar(string nickName, string clave)
        {
            return objUsuario.Autenticar(nickName, clave);
        }

        public void CambiarClave(int idUsuario, string clave)
        {
            objUsuario.CambiarClave(idUsuario, clave);
        }

        public int PedirTipoRolxUsuario(int idUsuario)
        {
            return objUsuario.PedirTipoRolxUsuario(idUsuario);
        }
    }
}
