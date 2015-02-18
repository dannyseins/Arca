using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Docente.
    /// </summary>
    public partial class DocenteManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        DocenteDataAccess objDocente;

        /// <summary>
        /// Constructor
        /// </summary>
        public DocenteManager()
        {
            this.objDocente = new DocenteDataAccess();
        }

        /// <summary>
        /// Selecciona Docentes dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Docente</param>
        /// <returns>DocenteDataSet</returns>
        public DocenteDataSet.DocenteDataTable SeleccionarxId(int id)
        {
            return objDocente.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Docentes
        /// </summary>
        /// <returns>DocenteDataSet</returns>
        public DocenteDataSet.DocenteDataTable SeleccionarTodos()
        {
            return objDocente.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Docente.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Docente a Insertar.</param>
        /// <returns>Id de Docente Insertado</returns>
        public int Insertar(DocenteDataSet ds)
        {
            return objDocente.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Docente.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Docente a Modificar.</param>
        public void Modificar(DocenteDataSet ds)
        {
            objDocente.Modificar(ds);
        }

        /// <summary>
        /// Borra un Docente
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Docente a Borrar.</param>
        public void Borrar(DocenteDataSet ds)
        {
            objDocente.Borrar(ds);
        }

        /// <summary>
        /// Borra un Docente
        /// </summary>
        /// <param name="id">Identificador de Docente</param>
        public void Borrar(int id)
        {
            objDocente.Borrar(id);
        }
    }
}
