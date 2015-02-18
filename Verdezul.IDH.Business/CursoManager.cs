using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class CursoManager
    {
        public CursoDataSet.CursoDataTable SeleccionarActivos()
        {
            return objCurso.SeleccionarActivos();
        }

        public CursoDataSet.CursoDataTable SeleccionarxIdAlumno(int idAlumno)
        {
            return objCurso.SeleccionarxIdAlumno(idAlumno);
        }
    }
}
