using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class EstadoAlumnoDataAccess
    {
        /// <summary>
        /// Selecciona EstadoAlumnos Activos
        /// </summary>
        /// <returns></returns>
        public EstadoAlumnoDataSet.EstadoAlumnoDataTable SeleccionarActivos()
        {
            return ((EstadoAlumnoDataSet)SQLConexion.SeleccionarDatos("EstadoAlumno_SeleccionarActivos", typeof(EstadoAlumnoDataSet))).EstadoAlumno;
        }
    }
}
