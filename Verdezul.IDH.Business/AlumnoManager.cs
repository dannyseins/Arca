using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Alumno.
    /// </summary>
    public partial class AlumnoManager
    {
        public AlumnoDataSet.AlumnoDataTable SeleccionarxIdentificaionxNombrexApellido(string identificacion, string nombre, string apellido)
        {
            return objAlumno.SeleccionarxIdentificaionxNombrexApellido(identificacion, nombre, apellido);
        }

        public AlumnoDataSet.AlumnoDataTable SeleccionarxPertenenciaAreaNivelCurso(int tipoPertenencia, int idArea, int idNivel, int idCurso)
        {
            return objAlumno.SeleccionarxPertenenciaAreaNivelCurso(tipoPertenencia, idArea, idNivel, idCurso);
        }

        public void ModificarFoto(int _IdAlumno, string archivoFoto)
        {
            objAlumno.ModificarFoto(_IdAlumno, archivoFoto);
        }

        public DataTable SeleccionarxMesNacimiento(int mesNacimiento)
        {
            return objAlumno.SeleccionarxMesNacimiento(mesNacimiento);
        }

        public DataTable SeleccionarxIdHorario(int idHorario)
        {
            return objAlumno.SeleccionarxIdHorario(idHorario);
        }
    }
}
