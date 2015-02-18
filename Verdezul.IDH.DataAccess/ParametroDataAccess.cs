using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Verdezul.IDH.DataAccess
{
    public partial class ParametroDataAccess
    {
        public string SeleccionarxNombre(string nombreParametro)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("Nombre", nombreParametro),
                SqlParameterOutput("Valor", SqlDbType.VarChar, 32)
            };
            return (string)SQLConexion.Ejecutar("Parametro_SeleccionarxNombre", parametros, "Valor");
        }
    }
}
