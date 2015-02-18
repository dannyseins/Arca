namespace Verdezul.IDH.Presentacion.Administracion
{
    partial class HorarioCursosForma
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
            this.DiasCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoraFinMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DocenteComboBox = new System.Windows.Forms.ComboBox();
            this.HoraInicioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Activo = new System.Windows.Forms.CheckBox();
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.AulaComboBox = new System.Windows.Forms.ComboBox();
            this.HorariosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.DiasCheckedListBox);
            this.DatosGroupBox.Controls.Add(this.label5);
            this.DatosGroupBox.Controls.Add(this.label4);
            this.DatosGroupBox.Controls.Add(this.HoraFinMaskedTextBox);
            this.DatosGroupBox.Controls.Add(this.DocenteComboBox);
            this.DatosGroupBox.Controls.Add(this.HoraInicioMaskedTextBox);
            this.DatosGroupBox.Controls.Add(this.label3);
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Controls.Add(this.Activo);
            this.DatosGroupBox.Controls.Add(this.CursoComboBox);
            this.DatosGroupBox.Controls.Add(this.AulaComboBox);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(665, 112);
            this.DatosGroupBox.TabIndex = 0;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // DiasCheckedListBox
            // 
            this.DiasCheckedListBox.CheckOnClick = true;
            this.DiasCheckedListBox.ColumnWidth = 80;
            this.DiasCheckedListBox.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.DiasCheckedListBox.Location = new System.Drawing.Point(317, 37);
            this.DiasCheckedListBox.MultiColumn = true;
            this.DiasCheckedListBox.Name = "DiasCheckedListBox";
            this.DiasCheckedListBox.Size = new System.Drawing.Size(173, 64);
            this.DiasCheckedListBox.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Docente";
            // 
            // HoraFinMaskedTextBox
            // 
            this.HoraFinMaskedTextBox.Location = new System.Drawing.Point(422, 12);
            this.HoraFinMaskedTextBox.Mask = "00:00";
            this.HoraFinMaskedTextBox.Name = "HoraFinMaskedTextBox";
            this.HoraFinMaskedTextBox.Size = new System.Drawing.Size(56, 20);
            this.HoraFinMaskedTextBox.TabIndex = 50;
            this.HoraFinMaskedTextBox.Text = "0000";
            this.HoraFinMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // DocenteComboBox
            // 
            this.DocenteComboBox.DisplayMember = "Nombre";
            this.DocenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocenteComboBox.Location = new System.Drawing.Point(66, 63);
            this.DocenteComboBox.Name = "DocenteComboBox";
            this.DocenteComboBox.Size = new System.Drawing.Size(227, 21);
            this.DocenteComboBox.TabIndex = 30;
            this.DocenteComboBox.ValueMember = "Id";
            // 
            // HoraInicioMaskedTextBox
            // 
            this.HoraInicioMaskedTextBox.Location = new System.Drawing.Point(341, 12);
            this.HoraInicioMaskedTextBox.Mask = "00:00";
            this.HoraInicioMaskedTextBox.Name = "HoraInicioMaskedTextBox";
            this.HoraInicioMaskedTextBox.Size = new System.Drawing.Size(56, 20);
            this.HoraInicioMaskedTextBox.TabIndex = 40;
            this.HoraInicioMaskedTextBox.Text = "0000";
            this.HoraInicioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "De";
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Checked = true;
            this.Activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Activo.Location = new System.Drawing.Point(66, 90);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(56, 17);
            this.Activo.TabIndex = 70;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.DisplayMember = "Nombre";
            this.CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursoComboBox.Location = new System.Drawing.Point(66, 11);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(227, 21);
            this.CursoComboBox.TabIndex = 10;
            this.CursoComboBox.ValueMember = "Id";
            // 
            // AulaComboBox
            // 
            this.AulaComboBox.DisplayMember = "Nombre";
            this.AulaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AulaComboBox.Location = new System.Drawing.Point(66, 37);
            this.AulaComboBox.Name = "AulaComboBox";
            this.AulaComboBox.Size = new System.Drawing.Size(227, 21);
            this.AulaComboBox.TabIndex = 20;
            this.AulaComboBox.ValueMember = "Id";
            // 
            // HorariosDataGridView
            // 
            this.HorariosDataGridView.AllowUserToAddRows = false;
            this.HorariosDataGridView.AllowUserToDeleteRows = false;
            this.HorariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HorariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HorariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HorariosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.HorariosDataGridView.Location = new System.Drawing.Point(0, 143);
            this.HorariosDataGridView.Name = "HorariosDataGridView";
            this.HorariosDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HorariosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.HorariosDataGridView.RowHeadersVisible = false;
            this.HorariosDataGridView.RowHeadersWidth = 20;
            this.HorariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HorariosDataGridView.Size = new System.Drawing.Size(665, 396);
            this.HorariosDataGridView.TabIndex = 1000;
            this.HorariosDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HorariosDataGridView_CellMouseDoubleClick);
            // 
            // HorarioCursosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 564);
            this.Controls.Add(this.DatosGroupBox);
            this.Controls.Add(this.HorariosDataGridView);
            this.Icon = Properties.Resources.IconoAdministracion;
            this.Name = "HorarioCursosForma";
            this.Text = "Horario de Cursos (PDH Básico)";
            this.Load += new System.EventHandler(this.HorarioCursosForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.HorariosDataGridView, 0);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.ComboBox AulaComboBox;
        private System.Windows.Forms.ComboBox DocenteComboBox;
        private System.Windows.Forms.MaskedTextBox HoraInicioMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox HoraFinMaskedTextBox;
        private System.Windows.Forms.CheckBox Activo;
        private System.Windows.Forms.CheckedListBox DiasCheckedListBox;
        private System.Windows.Forms.DataGridView HorariosDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}