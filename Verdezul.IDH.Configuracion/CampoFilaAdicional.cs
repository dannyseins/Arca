using System;
using System.Collections.Generic;
using System.Text;

namespace Verdezul.IDH.Configuracion
{
    public class CampoFilaAdicional
    {
        public CampoFilaAdicional(string nombreCampo, object valorCampo)
        {
            _NombreCampo = nombreCampo;
            _ValorCampo = valorCampo;
        }

        private string _NombreCampo;
        public string NombreCampo
        {
            get { return _NombreCampo; }
        }

        private object _ValorCampo;
        public object ValorCampo
        {
            get { return _ValorCampo; }
        }
    }

}
