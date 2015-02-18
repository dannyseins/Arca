namespace Verdezul.IDH.Presentacion.Administracion
{
    partial class AulasForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.AulaLabel = new System.Windows.Forms.Label();
            this.NombreAulaTextBox = new System.Windows.Forms.TextBox();
            this.AulasDataGridView = new System.Windows.Forms.DataGridView();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AulasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.ActivoCheckBox);
            this.DatosGroupBox.Controls.Add(this.AulaLabel);
            this.DatosGroupBox.Controls.Add(this.NombreAulaTextBox);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(389, 43);
            this.DatosGroupBox.TabIndex = 51;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // AulaLabel
            // 
            this.AulaLabel.AutoSize = true;
            this.AulaLabel.Location = new System.Drawing.Point(12, 20);
            this.AulaLabel.Name = "AulaLabel";
            this.AulaLabel.Size = new System.Drawing.Size(83, 13);
            this.AulaLabel.TabIndex = 11;
            this.AulaLabel.Text = "Nombre de Aula";
            // 
            // NombreAulaTextBox
            // 
            this.NombreAulaTextBox.Location = new System.Drawing.Point(118, 16);
            this.NombreAulaTextBox.Name = "NombreAulaTextBox";
            this.NombreAulaTextBox.Size = new System.Drawing.Size(161, 20);
            this.NombreAulaTextBox.TabIndex = 10;
            // 
            // AulasDataGridView
            // 
            this.AulasDataGridView.AllowUserToAddRows = false;
            this.AulasDataGridView.AllowUserToDeleteRows = false;
            this.AulasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AulasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AulasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AulasDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.AulasDataGridView.Location = new System.Drawing.Point(0, 74);
            this.AulasDataGridView.Name = "AulasDataGridView";
            this.AulasDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AulasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.AulasDataGridView.RowHeadersVisible = false;
            this.AulasDataGridView.RowHeadersWidth = 20;
            this.AulasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AulasDataGridView.Size = new System.Drawing.Size(389, 297);
            this.AulasDataGridView.TabIndex = 52;
            this.AulasDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AulasDataGridView_CellMouseDoubleClick);
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Checked = true;
            this.ActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivoCheckBox.Location = new System.Drawing.Point(286, 18);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActivoCheckBox.TabIndex = 12;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AulasForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 396);
            this.Controls.Add(this.AulasDataGridView);
            this.Controls.Add(this.DatosGroupBox);
            this.Icon = Properties.Resources.IconoAdministracion;
            this.Name = "AulasForma";
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.AulaForma_Load);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            this.Controls.SetChildIndex(this.AulasDataGridView, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AulasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.Label AulaLabel;
        private System.Windows.Forms.DataGridView AulasDataGridView;
        private System.Windows.Forms.TextBox NombreAulaTextBox;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
    }
}