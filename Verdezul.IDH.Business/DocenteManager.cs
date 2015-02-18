using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class DocenteManager
    {
        public DocenteDataSet.DocenteDataTable SeleccionarActivos()
        {
            return objDocente.SeleccionarActivos();
        }
    }
}
