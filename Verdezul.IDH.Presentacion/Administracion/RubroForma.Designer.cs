namespace Verdezul.IDH.Presentacion.Administracion
{
    partial class RubroForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.TieneIVACheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Activo = new System.Windows.Forms.CheckBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.PVPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IVANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RubrosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PVPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVANumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RubrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.TieneIVACheckBox);
            this.DatosGroupBox.Controls.Add(this.label5);
            this.DatosGroupBox.Controls.Add(this.label4);
            this.DatosGroupBox.Controls.Add(this.label3);
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Controls.Add(this.Activo);
            this.DatosGroupBox.Controls.Add(this.NombreTextBox);
            this.DatosGroupBox.Controls.Add(this.DescripcionTextBox);
            this.DatosGroupBox.Controls.Add(this.PVPNumericUpDown);
            this.DatosGroupBox.Controls.Add(this.IVANumericUpDown);
            this.DatosGroupBox.Controls.Add(this.ValorNumericUpDown);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(604, 91);
            this.DatosGroupBox.TabIndex = 0;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // TieneIVACheckBox
            // 
            this.TieneIVACheckBox.AutoSize = true;
            this.TieneIVACheckBox.Checked = true;
            this.TieneIVACheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TieneIVACheckBox.Location = new System.Drawing.Point(437, 15);
            this.TieneIVACheckBox.Name = "TieneIVACheckBox";
            this.TieneIVACheckBox.Size = new System.Drawing.Size(74, 17);
            this.TieneIVACheckBox.TabIndex = 75;
            this.TieneIVACheckBox.Text = "Cobra IVA";
            this.TieneIVACheckBox.UseVisualStyleBackColor = true;
            this.TieneIVACheckBox.CheckedChanged += new System.EventHandler(this.TieneIVACheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "PVP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rubro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor";
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Checked = true;
            this.Activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Activo.Location = new System.Drawing.Point(19, 65);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(56, 17);
            this.Activo.TabIndex = 50;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(81, 12);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(227, 20);
            this.NombreTextBox.TabIndex = 10;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(81, 38);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(227, 46);
            this.DescripcionTextBox.TabIndex = 20;
            // 
            // PVPNumericUpDown
            // 
            this.PVPNumericUpDown.DecimalPlaces = 3;
            this.PVPNumericUpDown.Location = new System.Drawing.Point(355, 63);
            this.PVPNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PVPNumericUpDown.Name = "PVPNumericUpDown";
            this.PVPNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.PVPNumericUpDown.TabIndex = 40;
            this.PVPNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PVPNumericUpDown.ValueChanged += new System.EventHandler(this.PVPNumericUpDown_ValueChanged);
            // 
            // IVANumericUpDown
            // 
            this.IVANumericUpDown.DecimalPlaces = 3;
            this.IVANumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IVANumericUpDown.Location = new System.Drawing.Point(355, 38);
            this.IVANumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IVANumericUpDown.Name = "IVANumericUpDown";
            this.IVANumericUpDown.ReadOnly = true;
            this.IVANumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.IVANumericUpDown.TabIndex = 72;
            this.IVANumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ValorNumericUpDown
            // 
            this.ValorNumericUpDown.DecimalPlaces = 3;
            this.ValorNumericUpDown.Location = new System.Drawing.Point(355, 13);
            this.ValorNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ValorNumericUpDown.Name = "ValorNumericUpDown";
            this.ValorNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.ValorNumericUpDown.TabIndex = 30;
            this.ValorNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValorNumericUpDown.ValueChanged += new System.EventHandler(this.ValorNumericUpDown_ValueChanged);
            // 
            // RubrosDataGridView
            // 
            this.RubrosDataGridView.AllowUserToAddRows = false;
            this.RubrosDataGridView.AllowUserToDeleteRows = false;
            this.RubrosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RubrosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.RubrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RubrosDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.RubrosDataGridView.Location = new System.Drawing.Point(0, 122);
            this.RubrosDataGridView.Name = "RubrosDataGridView";
            this.RubrosDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RubrosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.RubrosDataGridView.RowHeadersVisible = false;
            this.RubrosDataGridView.RowHeadersWidth = 20;
            this.RubrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RubrosDataGridView.Size = new System.Drawing.Size(604, 226);
            this.RubrosDataGridView.TabIndex = 60;
            this.RubrosDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RubrosDataGridView_CellMouseDoubleClick);
            // 
            // RubroForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 373);
            this.Controls.Add(this.DatosGroupBox);
            this.Controls.Add(this.RubrosDataGridView);
            this.Icon = Properties.Resources.IconoAdministracion;
            this.Name = "RubroForma";
            this.Text = "Rubros";
            this.Load += new System.EventHandler(this.RubroForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.RubrosDataGridView, 0);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PVPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVANumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RubrosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown IVANumericUpDown;
        private System.Windows.Forms.NumericUpDown PVPNumericUpDown;
        private System.Windows.Forms.NumericUpDown ValorNumericUpDown;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.DataGridView RubrosDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Activo;
        private System.Windows.Forms.CheckBox TieneIVACheckBox;
    }
}