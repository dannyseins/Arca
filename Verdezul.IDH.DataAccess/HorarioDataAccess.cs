using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;
using System.Data.SqlClient;

namespace Verdezul.IDH.DataAccess
{
    public partial class HorarioDataAccess
    {
        /// <summary>
        /// Selecciona Horarios Activos
        /// </summary>
        /// <returns></returns>
        public HorarioDataSet.HorarioDataTable SeleccionarActivos()
        {
            return ((HorarioDataSet)SQLConexion.SeleccionarDatos("Horario_SeleccionarActivos", typeof(HorarioDataSet))).Horario;
        }

        public HorarioDataSet.HorarioDataTable SeleccionarxTipoHorario(int tipoHorario)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("TipoHorario", tipoHorario)
            };
            return ((HorarioDataSet)SQLConexion.SeleccionarDatos("Horario_Info_SeleccionarxTipoHorario", parametros, typeof(HorarioDataSet))).Horario;
        }

        public HorarioDataSet.HorarioDataTable SeleccionarxIdCurso(int idCurso)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdCurso", idCurso),
            };

            return ((HorarioDataSet)SQLConexion.SeleccionarDatos("Horario_SeleccionarxIdCurso", parametros, typeof(HorarioDataSet))).Horario;
        }

        public System.Data.DataTable SeleccionarxIdNivelArea(int idArea, int idNivel)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdArea", idArea),
                SqlParameterInput("IdNivel", idNivel),
            };

            return ((HorarioDataSet)SQLConexion.SeleccionarDatos("Horario_SeleccionarxIdNivelArea", parametros, typeof(HorarioDataSet))).Horario;
        }
    }
}
