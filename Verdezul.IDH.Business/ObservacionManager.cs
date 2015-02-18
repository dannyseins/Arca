using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class ObservacionManager
    {
        public ObservacionDataSet.ObservacionDataTable SeleccionarActivos()
        {
            return objObservacion.SeleccionarActivos();
        }

        public ObservacionDataSet.ObservacionDataTable SeleccionarxIdAlumno(int idAlumno)
        {
            return objObservacion.SeleccionarxIdAlumno(idAlumno);
        }
    }
}
