namespace Verdezul.IDH.Presentacion.Administracion
{
    partial class AreaNivelForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AreaNivelTabControl = new System.Windows.Forms.TabControl();
            this.AreaTabPage = new System.Windows.Forms.TabPage();
            this.AreasGroupBox = new System.Windows.Forms.GroupBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.NombreAreaTextBox = new System.Windows.Forms.TextBox();
            this.AreasDataGridView = new System.Windows.Forms.DataGridView();
            this.NivelTabPage = new System.Windows.Forms.TabPage();
            this.NivelesGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AreasComboBox = new System.Windows.Forms.ComboBox();
            this.NivelLabel = new System.Windows.Forms.Label();
            this.NombreNivelTextBox = new System.Windows.Forms.TextBox();
            this.NivelesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.AreaNivelTabControl.SuspendLayout();
            this.AreaTabPage.SuspendLayout();
            this.AreasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreasDataGridView)).BeginInit();
            this.NivelTabPage.SuspendLayout();
            this.NivelesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NivelesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaNivelTabControl
            // 
            this.AreaNivelTabControl.Controls.Add(this.AreaTabPage);
            this.AreaNivelTabControl.Controls.Add(this.NivelTabPage);
            this.AreaNivelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreaNivelTabControl.Location = new System.Drawing.Point(0, 25);
            this.AreaNivelTabControl.Name = "AreaNivelTabControl";
            this.AreaNivelTabControl.SelectedIndex = 0;
            this.AreaNivelTabControl.Size = new System.Drawing.Size(389, 349);
            this.AreaNivelTabControl.TabIndex = 52;
            // 
            // AreaTabPage
            // 
            this.AreaTabPage.Controls.Add(this.AreasGroupBox);
            this.AreaTabPage.Controls.Add(this.AreasDataGridView);
            this.AreaTabPage.Location = new System.Drawing.Point(4, 22);
            this.AreaTabPage.Name = "AreaTabPage";
            this.AreaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AreaTabPage.Size = new System.Drawing.Size(381, 323);
            this.AreaTabPage.TabIndex = 0;
            this.AreaTabPage.Text = "Áreas";
            this.AreaTabPage.UseVisualStyleBackColor = true;
            // 
            // AreasGroupBox
            // 
            this.AreasGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AreasGroupBox.Controls.Add(this.AreaLabel);
            this.AreasGroupBox.Controls.Add(this.NombreAreaTextBox);
            this.AreasGroupBox.Location = new System.Drawing.Point(6, 6);
            this.AreasGroupBox.Name = "AreasGroupBox";
            this.AreasGroupBox.Size = new System.Drawing.Size(414, 43);
            this.AreasGroupBox.TabIndex = 51;
            this.AreasGroupBox.TabStop = false;
            this.AreasGroupBox.Text = "Datos";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(12, 20);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(84, 13);
            this.AreaLabel.TabIndex = 11;
            this.AreaLabel.Text = "Nombre de Área";
            // 
            // NombreAreaTextBox
            // 
            this.NombreAreaTextBox.Location = new System.Drawing.Point(118, 16);
            this.NombreAreaTextBox.Name = "NombreAreaTextBox";
            this.NombreAreaTextBox.Size = new System.Drawing.Size(227, 20);
            this.NombreAreaTextBox.TabIndex = 10;
            // 
            // AreasDataGridView
            // 
            this.AreasDataGridView.AllowUserToAddRows = false;
            this.AreasDataGridView.AllowUserToDeleteRows = false;
            this.AreasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AreasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AreasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AreasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AreasDataGridView.Location = new System.Drawing.Point(0, 54);
            this.AreasDataGridView.Name = "AreasDataGridView";
            this.AreasDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AreasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AreasDataGridView.RowHeadersVisible = false;
            this.AreasDataGridView.RowHeadersWidth = 20;
            this.AreasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AreasDataGridView.Size = new System.Drawing.Size(426, 340);
            this.AreasDataGridView.TabIndex = 52;
            this.AreasDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AreasDataGridView_CellMouseDoubleClick);
            // 
            // NivelTabPage
            // 
            this.NivelTabPage.Controls.Add(this.NivelesGroupBox);
            this.NivelTabPage.Controls.Add(this.NivelesDataGridView);
            this.NivelTabPage.Location = new System.Drawing.Point(4, 22);
            this.NivelTabPage.Name = "NivelTabPage";
            this.NivelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NivelTabPage.Size = new System.Drawing.Size(381, 323);
            this.NivelTabPage.TabIndex = 1;
            this.NivelTabPage.Text = "Niveles";
            this.NivelTabPage.UseVisualStyleBackColor = true;
            // 
            // NivelesGroupBox
            // 
            this.NivelesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NivelesGroupBox.Controls.Add(this.label1);
            this.NivelesGroupBox.Controls.Add(this.AreasComboBox);
            this.NivelesGroupBox.Controls.Add(this.NivelLabel);
            this.NivelesGroupBox.Controls.Add(this.NombreNivelTextBox);
            this.NivelesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.NivelesGroupBox.Name = "NivelesGroupBox";
            this.NivelesGroupBox.Size = new System.Drawing.Size(369, 76);
            this.NivelesGroupBox.TabIndex = 52;
            this.NivelesGroupBox.TabStop = false;
            this.NivelesGroupBox.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Área";
            // 
            // AreasComboBox
            // 
            this.AreasComboBox.DisplayMember = "Nombre";
            this.AreasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreasComboBox.FormattingEnabled = true;
            this.AreasComboBox.Location = new System.Drawing.Point(120, 19);
            this.AreasComboBox.Name = "AreasComboBox";
            this.AreasComboBox.Size = new System.Drawing.Size(227, 21);
            this.AreasComboBox.TabIndex = 12;
            this.AreasComboBox.ValueMember = "Id";
            this.AreasComboBox.SelectedIndexChanged += new System.EventHandler(this.AreasComboBox_SelectedIndexChanged);
            // 
            // NivelLabel
            // 
            this.NivelLabel.AutoSize = true;
            this.NivelLabel.Location = new System.Drawing.Point(6, 49);
            this.NivelLabel.Name = "NivelLabel";
            this.NivelLabel.Size = new System.Drawing.Size(86, 13);
            this.NivelLabel.TabIndex = 11;
            this.NivelLabel.Text = "Nombre de Nivel";
            // 
            // NombreNivelTextBox
            // 
            this.NombreNivelTextBox.Location = new System.Drawing.Point(120, 46);
            this.NombreNivelTextBox.Name = "NombreNivelTextBox";
            this.NombreNivelTextBox.Size = new System.Drawing.Size(227, 20);
            this.NombreNivelTextBox.TabIndex = 10;
            // 
            // NivelesDataGridView
            // 
            this.NivelesDataGridView.AllowUserToAddRows = false;
            this.NivelesDataGridView.AllowUserToDeleteRows = false;
            this.NivelesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NivelesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.NivelesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NivelesDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.NivelesDataGridView.Location = new System.Drawing.Point(0, 88);
            this.NivelesDataGridView.Name = "NivelesDataGridView";
            this.NivelesDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NivelesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.NivelesDataGridView.RowHeadersVisible = false;
            this.NivelesDataGridView.RowHeadersWidth = 20;
            this.NivelesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NivelesDataGridView.Size = new System.Drawing.Size(381, 236);
            this.NivelesDataGridView.TabIndex = 53;
            this.NivelesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NivelesDataGridView_CellMouseDoubleClick);
            // 
            // AreaNivelForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 396);
            this.Controls.Add(this.AreaNivelTabControl);
            this.Icon = Properties.Resources.IconoAdministracion;
            this.Name = "AreaNivelForma";
            this.Text = "Áreas/Niveles del IDH";
            this.Load += new System.EventHandler(this.AreaForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.AreaNivelTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.AreaNivelTabControl.ResumeLayout(false);
            this.AreaTabPage.ResumeLayout(false);
            this.AreasGroupBox.ResumeLayout(false);
            this.AreasGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreasDataGridView)).EndInit();
            this.NivelTabPage.ResumeLayout(false);
            this.NivelesGroupBox.ResumeLayout(false);
            this.NivelesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NivelesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AreaNivelTabControl;
        private System.Windows.Forms.TabPage AreaTabPage;
        private System.Windows.Forms.GroupBox AreasGroupBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.DataGridView AreasDataGridView;
        private System.Windows.Forms.TextBox NombreAreaTextBox;
        private System.Windows.Forms.TabPage NivelTabPage;
        private System.Windows.Forms.GroupBox NivelesGroupBox;
        private System.Windows.Forms.Label NivelLabel;
        private System.Windows.Forms.DataGridView NivelesDataGridView;
        private System.Windows.Forms.TextBox NombreNivelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AreasComboBox;
    }
}