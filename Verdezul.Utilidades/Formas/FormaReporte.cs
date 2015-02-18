using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Verdezul.Utilidades.Configuracion;
using Microsoft.Reporting.WinForms;
using Verdezul.Utilidades.Clases;

namespace Verdezul.Utilidades.Formas
{
    public partial class FormaReporte : FormaBase
    {
        #region Botones
        protected ToolStripButton MostrarBoton;
        #endregion

        #region Constructor
        public FormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        private void InicializarComponentesAdicionales()
        {
            MostrarBoton = AgregarBotonAccion("Mostrar", "Mostrar", new Bitmap(1, 1), MostrarBoton_Click);
            Elementos = new ElementosReporte();
        }
        #endregion

        #region Propiedades
        private ElementosReporte _Elementos;
        public ElementosReporte Elementos
        {
            get { return _Elementos; }
            set { _Elementos = value; }
        }
        #endregion

        #region Eventos
        private void MostrarBoton_Click(object sender, EventArgs e)
        {
            if (this.DatosReporte())
                ((FormaContenedora)this.MdiParent).MostrarReporte(Elementos);
        }
        protected virtual bool DatosReporte() 
        {
            return true;
        }
        #endregion
    }
}