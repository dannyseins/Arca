using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Caja.
    /// </summary>
    public partial class CajaManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        CajaDataAccess objCaja;

        /// <summary>
        /// Constructor
        /// </summary>
        public CajaManager()
        {
            this.objCaja = new CajaDataAccess();
        }

        /// <summary>
        /// Selecciona Cajas dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Caja</param>
        /// <returns>CajaDataSet</returns>
        public CajaDataSet.CajaDataTable SeleccionarxId(int id)
        {
            return objCaja.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Cajas
        /// </summary>
        /// <returns>CajaDataSet</returns>
        public CajaDataSet.CajaDataTable SeleccionarTodos()
        {
            return objCaja.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Caja.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Caja a Insertar.</param>
        /// <returns>Id de Caja Insertado</returns>
        public int Insertar(CajaDataSet ds)
        {
            return objCaja.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Caja.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Caja a Modificar.</param>
        public void Modificar(CajaDataSet ds)
        {
            objCaja.Modificar(ds);
        }

        /// <summary>
        /// Borra un Caja
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Caja a Borrar.</param>
        public void Borrar(CajaDataSet ds)
        {
            objCaja.Borrar(ds);
        }

        /// <summary>
        /// Borra un Caja
        /// </summary>
        /// <param name="id">Identificador de Caja</param>
        public void Borrar(int id)
        {
            objCaja.Borrar(id);
        }
    }
}
