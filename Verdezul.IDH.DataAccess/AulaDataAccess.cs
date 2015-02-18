using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class AulaDataAccess
    {
        /// <summary>
        /// Selecciona Aulas Activos
        /// </summary>
        /// <returns></returns>
        public AulaDataSet.AulaDataTable SeleccionarActivos()
        {
            return ((AulaDataSet)SQLConexion.SeleccionarDatos("Aula_SeleccionarActivos", typeof(AulaDataSet))).Aula;
        }
    }
}
