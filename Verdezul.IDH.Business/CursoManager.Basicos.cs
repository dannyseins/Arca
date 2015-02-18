using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Curso.
    /// </summary>
    public partial class CursoManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        CursoDataAccess objCurso;

        /// <summary>
        /// Constructor
        /// </summary>
        public CursoManager()
        {
            this.objCurso = new CursoDataAccess();
        }

        /// <summary>
        /// Selecciona Cursos dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Curso</param>
        /// <returns>CursoDataSet</returns>
        public CursoDataSet.CursoDataTable SeleccionarxId(int id)
        {
            return objCurso.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Cursos
        /// </summary>
        /// <returns>CursoDataSet</returns>
        public CursoDataSet.CursoDataTable SeleccionarTodos()
        {
            return objCurso.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Curso.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Curso a Insertar.</param>
        /// <returns>Id de Curso Insertado</returns>
        public int Insertar(CursoDataSet ds)
        {
            return objCurso.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Curso.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Curso a Modificar.</param>
        public void Modificar(CursoDataSet ds)
        {
            objCurso.Modificar(ds);
        }

        /// <summary>
        /// Borra un Curso
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Curso a Borrar.</param>
        public void Borrar(CursoDataSet ds)
        {
            objCurso.Borrar(ds);
        }

        /// <summary>
        /// Borra un Curso
        /// </summary>
        /// <param name="id">Identificador de Curso</param>
        public void Borrar(int id)
        {
            objCurso.Borrar(id);
        }
    }
}
