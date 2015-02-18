using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para SecuenciaImpresion
    /// </summary>
    public partial class SecuenciaImpresionDataAccess
    {
        public void PonerEnUso(int idSecuenciaImpresion, int tipoDocumentoPago)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("IdSecuenciaImpresion", idSecuenciaImpresion),
                SqlParameterInput("TipoDocumentoPago", tipoDocumentoPago) 
            };
            SQLConexion.Ejecutar("SecuenciaImpresion_PonerEnUso", parametros);
        }

        public SecuenciaImpresionDataSet.SecuenciaImpresionDataTable PedirNuevoNumeroSecuencia(int tipoDocumentoPago)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("TipoDocumentoPago", tipoDocumentoPago),
            };
            return ((SecuenciaImpresionDataSet)SQLConexion.SeleccionarDatos("SecuenciaImpresion_PedirNuevoNumeroSecuencia", parametros, typeof(SecuenciaImpresionDataSet))).SecuenciaImpresion;
        }
    }
}