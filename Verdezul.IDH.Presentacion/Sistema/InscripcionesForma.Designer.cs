namespace Verdezul.IDH.Presentacion.Sistema
{
    partial class InscripcionesForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.MesInicioLabel = new System.Windows.Forms.Label();
            this.FinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.AlumnoHorario = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
            this.AlumnoLabel = new System.Windows.Forms.Label();
            this.HorarioCombos = new Verdezul.IDH.Presentacion.Controles.HorarioUserControl();
            this.CerrarInscripcionCheckBox = new System.Windows.Forms.CheckBox();
            this.HorarioAlumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.PagosInt = new System.Windows.Forms.Label();
            this.PagosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorarioAlumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.PagosLabel);
            this.DatosGroupBox.Controls.Add(this.PagosInt);
            this.DatosGroupBox.Controls.Add(this.MesInicioLabel);
            this.DatosGroupBox.Controls.Add(this.FinDateTimePicker);
            this.DatosGroupBox.Controls.Add(this.InicioDateTimePicker);
            this.DatosGroupBox.Controls.Add(this.ActivoCheckBox);
            this.DatosGroupBox.Controls.Add(this.AlumnoHorario);
            this.DatosGroupBox.Controls.Add(this.AlumnoLabel);
            this.DatosGroupBox.Controls.Add(this.HorarioCombos);
            this.DatosGroupBox.Controls.Add(this.CerrarInscripcionCheckBox);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(854, 108);
            this.DatosGroupBox.TabIndex = 0;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // MesInicioLabel
            // 
            this.MesInicioLabel.AutoSize = true;
            this.MesInicioLabel.Location = new System.Drawing.Point(102, 83);
            this.MesInicioLabel.Name = "MesInicioLabel";
            this.MesInicioLabel.Size = new System.Drawing.Size(55, 13);
            this.MesInicioLabel.TabIndex = 35;
            this.MesInicioLabel.Text = "Mes Inicio";
            // 
            // FinDateTimePicker
            // 
            this.FinDateTimePicker.CustomFormat = "MMMM/yyyy";
            this.FinDateTimePicker.Enabled = false;
            this.FinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FinDateTimePicker.Location = new System.Drawing.Point(445, 79);
            this.FinDateTimePicker.Name = "FinDateTimePicker";
            this.FinDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.FinDateTimePicker.TabIndex = 33;
            // 
            // InicioDateTimePicker
            // 
            this.InicioDateTimePicker.CustomFormat = "MMMM/yyyy";
            this.InicioDateTimePicker.Enabled = false;
            this.InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InicioDateTimePicker.Location = new System.Drawing.Point(163, 79);
            this.InicioDateTimePicker.Name = "InicioDateTimePicker";
            this.InicioDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.InicioDateTimePicker.TabIndex = 32;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Checked = true;
            this.ActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivoCheckBox.Enabled = false;
            this.ActivoCheckBox.Location = new System.Drawing.Point(586, 52);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActivoCheckBox.TabIndex = 31;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlumnoHorario
            // 
            this.AlumnoHorario.Apellido = "";
            this.AlumnoHorario.BuscarVisible = true;
            this.AlumnoHorario.Location = new System.Drawing.Point(74, 19);
            this.AlumnoHorario.MinimumSize = new System.Drawing.Size(544, 20);
            this.AlumnoHorario.Name = "AlumnoHorario";
            this.AlumnoHorario.Nombre = "";
            this.AlumnoHorario.PermitirCrearAlumno = true;
            this.AlumnoHorario.Size = new System.Drawing.Size(544, 20);
            this.AlumnoHorario.TabIndex = 30;
            this.AlumnoHorario.AlumnoEncontrado += new System.EventHandler(this.AlumnoHorario_AlumnoEncontrado);
            // 
            // AlumnoLabel
            // 
            this.AlumnoLabel.AutoSize = true;
            this.AlumnoLabel.Location = new System.Drawing.Point(21, 22);
            this.AlumnoLabel.Name = "AlumnoLabel";
            this.AlumnoLabel.Size = new System.Drawing.Size(42, 13);
            this.AlumnoLabel.TabIndex = 1;
            this.AlumnoLabel.Text = "Alumno";
            // 
            // HorarioCombos
            // 
            this.HorarioCombos.BackColor = System.Drawing.Color.Transparent;
            this.HorarioCombos.Enabled = false;
            this.HorarioCombos.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.HorarioCombos.HorarioVisible = true;
            this.HorarioCombos.Location = new System.Drawing.Point(12, 45);
            this.HorarioCombos.Name = "HorarioCombos";
            this.HorarioCombos.PosicionTextoAdicionalCurso = 0;
            this.HorarioCombos.PosicionTextoAdicionalHorario = 0;
            this.HorarioCombos.Size = new System.Drawing.Size(568, 28);
            this.HorarioCombos.TabIndex = 10;
            this.HorarioCombos.TextoAdicionalCurso = "(Seleccione)";
            this.HorarioCombos.TextoAdicionalHorario = "(Seleccione)";
            this.HorarioCombos.UsarTextoAdicionalCurso = true;
            this.HorarioCombos.UsarTextoAdicionalHorario = true;
            // 
            // CerrarInscripcionCheckBox
            // 
            this.CerrarInscripcionCheckBox.AutoSize = true;
            this.CerrarInscripcionCheckBox.Enabled = false;
            this.CerrarInscripcionCheckBox.Location = new System.Drawing.Point(331, 82);
            this.CerrarInscripcionCheckBox.Name = "CerrarInscripcionCheckBox";
            this.CerrarInscripcionCheckBox.Size = new System.Drawing.Size(108, 17);
            this.CerrarInscripcionCheckBox.TabIndex = 31;
            this.CerrarInscripcionCheckBox.Text = "Cerrar Inscripción";
            this.CerrarInscripcionCheckBox.UseVisualStyleBackColor = true;
            this.CerrarInscripcionCheckBox.CheckedChanged += new System.EventHandler(this.CerrarInscripcionCheckBox_CheckedChanged);
            // 
            // HorarioAlumnosDataGridView
            // 
            this.HorarioAlumnosDataGridView.AllowUserToAddRows = false;
            this.HorarioAlumnosDataGridView.AllowUserToDeleteRows = false;
            this.HorarioAlumnosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HorarioAlumnosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HorarioAlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HorarioAlumnosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.HorarioAlumnosDataGridView.Location = new System.Drawing.Point(0, 139);
            this.HorarioAlumnosDataGridView.Name = "HorarioAlumnosDataGridView";
            this.HorarioAlumnosDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HorarioAlumnosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.HorarioAlumnosDataGridView.RowHeadersVisible = false;
            this.HorarioAlumnosDataGridView.RowHeadersWidth = 20;
            this.HorarioAlumnosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HorarioAlumnosDataGridView.Size = new System.Drawing.Size(854, 296);
            this.HorarioAlumnosDataGridView.TabIndex = 50;
            this.HorarioAlumnosDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HorarioAlumnosDataGridView_CellMouseDoubleClick);
            // 
            // PagosInt
            // 
            this.PagosInt.AutoSize = true;
            this.PagosInt.Location = new System.Drawing.Point(627, 83);
            this.PagosInt.Name = "PagosInt";
            this.PagosInt.Size = new System.Drawing.Size(13, 13);
            this.PagosInt.TabIndex = 36;
            this.PagosInt.Text = "0";
            // 
            // PagosLabel
            // 
            this.PagosLabel.AutoSize = true;
            this.PagosLabel.Location = new System.Drawing.Point(585, 83);
            this.PagosLabel.Name = "PagosLabel";
            this.PagosLabel.Size = new System.Drawing.Size(37, 13);
            this.PagosLabel.TabIndex = 37;
            this.PagosLabel.Text = "Pagos";
            // 
            // InscripcionesForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 460);
            this.Controls.Add(this.DatosGroupBox);
            this.Controls.Add(this.HorarioAlumnosDataGridView);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "InscripcionesForma";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.InscripcionesForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.HorarioAlumnosDataGridView, 0);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorarioAlumnosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.HorarioUserControl HorarioCombos;
        private Verdezul.IDH.Presentacion.Controles.AlumnoControl AlumnoHorario;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.DataGridView HorarioAlumnosDataGridView;
        private System.Windows.Forms.Label AlumnoLabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Label MesInicioLabel;
        private System.Windows.Forms.DateTimePicker FinDateTimePicker;
        private System.Windows.Forms.DateTimePicker InicioDateTimePicker;
        private System.Windows.Forms.CheckBox CerrarInscripcionCheckBox;
        private System.Windows.Forms.Label PagosLabel;
        private System.Windows.Forms.Label PagosInt;
    }
}