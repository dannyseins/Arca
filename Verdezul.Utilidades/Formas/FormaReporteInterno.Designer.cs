namespace Verdezul.Utilidades.Formas
{
    partial class FormaReporteInterno
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
            this.VisorReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosReporteGroupBox = new System.Windows.Forms.GroupBox();
            this.ReporteSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.Panel2.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisorReporte
            // 
            this.VisorReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VisorReporte.Location = new System.Drawing.Point(7, 3);
            this.VisorReporte.Name = "VisorReporte";
            this.VisorReporte.Size = new System.Drawing.Size(750, 320);
            this.VisorReporte.TabIndex = 0;
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosReporteGroupBox.Location = new System.Drawing.Point(12, 3);
            this.DatosReporteGroupBox.Name = "DatosReporteGroupBox";
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(736, 76);
            this.DatosReporteGroupBox.TabIndex = 1;
            this.DatosReporteGroupBox.TabStop = false;
            this.DatosReporteGroupBox.Text = "Datos de Reporte";
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ReporteSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.ReporteSplitContainer.Name = "ReporteSplitContainer";
            this.ReporteSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ReporteSplitContainer.Panel1
            // 
            this.ReporteSplitContainer.Panel1.Controls.Add(this.DatosReporteGroupBox);
            this.ReporteSplitContainer.Panel1MinSize = 0;
            // 
            // ReporteSplitContainer.Panel2
            // 
            this.ReporteSplitContainer.Panel2.Controls.Add(this.VisorReporte);
            this.ReporteSplitContainer.Size = new System.Drawing.Size(760, 412);
            this.ReporteSplitContainer.SplitterDistance = 82;
            this.ReporteSplitContainer.TabIndex = 2;
            // 
            // FormaReporteInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 459);
            this.Controls.Add(this.ReporteSplitContainer);
            this.Name = "FormaReporteInterno";
            this.Text = "FormaReporteInterno";
            this.Controls.SetChildIndex(this.ReporteSplitContainer, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.Panel2.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer VisorReporte;
        public System.Windows.Forms.GroupBox DatosReporteGroupBox;
        public System.Windows.Forms.SplitContainer ReporteSplitContainer;
    }
}

