namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class HorariosNivelesFormaReporte
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
            this.NivelCombo = new Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.NivelCombo);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 49);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            this.ReporteSplitContainer.SplitterDistance = 55;
            // 
            // NivelCombo
            // 
            this.NivelCombo.BackColor = System.Drawing.Color.Transparent;
            this.NivelCombo.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.NivelCombo.Location = new System.Drawing.Point(6, 16);
            this.NivelCombo.Name = "NivelCombo";
            this.NivelCombo.NivelVisible = true;
            this.NivelCombo.PosicionTextoAdicionalArea = 0;
            this.NivelCombo.PosicionTextoAdicionalNivel = 0;
            this.NivelCombo.Size = new System.Drawing.Size(369, 27);
            this.NivelCombo.TabIndex = 3;
            this.NivelCombo.TextoAdicionalArea = "(Todos)";
            this.NivelCombo.TextoAdicionalNivel = "(Todos)";
            this.NivelCombo.UsarTextoAdicionalArea = true;
            this.NivelCombo.UsarTextoAdicionalNivel = true;
            // 
            // HorariosNivelesFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "HorariosNivelesFormaReporte";
            this.Text = "Horarios de Áreas/Niveles";
            this.Load += new System.EventHandler(this.HorariosCursosFormaReporte_Load);
            this.DatosReporteGroupBox.ResumeLayout(false);
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl NivelCombo;


    }
}
