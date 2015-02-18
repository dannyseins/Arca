namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class ObservacionesAlumnoFormaReporte
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
            this.AlumnoObservacion = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.AlumnoObservacion);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 49);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            this.ReporteSplitContainer.SplitterDistance = 55;
            // 
            // AlumnoObservacion
            // 
            this.AlumnoObservacion.Apellido = "";
            this.AlumnoObservacion.BackColor = System.Drawing.Color.Transparent;
            this.AlumnoObservacion.BuscarVisible = true;
            this.AlumnoObservacion.Location = new System.Drawing.Point(6, 16);
            this.AlumnoObservacion.MinimumSize = new System.Drawing.Size(544, 20);
            this.AlumnoObservacion.Name = "AlumnoObservacion";
            this.AlumnoObservacion.Nombre = "";
            this.AlumnoObservacion.PermitirCrearAlumno = true;
            this.AlumnoObservacion.Size = new System.Drawing.Size(544, 27);
            this.AlumnoObservacion.TabIndex = 3;
            // 
            // ObservacionesAlumnoFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "ObservacionesAlumnoFormaReporte";
            this.Text = "Reporte de Observaciones de Alumno";
            this.Load += new System.EventHandler(this.HorariosCursosFormaReporte_Load);
            this.DatosReporteGroupBox.ResumeLayout(false);
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.AlumnoControl AlumnoObservacion;


    }
}
