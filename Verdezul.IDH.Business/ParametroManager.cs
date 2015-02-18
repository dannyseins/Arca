using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class ParametroManager
    {
        public string SeleccionarxNombre(string nombreParametro)
        {
            return objParametro.SeleccionarxNombre(nombreParametro);
        }
    }
}
