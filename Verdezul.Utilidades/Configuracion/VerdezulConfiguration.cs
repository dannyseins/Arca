using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class VerdezulConfiguration : ConfigurationSection
    {
        public VerdezulConfiguration()
        {
        }

        [ConfigurationProperty("Conexiones")]
        public ConexionesSection Conexiones
        {
            get { return (ConexionesSection)this["Conexiones"]; }
            set { this["Conexiones"] = value; }
        }

        [ConfigurationProperty("Respaldos")]
        public RespaldosSection Respaldos
        {
            get { return (RespaldosSection)this["Respaldos"]; }
            set { this["Respaldos"] = value; }
        }
    }
}
