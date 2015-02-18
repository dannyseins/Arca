using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Aula.
    /// </summary>
    public partial class AulaManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        AulaDataAccess objAula;

        /// <summary>
        /// Constructor
        /// </summary>
        public AulaManager()
        {
            this.objAula = new AulaDataAccess();
        }

        /// <summary>
        /// Selecciona Aulas dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Aula</param>
        /// <returns>AulaDataSet</returns>
        public AulaDataSet.AulaDataTable SeleccionarxId(int id)
        {
            return objAula.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Aulas
        /// </summary>
        /// <returns>AulaDataSet</returns>
        public AulaDataSet.AulaDataTable SeleccionarTodos()
        {
            return objAula.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Aula.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Aula a Insertar.</param>
        /// <returns>Id de Aula Insertado</returns>
        public int Insertar(AulaDataSet ds)
        {
            return objAula.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Aula.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Aula a Modificar.</param>
        public void Modificar(AulaDataSet ds)
        {
            objAula.Modificar(ds);
        }

        /// <summary>
        /// Borra un Aula
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Aula a Borrar.</param>
        public void Borrar(AulaDataSet ds)
        {
            objAula.Borrar(ds);
        }

        /// <summary>
        /// Borra un Aula
        /// </summary>
        /// <param name="id">Identificador de Aula</param>
        public void Borrar(int id)
        {
            objAula.Borrar(id);
        }
    }
}
