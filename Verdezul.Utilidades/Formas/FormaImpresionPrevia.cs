using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Verdezul.Utilidades.Formas
{
    public partial class FormaImpresionPrevia : FormaBase
    {
        #region Propiedades
        public PrintPageEventHandler EventoImpresionPagina
        {
            set { Documento.PrintPage += value; }
        }

        public string TituloImpresion
        {
            get { return Documento.DocumentName; }
            set { Documento.DocumentName = value; }
        }
        #endregion

        #region Constructor
        public FormaImpresionPrevia()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public FormaImpresionPrevia(PrintPageEventHandler eventoImpresionPagina)
        {
            InitializeComponent();
            Documento.PrintPage += eventoImpresionPagina;
            InicializarComponentesAdicionales();
        }

        public FormaImpresionPrevia(string tituloImpresion)
        {
            InitializeComponent();
            Documento.DocumentName = tituloImpresion;
            InicializarComponentesAdicionales();
        }

        public FormaImpresionPrevia(string tituloImpresion, PrintPageEventHandler eventoImpresionPagina)
        {
            InitializeComponent();
            this.Documento.DocumentName = tituloImpresion;
            this.Documento.PrintPage += eventoImpresionPagina;
            InicializarComponentesAdicionales();
        }

        public FormaImpresionPrevia(string tituloImpresion, PrintPageEventHandler eventoImpresionPagina, double porcentaje)
        {
            InitializeComponent();
            this.Documento.DocumentName = tituloImpresion;
            this.Documento.PrintPage += eventoImpresionPagina;
            InicializarComponentesAdicionales();
            if (porcentaje > 0)
            {
                CambiarZoom(porcentaje);
                this.ZoomDropDownButton.Text = string.Format("Zoom {0}", porcentaje);
            }
            else
                this.VisorImpresionPrevia.AutoZoom = true;
        }

        private void InicializarComponentesAdicionales()
        {
            this.BarraBotones.Items.Add(ImprimirBoton);
            this.BarraBotones.Items.Add(ZoomDropDownButton);
            this.Text = string.Format("Impresión Previa - {0}", Documento.DocumentName);
        }
        #endregion

        #region Eventos
        private void FormaImpresionPrevia_Load(object sender, EventArgs e)
        {
            this.VisorImpresionPrevia.Document = this.Documento;
        }

        private void ImprimirBoton_Click(object sender, EventArgs e)
        {
            if (VentanaImpresion.ShowDialog().Equals(DialogResult.OK))
                this.Documento.Print();
            this.DialogResult = DialogResult.OK;
        }
        
        private void Zoom_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            CambiarZoom(this.VisorImpresionPrevia.Zoom = double.Parse(tsmi.Text.Replace(" %", "")));
            this.ZoomDropDownButton.Text = string.Format("Zoom {0}", tsmi.Text);
        }

        private void ZoomPaginaCompleta_Click(object sender, EventArgs e)
        {
            this.VisorImpresionPrevia.AutoZoom = true;
            this.ZoomDropDownButton.Text = "Zoom - Página Completa";
        }
        #endregion

        #region Métodos
        private void CambiarZoom(double porcentaje)
        {
            this.VisorImpresionPrevia.Zoom = porcentaje/100;
        }
        #endregion
    }
}