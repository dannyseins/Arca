using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class ConexionesSection : ConfigurationElement
    {
        public ConexionesSection()
        {
        }

        public ConexionesSection(String fuente)
        {
            Fuente = fuente;
        }

        string _Fuente = "Fuente";
        [ConfigurationProperty("Fuente", DefaultValue = "Verdezul", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public String Fuente
        {
            get { return (String)this[_Fuente]; }
            set { this[_Fuente] = value; }
        }

        [ConfigurationProperty("BaseDatos")]
        public BaseDatosSection BaseDatos
        {
            get { return (BaseDatosSection)this["BaseDatos"]; }
            set { this["BaseDatos"] = value; }
        }

        [ConfigurationProperty("Reportes")]
        public ReportesSection Reportes
        {
            get { return (ReportesSection)this["Reportes"]; }
            set { this["Reportes"] = value; }
        }
    }
}
