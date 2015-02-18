using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class ConferenciaDataAccess
    {
        /// <summary>
        /// Selecciona Conferencias Activos
        /// </summary>
        /// <returns></returns>
        public ConferenciaDataSet.ConferenciaDataTable SeleccionarActivos()
        {
            return ((ConferenciaDataSet)SQLConexion.SeleccionarDatos("Conferencia_SeleccionarActivos", typeof(ConferenciaDataSet))).Conferencia;
        }
    }
}
