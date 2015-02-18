using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Verdezul.Utilidades.Configuracion
{
    public class BaseDatosSection : ConfigurationElement
    {
        public BaseDatosSection()
        {
        }

        public BaseDatosSection(String nombreConexion)
        {
            NombreConexion = nombreConexion;
        }

        [ConfigurationProperty("NombreConexion", DefaultValue = "Verdezul", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|\\", MinLength = 1, MaxLength = 60)]
        public String NombreConexion
        {
            get { return (String)this["NombreConexion"]; }
            set { this["NombreConexion"] = value; }
        }
    }
}
