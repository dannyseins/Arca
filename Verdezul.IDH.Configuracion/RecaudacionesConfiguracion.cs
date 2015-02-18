using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Verdezul.IDH.Configuracion
{
    public class RecaudacionesConfiguracion : ConfigurationSection
    {
        public RecaudacionesConfiguracion()
        {
            
        }

        string _CajaLocal = "CajaLocal";
        [ConfigurationProperty("CajaLocal", DefaultValue = "1", IsRequired = true)]
        [IntegerValidator(MinValue=1, MaxValue=30)]
        public int CajaLocal
        {
            get { return (int)this[_CajaLocal]; }
            set { this[_CajaLocal] = value; }
        }

        string _Start = "Start";
        [ConfigurationProperty("Start", DefaultValue = "False", IsRequired = true)]
        public bool Start
        {
            get { return (bool)this[_Start]; }
            set { this[_Start] = value; }
        }

        [ConfigurationProperty("Facturas")]
        public FacturasSection Facturas
        {
            get { return (FacturasSection)this["Facturas"]; }
            set { this["Facturas"] = value; }
        }
    }
}