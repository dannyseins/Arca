namespace Verdezul.IDH.Presentacion.Sistema
{
    partial class AlumnoNivelForma
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
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.HorarioNivelAreaActualLabel = new System.Windows.Forms.Label();
            this.HorarioLabel = new System.Windows.Forms.Label();
            this.HorarioNivelComboBox = new System.Windows.Forms.ComboBox();
            this.PagosLabel = new System.Windows.Forms.Label();
            this.PagosInt = new System.Windows.Forms.Label();
            this.MesInicioLabel = new System.Windows.Forms.Label();
            this.FinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AlumnoHorario = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
            this.AlumnoLabel = new System.Windows.Forms.Label();
            this.AreaNivelCombos = new Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl();
            this.CerrarInscripcionCheckBox = new System.Windows.Forms.CheckBox();
            this.HorarioAlumnosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorarioAlumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.ActivoCheckBox);
            this.DatosGroupBox.Controls.Add(this.HorarioNivelAreaActualLabel);
            this.DatosGroupBox.Controls.Add(this.HorarioLabel);
            this.DatosGroupBox.Controls.Add(this.HorarioNivelComboBox);
            this.DatosGroupBox.Controls.Add(this.PagosLabel);
            this.DatosGroupBox.Controls.Add(this.PagosInt);
            this.DatosGroupBox.Controls.Add(this.MesInicioLabel);
            this.DatosGroupBox.Controls.Add(this.FinDateTimePicker);
            this.DatosGroupBox.Controls.Add(this.InicioDateTimePicker);
            this.DatosGroupBox.Controls.Add(this.AlumnoHorario);
            this.DatosGroupBox.Controls.Add(this.AlumnoLabel);
            this.DatosGroupBox.Controls.Add(this.AreaNivelCombos);
            this.DatosGroupBox.Controls.Add(this.CerrarInscripcionCheckBox);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(854, 126);
            this.DatosGroupBox.TabIndex = 0;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Enabled = false;
            this.ActivoCheckBox.Location = new System.Drawing.Point(636, 68);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActivoCheckBox.TabIndex = 41;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // HorarioNivelAreaActualLabel
            // 
            this.HorarioNivelAreaActualLabel.AutoSize = true;
            this.HorarioNivelAreaActualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorarioNivelAreaActualLabel.ForeColor = System.Drawing.Color.Red;
            this.HorarioNivelAreaActualLabel.Location = new System.Drawing.Point(102, 46);
            this.HorarioNivelAreaActualLabel.Name = "HorarioNivelAreaActualLabel";
            this.HorarioNivelAreaActualLabel.Size = new System.Drawing.Size(170, 13);
            this.HorarioNivelAreaActualLabel.TabIndex = 40;
            this.HorarioNivelAreaActualLabel.Text = "HorarioNivelAreaActualLabel";
            // 
            // HorarioLabel
            // 
            this.HorarioLabel.AutoSize = true;
            this.HorarioLabel.Location = new System.Drawing.Point(336, 69);
            this.HorarioLabel.Name = "HorarioLabel";
            this.HorarioLabel.Size = new System.Drawing.Size(41, 13);
            this.HorarioLabel.TabIndex = 39;
            this.HorarioLabel.Text = "Horario";
            // 
            // HorarioNivelComboBox
            // 
            this.HorarioNivelComboBox.DisplayMember = "NombreHorario";
            this.HorarioNivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorarioNivelComboBox.Enabled = false;
            this.HorarioNivelComboBox.FormattingEnabled = true;
            this.HorarioNivelComboBox.Location = new System.Drawing.Point(383, 65);
            this.HorarioNivelComboBox.Name = "HorarioNivelComboBox";
            this.HorarioNivelComboBox.Size = new System.Drawing.Size(247, 21);
            this.HorarioNivelComboBox.TabIndex = 38;
            this.HorarioNivelComboBox.ValueMember = "Id";
            // 
            // PagosLabel
            // 
            this.PagosLabel.AutoSize = true;
            this.PagosLabel.Location = new System.Drawing.Point(585, 100);
            this.PagosLabel.Name = "PagosLabel";
            this.PagosLabel.Size = new System.Drawing.Size(37, 13);
            this.PagosLabel.TabIndex = 37;
            this.PagosLabel.Text = "Pagos";
            // 
            // PagosInt
            // 
            this.PagosInt.AutoSize = true;
            this.PagosInt.Location = new System.Drawing.Point(627, 100);
            this.PagosInt.Name = "PagosInt";
            this.PagosInt.Size = new System.Drawing.Size(13, 13);
            this.PagosInt.TabIndex = 36;
            this.PagosInt.Text = "0";
            // 
            // MesInicioLabel
            // 
            this.MesInicioLabel.AutoSize = true;
            this.MesInicioLabel.Location = new System.Drawing.Point(102, 100);
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
            this.FinDateTimePicker.Location = new System.Drawing.Point(445, 96);
            this.FinDateTimePicker.Name = "FinDateTimePicker";
            this.FinDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.FinDateTimePicker.TabIndex = 33;
            // 
            // InicioDateTimePicker
            // 
            this.InicioDateTimePicker.CustomFormat = "MMMM/yyyy";
            this.InicioDateTimePicker.Enabled = false;
            this.InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InicioDateTimePicker.Location = new System.Drawing.Point(163, 96);
            this.InicioDateTimePicker.Name = "InicioDateTimePicker";
            this.InicioDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.InicioDateTimePicker.TabIndex = 32;
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
            // AreaNivelCombos
            // 
            this.AreaNivelCombos.BackColor = System.Drawing.Color.Transparent;
            this.AreaNivelCombos.Enabled = false;
            this.AreaNivelCombos.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.AreaNivelCombos.Location = new System.Drawing.Point(12, 62);
            this.AreaNivelCombos.Name = "AreaNivelCombos";
            this.AreaNivelCombos.NivelVisible = true;
            this.AreaNivelCombos.PermitirEdicion = true;
            this.AreaNivelCombos.PosicionTextoAdicionalArea = 0;
            this.AreaNivelCombos.PosicionTextoAdicionalNivel = 0;
            this.AreaNivelCombos.Size = new System.Drawing.Size(323, 28);
            this.AreaNivelCombos.TabIndex = 10;
            this.AreaNivelCombos.TextoAdicionalArea = "(Seleccione)";
            this.AreaNivelCombos.TextoAdicionalNivel = "(Seleccione)";
            this.AreaNivelCombos.UsarTextoAdicionalArea = true;
            this.AreaNivelCombos.UsarTextoAdicionalNivel = true;
            this.AreaNivelCombos.NivelCambiado += new System.EventHandler(this.AreaNivelCombos_NivelCambiado);
            // 
            // CerrarInscripcionCheckBox
            // 
            this.CerrarInscripcionCheckBox.AutoSize = true;
            this.CerrarInscripcionCheckBox.Enabled = false;
            this.CerrarInscripcionCheckBox.Location = new System.Drawing.Point(331, 99);
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
            this.HorarioAlumnosDataGridView.Location = new System.Drawing.Point(0, 157);
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
            this.HorarioAlumnosDataGridView.Size = new System.Drawing.Size(854, 278);
            this.HorarioAlumnosDataGridView.TabIndex = 50;
            this.HorarioAlumnosDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HorarioAlumnosDataGridView_CellMouseDoubleClick);
            // 
            // AlumnoNivelForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 460);
            this.Controls.Add(this.DatosGroupBox);
            this.Controls.Add(this.HorarioAlumnosDataGridView);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "AlumnoNivelForma";
            this.Text = "Nivel de Alumno";
            this.Load += new System.EventHandler(this.AlumnoNivelForma_Load);
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

        private Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl AreaNivelCombos;
        private Verdezul.IDH.Presentacion.Controles.AlumnoControl AlumnoHorario;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.DataGridView HorarioAlumnosDataGridView;
        private System.Windows.Forms.Label AlumnoLabel;
        private System.Windows.Forms.Label MesInicioLabel;
        private System.Windows.Forms.DateTimePicker FinDateTimePicker;
        private System.Windows.Forms.DateTimePicker InicioDateTimePicker;
        private System.Windows.Forms.CheckBox CerrarInscripcionCheckBox;
        private System.Windows.Forms.Label PagosLabel;
        private System.Windows.Forms.Label PagosInt;
        private System.Windows.Forms.Label HorarioLabel;
        private System.Windows.Forms.ComboBox HorarioNivelComboBox;
        private System.Windows.Forms.Label HorarioNivelAreaActualLabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
    }
}