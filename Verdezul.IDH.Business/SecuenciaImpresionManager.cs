using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para SecuenciaImpresion.
    /// </summary>
    public partial class SecuenciaImpresionManager
    {
        public void PonerEnUso(int idSecuenciaImpresion, int tipoDocumentoPago)
        {
            objSecuenciaImpresion.PonerEnUso(idSecuenciaImpresion, tipoDocumentoPago);
        }

        public SecuenciaImpresionDataSet.SecuenciaImpresionDataTable PedirNuevoNumeroSecuencia(int tipoDocumentoPago)
        {
            return objSecuenciaImpresion.PedirNuevoNumeroSecuencia(tipoDocumentoPago);
        }
    }
}
