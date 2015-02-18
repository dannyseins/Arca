using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Alumno.
    /// </summary>
    public partial class AlumnoManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        AlumnoDataAccess objAlumno;

        /// <summary>
        /// Constructor
        /// </summary>
        public AlumnoManager()
        {
            this.objAlumno = new AlumnoDataAccess();
        }

        /// <summary>
        /// Selecciona Alumnos dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Alumno</param>
        /// <returns>AlumnoDataSet</returns>
        public AlumnoDataSet.AlumnoDataTable SeleccionarxId(int id)
        {
            return objAlumno.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Alumnos
        /// </summary>
        /// <returns>AlumnoDataSet</returns>
        public AlumnoDataSet.AlumnoDataTable SeleccionarTodos()
        {
            return objAlumno.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Alumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Alumno a Insertar.</param>
        /// <returns>Id de Alumno Insertado</returns>
        public int Insertar(AlumnoDataSet ds)
        {
            return objAlumno.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Alumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Alumno a Modificar.</param>
        public void Modificar(AlumnoDataSet ds)
        {
            objAlumno.Modificar(ds);
        }

        /// <summary>
        /// Borra un Alumno
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Alumno a Borrar.</param>
        public void Borrar(AlumnoDataSet ds)
        {
            objAlumno.Borrar(ds);
        }

        /// <summary>
        /// Borra un Alumno
        /// </summary>
        /// <param name="id">Identificador de Alumno</param>
        public void Borrar(int id)
        {
            objAlumno.Borrar(id);
        }
    }
}
