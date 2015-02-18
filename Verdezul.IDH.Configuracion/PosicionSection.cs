using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Verdezul.IDH.Configuracion
{
    public class Posicion : ConfigurationElement
    {
        public Posicion()
        {

        }

        [ConfigurationProperty("TextoX", DefaultValue = "1", IsRequired = true)]
        public float TextoX
        {
            get { return (float)this["TextoX"]; }
            set { this["TextoX"] = value; }
        }

        [ConfigurationProperty("TextoY", DefaultValue = "1", IsRequired = true)]
        public float TextoY
        {
            get { return (float)this["TextoY"]; }
            set { this["TextoY"] = value; }
        }
    }
}