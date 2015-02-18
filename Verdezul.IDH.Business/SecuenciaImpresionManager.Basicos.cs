using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para SecuenciaImpresion.
    /// </summary>
    public partial class SecuenciaImpresionManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        SecuenciaImpresionDataAccess objSecuenciaImpresion;

        /// <summary>
        /// Constructor
        /// </summary>
        public SecuenciaImpresionManager()
        {
            this.objSecuenciaImpresion = new SecuenciaImpresionDataAccess();
        }

        /// <summary>
        /// Selecciona SecuenciaImpresions dado su Identificador
        /// </summary>
        /// <param name="Id">Id de SecuenciaImpresion</param>
        /// <returns>SecuenciaImpresionDataSet</returns>
        public SecuenciaImpresionDataSet.SecuenciaImpresionDataTable SeleccionarxId(int id)
        {
            return objSecuenciaImpresion.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los SecuenciaImpresions
        /// </summary>
        /// <returns>SecuenciaImpresionDataSet</returns>
        public SecuenciaImpresionDataSet.SecuenciaImpresionDataTable SeleccionarTodos()
        {
            return objSecuenciaImpresion.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo SecuenciaImpresion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo SecuenciaImpresion a Insertar.</param>
        /// <returns>Id de SecuenciaImpresion Insertado</returns>
        public int Insertar(SecuenciaImpresionDataSet ds)
        {
            return objSecuenciaImpresion.Insertar(ds);
        }

        /// <summary>
        /// Modifica un SecuenciaImpresion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo SecuenciaImpresion a Modificar.</param>
        public void Modificar(SecuenciaImpresionDataSet ds)
        {
            objSecuenciaImpresion.Modificar(ds);
        }

        /// <summary>
        /// Borra un SecuenciaImpresion
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo SecuenciaImpresion a Borrar.</param>
        public void Borrar(SecuenciaImpresionDataSet ds)
        {
            objSecuenciaImpresion.Borrar(ds);
        }

        /// <summary>
        /// Borra un SecuenciaImpresion
        /// </summary>
        /// <param name="id">Identificador de SecuenciaImpresion</param>
        public void Borrar(int id)
        {
            objSecuenciaImpresion.Borrar(id);
        }
    }
}
