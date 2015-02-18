using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class AplicacionZIPSection : ConfigurationElement
    {
        public AplicacionZIPSection()
        {
        }

        [ConfigurationProperty("Nombre", DefaultValue = "winzip.exe", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|\\", MinLength = 1, MaxLength = 60)]
        public String Nombre
        {
            get { return (String)this["Nombre"]; }
            set { this["Nombre"] = value; }
        }

        [ConfigurationProperty("FormatoArgumentos", DefaultValue = "{0} {1}", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[];'\"|\\", MinLength = 1, MaxLength = 60)]
        public String FormatoArgumentos
        {
            get { return (String)this["FormatoArgumentos"]; }
            set { this["FormatoArgumentos"] = value; }
        }

        [ConfigurationProperty("TiempoEspera", DefaultValue = "10", IsRequired = true)]
        [IntegerValidator(MinValue=1, MaxValue=120)]
        public int TiempoEspera
        {
            get { return (int)this["TiempoEspera"]; }
            set { this["TiempoEspera"] = value; }
        }
    }
}
