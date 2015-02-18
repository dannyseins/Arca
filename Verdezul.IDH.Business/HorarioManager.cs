using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;
using System.Data;

namespace Verdezul.IDH.Business
{
    public partial class HorarioManager
    {
        public HorarioDataSet.HorarioDataTable SeleccionarActivos()
        {
            return objHorario.SeleccionarActivos();
        }

        public HorarioDataSet.HorarioDataTable SeleccionarxTipoHorario(int tipoHorario)
        {
            return objHorario.SeleccionarxTipoHorario(tipoHorario);
        }

        public HorarioDataSet.HorarioDataTable SeleccionarxIdCurso(int idCurso)
        {
            return objHorario.SeleccionarxIdCurso(idCurso);
        }

        public DataTable SeleccionarxIdNivelArea(int idArea, int idNivel)
        {
            return objHorario.SeleccionarxIdNivelArea(idArea, idNivel);
        }
    }
}
