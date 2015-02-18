using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Nivel.
    /// </summary>
    public partial class NivelManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        NivelDataAccess objNivel;

        /// <summary>
        /// Constructor
        /// </summary>
        public NivelManager()
        {
            this.objNivel = new NivelDataAccess();
        }

        /// <summary>
        /// Selecciona Nivels dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Nivel</param>
        /// <returns>NivelDataSet</returns>
        public AreaDataSet.NivelDataTable SeleccionarxId(int id)
        {
            return objNivel.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Nivels
        /// </summary>
        /// <returns>NivelDataSet</returns>
        public AreaDataSet.NivelDataTable SeleccionarTodos()
        {
            return objNivel.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Nivel.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Nivel a Insertar.</param>
        /// <returns>Id de Nivel Insertado</returns>
        public int Insertar(AreaDataSet ds)
        {
            return objNivel.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Nivel.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Nivel a Modificar.</param>
        public void Modificar(AreaDataSet ds)
        {
            objNivel.Modificar(ds);
        }

        /// <summary>
        /// Borra un Nivel
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Nivel a Borrar.</param>
        public void Borrar(AreaDataSet ds)
        {
            objNivel.Borrar(ds);
        }

        /// <summary>
        /// Borra un Nivel
        /// </summary>
        /// <param name="id">Identificador de Nivel</param>
        public void Borrar(int id)
        {
            objNivel.Borrar(id);
        }
    }
}
