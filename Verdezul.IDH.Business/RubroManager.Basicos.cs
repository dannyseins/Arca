using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Rubro.
    /// </summary>
    public partial class RubroManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        RubroDataAccess objRubro;

        /// <summary>
        /// Constructor
        /// </summary>
        public RubroManager()
        {
            this.objRubro = new RubroDataAccess();
        }

        /// <summary>
        /// Selecciona Rubros dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Rubro</param>
        /// <returns>RubroDataSet</returns>
        public RubroDataSet.RubroDataTable SeleccionarxId(int id)
        {
            return objRubro.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Rubros
        /// </summary>
        /// <returns>RubroDataSet</returns>
        public RubroDataSet.RubroDataTable SeleccionarTodos()
        {
            return objRubro.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Rubro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Rubro a Insertar.</param>
        /// <returns>Id de Rubro Insertado</returns>
        public int Insertar(RubroDataSet ds)
        {
            return objRubro.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Rubro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Rubro a Modificar.</param>
        public void Modificar(RubroDataSet ds)
        {
            objRubro.Modificar(ds);
        }

        /// <summary>
        /// Borra un Rubro
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Rubro a Borrar.</param>
        public void Borrar(RubroDataSet ds)
        {
            objRubro.Borrar(ds);
        }

        /// <summary>
        /// Borra un Rubro
        /// </summary>
        /// <param name="id">Identificador de Rubro</param>
        public void Borrar(int id)
        {
            objRubro.Borrar(id);
        }
    }
}
