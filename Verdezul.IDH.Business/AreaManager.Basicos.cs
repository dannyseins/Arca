using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Area.
    /// </summary>
    public partial class AreaManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        AreaDataAccess objArea;

        /// <summary>
        /// Constructor
        /// </summary>
        public AreaManager()
        {
            this.objArea = new AreaDataAccess();
        }

        /// <summary>
        /// Selecciona Areas dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Area</param>
        /// <returns>AreaDataSet</returns>
        public AreaDataSet.AreaDataTable SeleccionarxId(int id)
        {
            return objArea.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Areas
        /// </summary>
        /// <returns>AreaDataSet</returns>
        public AreaDataSet.AreaDataTable SeleccionarTodos()
        {
            return objArea.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Area.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Area a Insertar.</param>
        /// <returns>Id de Area Insertado</returns>
        public int Insertar(AreaDataSet ds)
        {
            return objArea.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Area.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Area a Modificar.</param>
        public void Modificar(AreaDataSet ds)
        {
            objArea.Modificar(ds);
        }

        /// <summary>
        /// Borra un Area
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Area a Borrar.</param>
        public void Borrar(AreaDataSet ds)
        {
            objArea.Borrar(ds);
        }

        /// <summary>
        /// Borra un Area
        /// </summary>
        /// <param name="id">Identificador de Area</param>
        public void Borrar(int id)
        {
            objArea.Borrar(id);
        }
    }
}
