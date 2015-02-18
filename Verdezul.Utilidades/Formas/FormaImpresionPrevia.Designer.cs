namespace Verdezul.Utilidades.Formas
{
    partial class FormaImpresionPrevia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImprimirBoton = new System.Windows.Forms.ToolStripButton();
            this.ConfiguracionPagina = new System.Windows.Forms.PageSetupDialog();
            this.Documento = new System.Drawing.Printing.PrintDocument();
            this.VisorImpresionPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.ZoomDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ZoomPaginaCompleta = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom500 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom200 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom150 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom75 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom50 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom25 = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaImpresion = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // ImprimirBoton
            // 
            this.ImprimirBoton.Image = global::Verdezul.Utilidades.Properties.Resources.Image1;
            this.ImprimirBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImprimirBoton.Name = "ImprimirBoton";
            this.ImprimirBoton.Size = new System.Drawing.Size(23, 22);
            this.ImprimirBoton.Text = "Imprimir";
            this.ImprimirBoton.Click += new System.EventHandler(ImprimirBoton_Click);
            // 
            // VisorImpresionPrevia
            // 
            this.VisorImpresionPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VisorImpresionPrevia.AutoZoom = false;
            this.VisorImpresionPrevia.Location = new System.Drawing.Point(0, 28);
            this.VisorImpresionPrevia.Name = "VisorImpresionPrevia";
            this.VisorImpresionPrevia.Size = new System.Drawing.Size(477, 558);
            this.VisorImpresionPrevia.TabIndex = 0;
            this.VisorImpresionPrevia.UseAntiAlias = true;
            this.VisorImpresionPrevia.Zoom = 0.23182207014542344;
            // 
            // ZoomDropDownButton
            // 
            this.ZoomDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomPaginaCompleta,
            this.Zoom500,
            this.Zoom200,
            this.Zoom150,
            this.Zoom100,
            this.Zoom75,
            this.Zoom50,
            this.Zoom25});
            this.ZoomDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomDropDownButton.Name = "ZoomDropDownButton";
            this.ZoomDropDownButton.Size = new System.Drawing.Size(13, 22);
            this.ZoomDropDownButton.Text = "Zoom - Página Completa";
            // 
            // ZoomPaginaCompleta
            // 
            this.ZoomPaginaCompleta.Name = "ZoomPaginaCompleta";
            this.ZoomPaginaCompleta.Size = new System.Drawing.Size(165, 22);
            this.ZoomPaginaCompleta.Text = "Página Completa";
            this.ZoomPaginaCompleta.Click += new System.EventHandler(this.ZoomPaginaCompleta_Click);
            // 
            // Zoom500
            // 
            this.Zoom500.Name = "Zoom500";
            this.Zoom500.Size = new System.Drawing.Size(165, 22);
            this.Zoom500.Text = "500 %";
            this.Zoom500.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoom200
            // 
            this.Zoom200.Name = "Zoom200";
            this.Zoom200.Size = new System.Drawing.Size(165, 22);
            this.Zoom200.Text = "200 %";
            this.Zoom200.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoom150
            // 
            this.Zoom150.Name = "Zoom150";
            this.Zoom150.Size = new System.Drawing.Size(165, 22);
            this.Zoom150.Text = "150 %";
            this.Zoom150.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoom100
            // 
            this.Zoom100.Name = "Zoom100";
            this.Zoom100.Size = new System.Drawing.Size(165, 22);
            this.Zoom100.Text = "100 %";
            this.Zoom100.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoom75
            // 
            this.Zoom75.Name = "Zoom75";
            this.Zoom75.Size = new System.Drawing.Size(165, 22);
            this.Zoom75.Text = "75 %";
            this.Zoom75.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoom50
            // 
            this.Zoom50.Name = "Zoom50";
            this.Zoom50.Size = new System.Drawing.Size(165, 22);
            this.Zoom50.Text = "50 %";
            this.Zoom50.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoom25
            // 
            this.Zoom25.Name = "Zoom25";
            this.Zoom25.Size = new System.Drawing.Size(165, 22);
            this.Zoom25.Text = "25 %";
            this.Zoom25.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // VentanaImpresion
            // 
            this.VentanaImpresion.UseEXDialog = true;            
            // 
            // FormaImpresionPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 611);
            this.Controls.Add(this.VisorImpresionPrevia);
            this.Name = "FormaImpresionPrevia";
            this.Text = "FormaImpresionPrevia";
            this.Load += new System.EventHandler(this.FormaImpresionPrevia_Load);
            this.Controls.SetChildIndex(this.VisorImpresionPrevia, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Drawing.Printing.PrintDocument Documento;
        private System.Windows.Forms.PageSetupDialog ConfiguracionPagina;
        private System.Windows.Forms.PrintPreviewControl VisorImpresionPrevia;
        private System.Windows.Forms.ToolStripButton ImprimirBoton;
        private System.Windows.Forms.ToolStripDropDownButton ZoomDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ZoomPaginaCompleta;
        private System.Windows.Forms.ToolStripMenuItem Zoom500;
        private System.Windows.Forms.ToolStripMenuItem Zoom200;
        private System.Windows.Forms.ToolStripMenuItem Zoom150;
        private System.Windows.Forms.ToolStripMenuItem Zoom100;
        private System.Windows.Forms.ToolStripMenuItem Zoom75;
        private System.Windows.Forms.ToolStripMenuItem Zoom50;
        private System.Windows.Forms.ToolStripMenuItem Zoom25;
        private System.Windows.Forms.PrintDialog VentanaImpresion;

        #endregion
    }
}