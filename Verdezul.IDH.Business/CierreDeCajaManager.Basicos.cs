using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para CierreDeCaja.
    /// </summary>
    public partial class CierreDeCajaManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        CierreDeCajaDataAccess objCierreDeCaja;

        /// <summary>
        /// Constructor
        /// </summary>
        public CierreDeCajaManager()
        {
            this.objCierreDeCaja = new CierreDeCajaDataAccess();
        }

        /// <summary>
        /// Selecciona CierreDeCajas dado su Identificador
        /// </summary>
        /// <param name="Id">Id de CierreDeCaja</param>
        /// <returns>CierreDeCajaDataSet</returns>
        public CierreDeCajaDataSet.CierreDeCajaDataTable SeleccionarxId(int id)
        {
            return objCierreDeCaja.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los CierreDeCajas
        /// </summary>
        /// <returns>CierreDeCajaDataSet</returns>
        public CierreDeCajaDataSet.CierreDeCajaDataTable SeleccionarTodos()
        {
            return objCierreDeCaja.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo CierreDeCaja.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo CierreDeCaja a Insertar.</param>
        /// <returns>Id de CierreDeCaja Insertado</returns>
        public int Insertar(CierreDeCajaDataSet ds)
        {
            return objCierreDeCaja.Insertar(ds);
        }

        /// <summary>
        /// Modifica un CierreDeCaja.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo CierreDeCaja a Modificar.</param>
        public void Modificar(CierreDeCajaDataSet ds)
        {
            objCierreDeCaja.Modificar(ds);
        }

        /// <summary>
        /// Borra un CierreDeCaja
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo CierreDeCaja a Borrar.</param>
        public void Borrar(CierreDeCajaDataSet ds)
        {
            objCierreDeCaja.Borrar(ds);
        }

        /// <summary>
        /// Borra un CierreDeCaja
        /// </summary>
        /// <param name="id">Identificador de CierreDeCaja</param>
        public void Borrar(int id)
        {
            objCierreDeCaja.Borrar(id);
        }
    }
}
