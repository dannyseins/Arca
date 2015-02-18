using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class ReportesSection : ConfigurationElement
    {
        public ReportesSection()
        {
        }

        public ReportesSection(String carpeta)
        {
            Carpeta = carpeta;
        }

        [ConfigurationProperty("Carpeta", DefaultValue = @"c:\Program Files\Verdezul\Reportes", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|", MinLength = 1, MaxLength = 300)]
        public String Carpeta
        {
            get { return (String)this["Carpeta"]; }
            set { this["Carpeta"] = value; }
        }

        [ConfigurationProperty("ReportePrueba", DefaultValue = @"ReportePrueba.rdlc", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|", MinLength = 1, MaxLength = 300)]
        public String ReportePrueba
        {
            get { return (String)this["ReportePrueba"]; }
            set { this["ReportePrueba"] = value; }
        }

    }
}
