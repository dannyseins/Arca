using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Horario
    /// </summary>
    public partial class HorarioDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Horarios.
        /// </summary>
        /// <param name="Id">Id de Horario</param>
        /// <returns>HorarioDataSet</returns>
        public HorarioDataSet.HorarioDataTable Seleccionar(int id)
        {
            return ((HorarioDataSet)SQLConexion.Seleccionar("Horario_Seleccionar", id, typeof(HorarioDataSet))).Horario;
        }

        /// <summary>
        /// Inserta un nuevo Horario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Horario a Insertar.</param>
        /// <returns>Id de Horario Insertado</returns>
        public int Insertar(HorarioDataSet ds)
        {
            HorarioDataSet.HorarioRow cr = ds.Horario[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("TipoHorario", cr.TipoHorario),
                SqlParameterInput("IdCurso", ValorEnteroNulo(cr.IdCurso)),
                SqlParameterInput("IdNivel", ValorEnteroNulo(cr.IdNivel)),
                SqlParameterInput("IdAula", cr.IdAula),
                SqlParameterInput("IdDocente", cr.IdDocente),
                SqlParameterInput("HoraInicio", cr.HoraInicio),
                SqlParameterInput("HoraFin", cr.HoraFin),
                SqlParameterInput("Dias", cr.Dias),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Insertar("Horario_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Horario.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Horario a Modificar.</param>
        public int Modificar(HorarioDataSet ds)
        {
            HorarioDataSet.HorarioRow cr = ds.Horario[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("TipoHorario", cr.TipoHorario),
                SqlParameterInput("IdCurso", ValorEnteroNulo(cr.IdCurso)),
                SqlParameterInput("IdNivel", ValorEnteroNulo(cr.IdNivel)),
                SqlParameterInput("IdAula", cr.IdAula),
                SqlParameterInput("IdDocente", cr.IdDocente),
                SqlParameterInput("HoraInicio", cr.HoraInicio),
                SqlParameterInput("HoraFin", cr.HoraFin),
                SqlParameterInput("Dias", cr.Dias),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Modificar("Horario_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Horario
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Horario a Borrar.</param>
        public int Borrar(HorarioDataSet ds)
        {
            HorarioDataSet.HorarioRow cr = ds.Horario[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Horario_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Horario
        /// </summary>
        /// <param name="id">Identificador de Horario</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Horario_Borrar", parametros);
        }
    }
}