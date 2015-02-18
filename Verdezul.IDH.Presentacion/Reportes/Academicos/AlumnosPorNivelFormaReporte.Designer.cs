namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class AlumnosPorNivelFormaReporte
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
            this.AreaNivelCombos = new Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl();
            this.TipoListadoComboBox = new System.Windows.Forms.ComboBox();
            this.TipoListadoLabel = new System.Windows.Forms.Label();
            this.HorarioNivelComboBox = new System.Windows.Forms.ComboBox();
            this.HorarioLabel = new System.Windows.Forms.Label();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.HorarioLabel);
            this.DatosReporteGroupBox.Controls.Add(this.TipoListadoLabel);
            this.DatosReporteGroupBox.Controls.Add(this.AreaNivelCombos);
            this.DatosReporteGroupBox.Controls.Add(this.TipoListadoComboBox);
            this.DatosReporteGroupBox.Controls.Add(this.HorarioNivelComboBox);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(769, 76);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.Size = new System.Drawing.Size(793, 393);
            // 
            // HorariosCursoCombos
            // 
            this.AreaNivelCombos.BackColor = System.Drawing.Color.Transparent;
            this.AreaNivelCombos.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.AreaNivelCombos.Location = new System.Drawing.Point(6, 15);
            this.AreaNivelCombos.Name = "HorariosCursoCombos";
            this.AreaNivelCombos.NivelVisible = true;
            this.AreaNivelCombos.PosicionTextoAdicionalArea = 0;
            this.AreaNivelCombos.PosicionTextoAdicionalNivel = 0;
            this.AreaNivelCombos.Size = new System.Drawing.Size(333, 25);
            this.AreaNivelCombos.TabIndex = 0;
            this.AreaNivelCombos.TextoAdicionalArea = "(Seleccione)";
            this.AreaNivelCombos.TextoAdicionalNivel = "(Seleccione)";
            this.AreaNivelCombos.UsarTextoAdicionalArea = true;
            this.AreaNivelCombos.UsarTextoAdicionalNivel = true;
            this.AreaNivelCombos.NivelCambiado += new System.EventHandler(AreaNivelCombos_NivelCambiado);
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
            // HorariosComboBox
            // 
            this.HorarioNivelComboBox.DisplayMember = "NombreHorario";
            this.HorarioNivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorarioNivelComboBox.FormattingEnabled = true;
            this.HorarioNivelComboBox.Location = new System.Drawing.Point(75, 46);
            this.HorarioNivelComboBox.Name = "HorariosComboBox";
            this.HorarioNivelComboBox.Size = new System.Drawing.Size(247, 21);
            this.HorarioNivelComboBox.TabIndex = 3;
            this.HorarioNivelComboBox.ValueMember = "Id";
            // 
            // HorarioLabel
            // 
            this.HorarioLabel.AutoSize = true;
            this.HorarioLabel.Location = new System.Drawing.Point(11, 49);
            this.HorarioLabel.Name = "HorarioLabel";
            this.HorarioLabel.Size = new System.Drawing.Size(41, 13);
            this.HorarioLabel.TabIndex = 4;
            this.HorarioLabel.Text = "Horario";
            // 
            // AlumnosPorNivelFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 440);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "AlumnosPorNivelFormaReporte";
            this.Text = "Listado de Alumnos por Área/Nivel";
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

        private Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl AreaNivelCombos;
        private System.Windows.Forms.ComboBox TipoListadoComboBox;
        private System.Windows.Forms.ComboBox HorarioNivelComboBox;
        private System.Windows.Forms.Label TipoListadoLabel;
        private System.Windows.Forms.Label HorarioLabel;

    }
}
