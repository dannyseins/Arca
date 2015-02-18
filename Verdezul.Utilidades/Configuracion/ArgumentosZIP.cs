using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class ArgumentosZIPSection : ConfigurationElement
    {
        public ArgumentosZIPSection()
        {
        }

        [ConfigurationProperty("CarpetaRespaldos", DefaultValue = "Verdezul", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|", MinLength = 1, MaxLength = 200)]
        public String CarpetaRespaldos
        {
            get { return (String)this["CarpetaRespaldos"]; }
            set { this["CarpetaRespaldos"] = value; }
        }

        [ConfigurationProperty("CarpetaDatos", DefaultValue = "Verdezul", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|", MinLength = 1, MaxLength = 200)]
        public String CarpetaDatos
        {
            get { return (String)this["CarpetaDatos"]; }
            set { this["CarpetaDatos"] = value; }
        }
    }
}
