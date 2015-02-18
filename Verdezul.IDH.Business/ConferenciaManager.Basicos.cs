using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Conferencia.
    /// </summary>
    public partial class ConferenciaManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        ConferenciaDataAccess objConferencia;

        /// <summary>
        /// Constructor
        /// </summary>
        public ConferenciaManager()
        {
            this.objConferencia = new ConferenciaDataAccess();
        }

        /// <summary>
        /// Selecciona Conferencias dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Conferencia</param>
        /// <returns>ConferenciaDataSet</returns>
        public ConferenciaDataSet.ConferenciaDataTable SeleccionarxId(int id)
        {
            return objConferencia.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Conferencias
        /// </summary>
        /// <returns>ConferenciaDataSet</returns>
        public ConferenciaDataSet.ConferenciaDataTable SeleccionarTodos()
        {
            return objConferencia.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Conferencia.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Conferencia a Insertar.</param>
        /// <returns>Id de Conferencia Insertado</returns>
        public int Insertar(ConferenciaDataSet ds)
        {
            return objConferencia.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Conferencia.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Conferencia a Modificar.</param>
        public void Modificar(ConferenciaDataSet ds)
        {
            objConferencia.Modificar(ds);
        }

        /// <summary>
        /// Borra un Conferencia
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Conferencia a Borrar.</param>
        public void Borrar(ConferenciaDataSet ds)
        {
            objConferencia.Borrar(ds);
        }

        /// <summary>
        /// Borra un Conferencia
        /// </summary>
        /// <param name="id">Identificador de Conferencia</param>
        public void Borrar(int id)
        {
            objConferencia.Borrar(id);
        }
    }
}
