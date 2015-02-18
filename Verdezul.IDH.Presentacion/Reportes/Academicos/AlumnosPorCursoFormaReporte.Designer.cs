namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class AlumnosPorCursoFormaReporte
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
            this.TipoListadoComboBox = new System.Windows.Forms.ComboBox();
            this.TipoListadoLabel = new System.Windows.Forms.Label();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.TipoListadoLabel);
            this.DatosReporteGroupBox.Controls.Add(this.HorariosCursoCombos);
            this.DatosReporteGroupBox.Controls.Add(this.TipoListadoComboBox);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 76);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            // 
            // HorariosCursoCombos
            // 
            this.HorariosCursoCombos.BackColor = System.Drawing.Color.Transparent;
            this.HorariosCursoCombos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.HorariosCursoCombos.HorarioVisible = true;
            this.HorariosCursoCombos.Location = new System.Drawing.Point(6, 15);
            this.HorariosCursoCombos.Name = "HorariosCursoCombos";
            this.HorariosCursoCombos.PosicionTextoAdicionalCurso = 0;
            this.HorariosCursoCombos.PosicionTextoAdicionalHorario = 0;
            this.HorariosCursoCombos.Size = new System.Drawing.Size(333, 55);
            this.HorariosCursoCombos.TabIndex = 0;
            this.HorariosCursoCombos.TextoAdicionalCurso = "(Seleccione)";
            this.HorariosCursoCombos.TextoAdicionalHorario = "(Seleccione)";
            this.HorariosCursoCombos.UsarTextoAdicionalCurso = true;
            this.HorariosCursoCombos.UsarTextoAdicionalHorario = true;
            // 
            // TipoListadoComboBox
            // 
            this.TipoListadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoListadoComboBox.Items.AddRange(new object[] {
            "Simple",
            "Cuadrícula Profesor"});
            this.TipoListadoComboBox.Location = new System.Drawing.Point(408, 19);
            this.TipoListadoComboBox.Name = "TipoListadoComboBox";
            this.TipoListadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.TipoListadoComboBox.TabIndex = 1;
            // 
            // TipoListadoLabel
            // 
            this.TipoListadoLabel.AutoSize = true;
            this.TipoListadoLabel.Location = new System.Drawing.Point(353, 22);
            this.TipoListadoLabel.Name = "TipoListadoLabel";
            this.TipoListadoLabel.Size = new System.Drawing.Size(41, 13);
            this.TipoListadoLabel.TabIndex = 2;
            this.TipoListadoLabel.Text = "Listado";
            // 
            // AlumnosPorCursoFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "AlumnosPorCursoFormaReporte";
            this.Text = "Listado de Alumnos por Curso";
            this.Load += new System.EventHandler(this.AlumnosPorCursoFormaReporte_Load);
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
        private System.Windows.Forms.ComboBox TipoListadoComboBox;
        private System.Windows.Forms.Label TipoListadoLabel;

    }
}
