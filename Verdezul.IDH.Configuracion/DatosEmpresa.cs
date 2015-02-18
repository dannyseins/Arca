using System;
using System.Collections.Generic;
using System.Text;

namespace Verdezul.IDH.Configuracion
{
    public class EmpresaInformacion
    {
        public EmpresaInformacion(string nombre, string direccion, string telefono, string ruc)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            RUC = ruc;
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value;}
        }

        private string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        private string _RUC;
        public string RUC
        {
            get { return _RUC; }
            set { _RUC = value; }
        }
    }
}
