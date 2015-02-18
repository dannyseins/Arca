using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;
using System.Data.SqlClient;

namespace Verdezul.IDH.DataAccess
{
    public partial class CursoDataAccess
    {
        /// <summary>
        /// Selecciona Cursos Activos
        /// </summary>
        /// <returns></returns>
        public CursoDataSet.CursoDataTable SeleccionarActivos()
        {
            return ((CursoDataSet)SQLConexion.SeleccionarDatos("Curso_SeleccionarActivos", typeof(CursoDataSet))).Curso;
        }

        public CursoDataSet.CursoDataTable SeleccionarxIdAlumno(int idAlumno)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("IdAlumno", idAlumno) 
            };

            return ((CursoDataSet)SQLConexion.SeleccionarDatos("Curso_SeleccionarxIdAlumno", parametros, typeof(CursoDataSet))).Curso;
        }
    }
}
