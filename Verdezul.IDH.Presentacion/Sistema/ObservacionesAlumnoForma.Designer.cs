namespace Verdezul.IDH.Presentacion.Sistema
{
    partial class ObservacionesAlumnoForma
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
            this.DocenteLabel = new System.Windows.Forms.Label();
            this.DocenteComboBox = new System.Windows.Forms.ComboBox();
            this.FechaObservacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AlumnoObservacion = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ObservacionsDataGridView = new System.Windows.Forms.DataGridView();
            this.TextoAbiertoTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.DocenteLabel);
            this.DatosGroupBox.Controls.Add(this.DocenteComboBox);
            this.DatosGroupBox.Controls.Add(this.FechaObservacionDateTimePicker);
            this.DatosGroupBox.Controls.Add(this.AlumnoObservacion);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(719, 77);
            this.DatosGroupBox.TabIndex = 0;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // DocenteLabel
            // 
            this.DocenteLabel.AutoSize = true;
            this.DocenteLabel.Location = new System.Drawing.Point(45, 48);
            this.DocenteLabel.Name = "DocenteLabel";
            this.DocenteLabel.Size = new System.Drawing.Size(48, 13);
            this.DocenteLabel.TabIndex = 33;
            this.DocenteLabel.Text = "Docente";
            // 
            // DocenteComboBox
            // 
            this.DocenteComboBox.DisplayMember = "NombreCompleto";
            this.DocenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocenteComboBox.Enabled = false;
            this.DocenteComboBox.FormattingEnabled = true;
            this.DocenteComboBox.Location = new System.Drawing.Point(117, 45);
            this.DocenteComboBox.Name = "DocenteComboBox";
            this.DocenteComboBox.Size = new System.Drawing.Size(298, 21);
            this.DocenteComboBox.TabIndex = 32;
            this.DocenteComboBox.ValueMember = "Id";
            // 
            // FechaObservacionDateTimePicker
            // 
            this.FechaObservacionDateTimePicker.Enabled = false;
            this.FechaObservacionDateTimePicker.Location = new System.Drawing.Point(437, 46);
            this.FechaObservacionDateTimePicker.Name = "FechaObservacionDateTimePicker";
            this.FechaObservacionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaObservacionDateTimePicker.TabIndex = 31;
            // 
            // AlumnoObservacion
            // 
            this.AlumnoObservacion.Apellido = "";
            this.AlumnoObservacion.BuscarVisible = true;
            this.AlumnoObservacion.Location = new System.Drawing.Point(93, 19);
            this.AlumnoObservacion.MinimumSize = new System.Drawing.Size(544, 20);
            this.AlumnoObservacion.Name = "AlumnoObservacion";
            this.AlumnoObservacion.Nombre = "";
            this.AlumnoObservacion.PermitirCrearAlumno = true;
            this.AlumnoObservacion.Size = new System.Drawing.Size(571, 20);
            this.AlumnoObservacion.TabIndex = 30;
            this.AlumnoObservacion.AlumnoEncontrado += new System.EventHandler(this.AlumnoObservacion_AlumnoEncontrado);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno";
            // 
            // ObservacionsDataGridView
            // 
            this.ObservacionsDataGridView.AllowUserToAddRows = false;
            this.ObservacionsDataGridView.AllowUserToDeleteRows = false;
            this.ObservacionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ObservacionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ObservacionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ObservacionsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ObservacionsDataGridView.Location = new System.Drawing.Point(0, 237);
            this.ObservacionsDataGridView.Name = "ObservacionsDataGridView";
            this.ObservacionsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ObservacionsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ObservacionsDataGridView.RowHeadersVisible = false;
            this.ObservacionsDataGridView.RowHeadersWidth = 20;
            this.ObservacionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ObservacionsDataGridView.Size = new System.Drawing.Size(719, 255);
            this.ObservacionsDataGridView.TabIndex = 50;
            this.ObservacionsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ObservacionsDataGridView_CellMouseDoubleClick);
            // 
            // TextoAbiertoTextBox
            // 
            this.TextoAbiertoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextoAbiertoTextBox.Enabled = false;
            this.TextoAbiertoTextBox.Location = new System.Drawing.Point(0, 108);
            this.TextoAbiertoTextBox.Name = "TextoAbiertoTextBox";
            this.TextoAbiertoTextBox.Size = new System.Drawing.Size(719, 123);
            this.TextoAbiertoTextBox.TabIndex = 51;
            this.TextoAbiertoTextBox.Text = "";
            // 
            // ObservacionesAlumnoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 517);
            this.Controls.Add(this.TextoAbiertoTextBox);
            this.Controls.Add(this.DatosGroupBox);
            this.Controls.Add(this.ObservacionsDataGridView);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "ObservacionesAlumnoForma";
            this.Text = "Observaciones para Alumnos";
            this.Load += new System.EventHandler(this.InscripcionesForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.ObservacionsDataGridView, 0);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            this.Controls.SetChildIndex(this.TextoAbiertoTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Verdezul.IDH.Presentacion.Controles.AlumnoControl AlumnoObservacion;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.DataGridView ObservacionsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DocenteComboBox;
        private System.Windows.Forms.DateTimePicker FechaObservacionDateTimePicker;
        private System.Windows.Forms.RichTextBox TextoAbiertoTextBox;
        private System.Windows.Forms.Label DocenteLabel;
    }
}