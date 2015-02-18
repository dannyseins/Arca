using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para HorarioAlumno.
    /// </summary>
    public partial class HorarioAlumnoManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        HorarioAlumnoDataAccess objHorarioAlumno;

        /// <summary>
        /// Constructor
        /// </summary>
        public HorarioAlumnoManager()
        {
            this.objHorarioAlumno = new HorarioAlumnoDataAccess();
        }

        /// <summary>
        /// Selecciona HorarioAlumnos dado su Identificador
        /// </summary>
        /// <param name="Id">Id de HorarioAlumno</param>
        /// <returns>HorarioAlumnoDataSet</returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarxId(int id)
        {
            return objHorarioAlumno.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los HorarioAlumnos
        /// </summary>
        /// <returns>HorarioAlumnoDataSet</returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarTodos()
        {
            return objHorarioAlumno.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo HorarioAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo HorarioAlumno a Insertar.</param>
        /// <returns>Id de HorarioAlumno Insertado</returns>
        public int Insertar(HorarioAlumnoDataSet ds)
        {
            return objHorarioAlumno.Insertar(ds);
        }

        /// <summary>
        /// Modifica un HorarioAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo HorarioAlumno a Modificar.</param>
        public void Modificar(HorarioAlumnoDataSet ds)
        {
            objHorarioAlumno.Modificar(ds);
        }

        /// <summary>
        /// Borra un HorarioAlumno
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo HorarioAlumno a Borrar.</param>
        public void Borrar(HorarioAlumnoDataSet ds)
        {
            objHorarioAlumno.Borrar(ds);
        }

        /// <summary>
        /// Borra un HorarioAlumno
        /// </summary>
        /// <param name="id">Identificador de HorarioAlumno</param>
        public void Borrar(int id)
        {
            objHorarioAlumno.Borrar(id);
        }
    }
}
