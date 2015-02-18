using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Verdezul.IDH.Configuracion
{
    public class Impresora : ConfigurationElement
    {
        public Impresora()
        {

        }

        [ConfigurationProperty("Nombre", DefaultValue = "1", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public String Nombre
        {
            get { return (String)this["Nombre"]; }
            set { this["Nombre"] = value; }
        }

        [ConfigurationProperty("Bandeja", DefaultValue = "1", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public String Bandeja
        {
            get { return (String)this["Bandeja"]; }
            set { this["Bandeja"] = value; }
        }

        [ConfigurationProperty("MostrarDialogoImpresion", DefaultValue = "True", IsRequired = true)]
        public bool MostrarDialogoImpresion
        {
            get { return (bool)this["MostrarDialogoImpresion"]; }
            set { this["MostrarDialogoImpresion"] = value; }
        }
    }
}