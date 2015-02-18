using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Verdezul.IDH.Configuracion
{
    public class FacturasSection : ConfigurationElement
    {
        public FacturasSection()
        {
        }

        [ConfigurationProperty("Impresora")]
        public Impresora Impresora
        {
            get { return (Impresora)this["Impresora"]; }
            set { this["Impresora"] = value; }
        }

        [ConfigurationProperty("TipoLetra")]
        public TipoLetra TipoLetra
        {
            get { return (TipoLetra)this["TipoLetra"]; }
            set { this["TipoLetra"] = value; }
        }

        [ConfigurationProperty("Posicion")]
        public Posicion Posicion
        {
            get { return (Posicion)this["Posicion"]; }
            set { this["Posicion"] = value; }
        }

    }
}