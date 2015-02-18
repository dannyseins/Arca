using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class HorarioAlumnoManager
    {
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarActivos()
        {
            return objHorarioAlumno.SeleccionarActivos();
        }

        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarxIdAlumno(int idAlumno)
        {
            return objHorarioAlumno.SeleccionarxIdAlumno(idAlumno);
        }

        public void CambiarNivel(int idAlumno, int idHorarioAlumno, DateTime fechaInicio, DateTime fechaFin)
        {
            objHorarioAlumno.CambiarNivel(idAlumno, idHorarioAlumno, fechaInicio, fechaFin);
        }

        public HorarioAlumnoDataSet.HorarioAlumnoDataTable PedirHorarioyNivelxAlumno(int idAlumno)
        {
            return objHorarioAlumno.PedirHorarioyNivelxAlumno(idAlumno);
        }

        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarxIdAlumno(int idAlumno, int tipoHorario, bool activo)
        {
            return objHorarioAlumno.SeleccionarxIdAlumno(idAlumno, tipoHorario, activo);
        }
    }
}
