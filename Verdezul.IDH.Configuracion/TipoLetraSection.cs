using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Verdezul.IDH.Configuracion
{
    public class TipoLetra : ConfigurationElement
    {
        public TipoLetra()
        {
        }

        [ConfigurationProperty("FuenteTexto", DefaultValue = "Arial", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public String FuenteTexto
        {
            get { return (String)this["FuenteTexto"]; }
            set { this["FuenteTexto"] = value; }
        }

        [ConfigurationProperty("Tamano", DefaultValue = "12", IsRequired = true)]
        [IntegerValidator(MinValue = 1, MaxValue = 100)]
        public int Tamano
        {
            get { return (int)this["Tamano"]; }
            set { this["Tamano"] = value; }
        }
    }
}