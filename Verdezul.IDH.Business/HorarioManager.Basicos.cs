using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Horario.
    /// </summary>
    public partial class HorarioManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        HorarioDataAccess objHorario;

        /// <summary>
        /// Constructor
        /// </summary>
        public HorarioManager()
        {
            this.objHorario = new HorarioDataAccess();
        }

        /// <summary>
        /// Selecciona Horarios dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Horario</param>
        /// <returns>HorarioDataSet</returns>
        public HorarioDataSet.HorarioDataTable SeleccionarxId(int id)
        {
            return objHorario.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Horarios
        /// </summary>
        /// <returns>HorarioDataSet</returns>
        public HorarioDataSet.HorarioDataTable SeleccionarTodos()
        {
            return objHorario.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Horario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Horario a Insertar.</param>
        /// <returns>Id de Horario Insertado</returns>
        public int Insertar(HorarioDataSet ds)
        {
            return objHorario.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Horario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Horario a Modificar.</param>
        public void Modificar(HorarioDataSet ds)
        {
            objHorario.Modificar(ds);
        }

        /// <summary>
        /// Borra un Horario
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Horario a Borrar.</param>
        public void Borrar(HorarioDataSet ds)
        {
            objHorario.Borrar(ds);
        }

        /// <summary>
        /// Borra un Horario
        /// </summary>
        /// <param name="id">Identificador de Horario</param>
        public void Borrar(int id)
        {
            objHorario.Borrar(id);
        }
    }
}
