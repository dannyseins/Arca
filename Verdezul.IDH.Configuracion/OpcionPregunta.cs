using System;
using System.Collections.Generic;
using System.Text;

namespace Verdezul.IDH.Configuracion
{
    public class OpcionPregunta
    {
        #region Propiedades
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Texto;
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        #endregion

        #region Constructores
        public OpcionPregunta()
        {

        }

        public OpcionPregunta(int id, string texto)
        {
            Id = id;
            Texto = texto;
        }
        #endregion
    }
}
