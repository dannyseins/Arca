using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class CorreoZIPSection : ConfigurationElement
    {
        public CorreoZIPSection()
        {
        }

        [ConfigurationProperty("Direccion", DefaultValue = "Verdezul", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!#$%^&*()[]{};'\"|\\", MinLength = 1, MaxLength = 60)]
        public String Direccion
        {
            get { return (String)this["Direccion"]; }
            set { this["Direccion"] = value; }
        }
    }
}
