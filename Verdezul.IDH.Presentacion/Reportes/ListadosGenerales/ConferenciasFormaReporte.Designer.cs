namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class ConferenciasFormaReporte
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
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(653, 0);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.IsSplitterFixed = true;
            this.ReporteSplitContainer.Size = new System.Drawing.Size(663, 557);
            this.ReporteSplitContainer.SplitterDistance = 0;
            // 
            // ConferenciasFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 604);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.IsSplitterFixed = true;
            this.Name = "ConferenciasFormaReporte";
            this.Text = "Reporte de Conferencias";
            this.TieneParametros = false;
            this.Load += new System.EventHandler(this.ConferenciasFormaReporte_Load);
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
