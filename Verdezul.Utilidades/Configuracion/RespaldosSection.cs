using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class RespaldosSection : ConfigurationElement
    {
        public RespaldosSection()
        {
        }

        [ConfigurationProperty("AplicacionZIP")]
        public AplicacionZIPSection AplicacionZIP
        {
            get { return (AplicacionZIPSection)this["AplicacionZIP"]; }
            set { this["AplicacionZIP"] = value; }
        }

        [ConfigurationProperty("ArgumentosZIP")]
        public ArgumentosZIPSection ArgumentosZIP
        {
            get { return (ArgumentosZIPSection)this["ArgumentosZIP"]; }
            set { this["ArgumentosZIP"] = value; }
        }

        [ConfigurationProperty("CorreoZIP")]
        public CorreoZIPSection CorreoZIP
        {
            get { return (CorreoZIPSection)this["CorreoZIP"]; }
            set { this["CorreoZIP"] = value; }
        }
    }
}
