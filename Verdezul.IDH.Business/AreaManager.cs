using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class AreaManager
    {
        public int InsertarNivel(AreaDataSet ds)
        {
            return objArea.InsertarNivel(ds);
        }

        public AreaDataSet SeleccionarConNiveles(int idArea)
        {
            return objArea.SeleccionarConNiveles(idArea);
        }
    }
}
