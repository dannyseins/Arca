using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Observacion.
    /// </summary>
    public partial class ObservacionManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        ObservacionDataAccess objObservacion;

        /// <summary>
        /// Constructor
        /// </summary>
        public ObservacionManager()
        {
            this.objObservacion = new ObservacionDataAccess();
        }

        /// <summary>
        /// Selecciona Observacions dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Observacion</param>
        /// <returns>ObservacionDataSet</returns>
        public ObservacionDataSet.ObservacionDataTable SeleccionarxId(int id)
        {
            return objObservacion.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Observacions
        /// </summary>
        /// <returns>ObservacionDataSet</returns>
        public ObservacionDataSet.ObservacionDataTable SeleccionarTodos()
        {
            return objObservacion.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Observacion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Observacion a Insertar.</param>
        /// <returns>Id de Observacion Insertado</returns>
        public int Insertar(ObservacionDataSet ds)
        {
            return objObservacion.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Observacion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Observacion a Modificar.</param>
        public void Modificar(ObservacionDataSet ds)
        {
            objObservacion.Modificar(ds);
        }

        /// <summary>
        /// Borra un Observacion
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Observacion a Borrar.</param>
        public void Borrar(ObservacionDataSet ds)
        {
            objObservacion.Borrar(ds);
        }

        /// <summary>
        /// Borra un Observacion
        /// </summary>
        /// <param name="id">Identificador de Observacion</param>
        public void Borrar(int id)
        {
            objObservacion.Borrar(id);
        }
    }
}
