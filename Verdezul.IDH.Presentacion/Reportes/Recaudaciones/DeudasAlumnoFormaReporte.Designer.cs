namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class DeudasAlumnoFormaReporte
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
            this.AlumnoReporte = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
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
            this.DatosReporteGroupBox.Controls.Add(this.AlumnoReporte);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 49);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            this.ReporteSplitContainer.SplitterDistance = 55;
            // 
            // HorariosCursoCombos
            // 
            this.AlumnoReporte.Apellido = "";
            this.AlumnoReporte.BackColor = System.Drawing.Color.Transparent;
            this.AlumnoReporte.BuscarVisible = true;
            this.AlumnoReporte.Location = new System.Drawing.Point(6, 15);
            this.AlumnoReporte.MinimumSize = new System.Drawing.Size(544, 20);
            this.AlumnoReporte.Name = "HorariosCursoCombos";
            this.AlumnoReporte.Nombre = "";
            this.AlumnoReporte.PermitirCrearAlumno = false;
            this.AlumnoReporte.Size = new System.Drawing.Size(544, 28);
            this.AlumnoReporte.TabIndex = 0;
            // 
            // MesDeudaDateTimePicker
            // 
            this.MesDeudaDateTimePicker.CustomFormat = "MMMM / yyyy";
            this.MesDeudaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MesDeudaDateTimePicker.Location = new System.Drawing.Point(605, 15);
            this.MesDeudaDateTimePicker.Name = "MesDeudaDateTimePicker";
            this.MesDeudaDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.MesDeudaDateTimePicker.TabIndex = 1;
            // 
            // MesDeudaLabel
            // 
            this.MesDeudaLabel.AutoSize = true;
            this.MesDeudaLabel.Location = new System.Drawing.Point(572, 20);
            this.MesDeudaLabel.Name = "MesDeudaLabel";
            this.MesDeudaLabel.Size = new System.Drawing.Size(27, 13);
            this.MesDeudaLabel.TabIndex = 2;
            this.MesDeudaLabel.Text = "Mes";
            // 
            // DeudasAlumnoFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "DeudasAlumnoFormaReporte";
            this.Text = "Reporte de Deudas de Cursos por Mes";
            this.Load += new System.EventHandler(this.DeudasAlumnoFormaReporte_Load);
            this.DatosReporteGroupBox.ResumeLayout(false);
            this.DatosReporteGroupBox.PerformLayout();
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.AlumnoControl AlumnoReporte;
        private System.Windows.Forms.Label MesDeudaLabel;
        private System.Windows.Forms.DateTimePicker MesDeudaDateTimePicker;

    }
}
