using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class RubroManager
    {
        public RubroDataSet.RubroDataTable SeleccionarActivos()
        {
            return objRubro.SeleccionarActivos();
        }
    }
}
