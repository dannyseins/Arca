namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class DeudasCursosFormaReporte
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
            this.HorariosCursoCombos = new Verdezul.IDH.Presentacion.Controles.HorarioUserControl();
            this.MesDeudaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MesDeudaLabel = new System.Windows.Forms.Label();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.MesDeudaLabel);
            this.DatosReporteGroupBox.Controls.Add(this.MesDeudaDateTimePicker);
            this.DatosReporteGroupBox.Controls.Add(this.HorariosCursoCombos);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 49);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            this.ReporteSplitContainer.SplitterDistance = 55;
            // 
            // HorariosCursoCombos
            // 
            this.HorariosCursoCombos.BackColor = System.Drawing.Color.Transparent;
            this.HorariosCursoCombos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.HorariosCursoCombos.HorarioVisible = false;
            this.HorariosCursoCombos.Location = new System.Drawing.Point(6, 15);
            this.HorariosCursoCombos.Name = "HorariosCursoCombos";
            this.HorariosCursoCombos.PosicionTextoAdicionalCurso = 0;
            this.HorariosCursoCombos.PosicionTextoAdicionalHorario = 0;
            this.HorariosCursoCombos.Size = new System.Drawing.Size(333, 28);
            this.HorariosCursoCombos.TabIndex = 0;
            this.HorariosCursoCombos.TextoAdicionalCurso = "(Todos)";
            this.HorariosCursoCombos.TextoAdicionalHorario = "(Todos)";
            this.HorariosCursoCombos.UsarTextoAdicionalCurso = true;
            this.HorariosCursoCombos.UsarTextoAdicionalHorario = true;
            // 
            // MesDeudaDateTimePicker
            // 
            this.MesDeudaDateTimePicker.CustomFormat = "MMMM / yyyy";
            this.MesDeudaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MesDeudaDateTimePicker.Location = new System.Drawing.Point(404, 18);
            this.MesDeudaDateTimePicker.Name = "MesDeudaDateTimePicker";
            this.MesDeudaDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.MesDeudaDateTimePicker.TabIndex = 1;
            // 
            // MesDeudaLabel
            // 
            this.MesDeudaLabel.AutoSize = true;
            this.MesDeudaLabel.Location = new System.Drawing.Point(371, 23);
            this.MesDeudaLabel.Name = "MesDeudaLabel";
            this.MesDeudaLabel.Size = new System.Drawing.Size(27, 13);
            this.MesDeudaLabel.TabIndex = 2;
            this.MesDeudaLabel.Text = "Mes";
            // 
            // DeudasCursosFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "DeudasCursosFormaReporte";
            this.Text = "Reporte de Deudas de Cursos por Mes";
            this.Load += new System.EventHandler(this.DeudasCursosFormaReporte_Load);
            this.DatosReporteGroupBox.ResumeLayout(false);
            this.DatosReporteGroupBox.PerformLayout();
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.HorarioUserControl HorariosCursoCombos;
        private System.Windows.Forms.Label MesDeudaLabel;
        private System.Windows.Forms.DateTimePicker MesDeudaDateTimePicker;

    }
}
