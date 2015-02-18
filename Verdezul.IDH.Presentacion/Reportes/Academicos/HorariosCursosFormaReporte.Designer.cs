namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class HorariosCursosFormaReporte
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
            this.HorariosCombo = new Verdezul.IDH.Presentacion.Controles.HorarioUserControl();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.HorariosCombo);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 49);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            this.ReporteSplitContainer.SplitterDistance = 55;
            // 
            // HorariosCombo
            // 
            this.HorariosCombo.BackColor = System.Drawing.Color.Transparent;
            this.HorariosCombo.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.HorariosCombo.HorarioVisible = false;
            this.HorariosCombo.Location = new System.Drawing.Point(6, 15);
            this.HorariosCombo.Name = "HorariosCombo";
            this.HorariosCombo.PosicionTextoAdicionalCurso = 0;
            this.HorariosCombo.PosicionTextoAdicionalHorario = 0;
            this.HorariosCombo.Size = new System.Drawing.Size(369, 27);
            this.HorariosCombo.TabIndex = 3;
            this.HorariosCombo.TextoAdicionalCurso = "(Todos)";
            this.HorariosCombo.TextoAdicionalHorario = "(Seleccione)";
            this.HorariosCombo.UsarTextoAdicionalCurso = true;
            this.HorariosCombo.UsarTextoAdicionalHorario = true;
            // 
            // HorariosCursosFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "HorariosCursosFormaReporte";
            this.Text = "Horarios de Cursos";
            this.Load += new System.EventHandler(this.HorariosCursosFormaReporte_Load);
            this.DatosReporteGroupBox.ResumeLayout(false);
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.HorarioUserControl HorariosCombo;


    }
}
