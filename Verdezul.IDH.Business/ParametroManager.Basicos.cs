using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Parametro.
    /// </summary>
    public partial class ParametroManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        ParametroDataAccess objParametro;

        /// <summary>
        /// Constructor
        /// </summary>
        public ParametroManager()
        {
            this.objParametro = new ParametroDataAccess();
        }

        /// <summary>
        /// Selecciona Parametros dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Parametro</param>
        /// <returns>ParametroDataSet</returns>
        public ParametroDataSet.ParametroDataTable SeleccionarxId(int id)
        {
            return objParametro.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Parametros
        /// </summary>
        /// <returns>ParametroDataSet</returns>
        public ParametroDataSet.ParametroDataTable SeleccionarTodos()
        {
            return objParametro.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Parametro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Parametro a Insertar.</param>
        /// <returns>Id de Parametro Insertado</returns>
        public int Insertar(ParametroDataSet ds)
        {
            return objParametro.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Parametro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Parametro a Modificar.</param>
        public void Modificar(ParametroDataSet ds)
        {
            objParametro.Modificar(ds);
        }

        /// <summary>
        /// Borra un Parametro
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Parametro a Borrar.</param>
        public void Borrar(ParametroDataSet ds)
        {
            objParametro.Borrar(ds);
        }

        /// <summary>
        /// Borra un Parametro
        /// </summary>
        /// <param name="id">Identificador de Parametro</param>
        public void Borrar(int id)
        {
            objParametro.Borrar(id);
        }
    }
}
