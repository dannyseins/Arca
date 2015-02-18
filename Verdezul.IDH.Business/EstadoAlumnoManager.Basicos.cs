using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para EstadoAlumno.
    /// </summary>
    public partial class EstadoAlumnoManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        EstadoAlumnoDataAccess objEstadoAlumno;

        /// <summary>
        /// Constructor
        /// </summary>
        public EstadoAlumnoManager()
        {
            this.objEstadoAlumno = new EstadoAlumnoDataAccess();
        }

        /// <summary>
        /// Selecciona EstadoAlumnos dado su Identificador
        /// </summary>
        /// <param name="Id">Id de EstadoAlumno</param>
        /// <returns>EstadoAlumnoDataSet</returns>
        public EstadoAlumnoDataSet.EstadoAlumnoDataTable SeleccionarxId(int id)
        {
            return objEstadoAlumno.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los EstadoAlumnos
        /// </summary>
        /// <returns>EstadoAlumnoDataSet</returns>
        public EstadoAlumnoDataSet.EstadoAlumnoDataTable SeleccionarTodos()
        {
            return objEstadoAlumno.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo EstadoAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo EstadoAlumno a Insertar.</param>
        /// <returns>Id de EstadoAlumno Insertado</returns>
        public int Insertar(EstadoAlumnoDataSet ds)
        {
            return objEstadoAlumno.Insertar(ds);
        }

        /// <summary>
        /// Modifica un EstadoAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo EstadoAlumno a Modificar.</param>
        public void Modificar(EstadoAlumnoDataSet ds)
        {
            objEstadoAlumno.Modificar(ds);
        }

        /// <summary>
        /// Borra un EstadoAlumno
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo EstadoAlumno a Borrar.</param>
        public void Borrar(EstadoAlumnoDataSet ds)
        {
            objEstadoAlumno.Borrar(ds);
        }

        /// <summary>
        /// Borra un EstadoAlumno
        /// </summary>
        /// <param name="id">Identificador de EstadoAlumno</param>
        public void Borrar(int id)
        {
            objEstadoAlumno.Borrar(id);
        }
    }
}
