namespace Verdezul.Utilidades.Formas
{
    partial class VisorReportes
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
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // VisorReporte
            // 
            this.VisorReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorReporte.Location = new System.Drawing.Point(0, 25);
            this.VisorReporte.Name = "VisorReporte";
            this.VisorReporte.Size = new System.Drawing.Size(655, 643);
            this.VisorReporte.TabIndex = 0;
            // 
            // VisorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(655, 690);
            this.Controls.Add(this.VisorReporte);
            this.Name = "VisorReportes";
            this.Load += new System.EventHandler(this.FormaReporte_Load);
            this.Activated += new System.EventHandler(this.VisorReportes_Activated);
            this.Controls.SetChildIndex(this.VisorReporte, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer VisorReporte;


    }
}