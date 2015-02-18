using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class DocenteDataAccess
    {
        /// <summary>
        /// Selecciona Docentes Activos
        /// </summary>
        /// <returns></returns>
        public DocenteDataSet.DocenteDataTable SeleccionarActivos()
        {
            return ((DocenteDataSet)SQLConexion.SeleccionarDatos("Docente_SeleccionarActivos", typeof(DocenteDataSet))).Docente;
        }
    }
}
