namespace Verdezul.IDH.Presentacion.Sistema
{
    partial class CorreosElectronicosForma
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DireccionesTextBox = new System.Windows.Forms.TextBox();
            this.AlumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.EscogerColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AreaNivelCombos = new Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl();
            this.CursosComboBox = new System.Windows.Forms.ComboBox();
            this.TodosLabel = new System.Windows.Forms.Label();
            this.NoAlumnosLabel = new System.Windows.Forms.Label();
            this.CursosLabel = new System.Windows.Forms.Label();
            this.NoAlumnosRadioButton = new System.Windows.Forms.RadioButton();
            this.CursoRadioButton = new System.Windows.Forms.RadioButton();
            this.AreaNivelRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.CorreosGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosDataGridView)).BeginInit();
            this.CorreosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DireccionesTextBox
            // 
            this.DireccionesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DireccionesTextBox.Location = new System.Drawing.Point(0, 155);
            this.DireccionesTextBox.Multiline = true;
            this.DireccionesTextBox.Name = "DireccionesTextBox";
            this.DireccionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DireccionesTextBox.Size = new System.Drawing.Size(693, 64);
            this.DireccionesTextBox.TabIndex = 6;
            // 
            // AlumnosDataGridView
            // 
            this.AlumnosDataGridView.AllowUserToAddRows = false;
            this.AlumnosDataGridView.AllowUserToDeleteRows = false;
            this.AlumnosDataGridView.AllowUserToResizeRows = false;
            this.AlumnosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EscogerColumn});
            this.AlumnosDataGridView.Location = new System.Drawing.Point(0, 225);
            this.AlumnosDataGridView.Name = "AlumnosDataGridView";
            this.AlumnosDataGridView.RowHeadersVisible = false;
            this.AlumnosDataGridView.Size = new System.Drawing.Size(693, 290);
            this.AlumnosDataGridView.TabIndex = 7;
            this.AlumnosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlumnosDataGridView_CellContentClick);
            // 
            // EscogerColumn
            // 
            this.EscogerColumn.FalseValue = false;
            this.EscogerColumn.Frozen = true;
            this.EscogerColumn.HeaderText = "";
            this.EscogerColumn.IndeterminateValue = false;
            this.EscogerColumn.MinimumWidth = 30;
            this.EscogerColumn.Name = "EscogerColumn";
            this.EscogerColumn.ReadOnly = true;
            this.EscogerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EscogerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EscogerColumn.TrueValue = true;
            this.EscogerColumn.Width = 30;
            // 
            // AreaNivelCombos
            // 
            this.AreaNivelCombos.BackColor = System.Drawing.Color.Transparent;
            this.AreaNivelCombos.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.AreaNivelCombos.Location = new System.Drawing.Point(25, 39);
            this.AreaNivelCombos.Name = "AreaNivelCombos";
            this.AreaNivelCombos.NivelVisible = true;
            this.AreaNivelCombos.PosicionTextoAdicionalArea = 0;
            this.AreaNivelCombos.PosicionTextoAdicionalNivel = 0;
            this.AreaNivelCombos.Size = new System.Drawing.Size(330, 24);
            this.AreaNivelCombos.TabIndex = 8;
            this.AreaNivelCombos.TextoAdicionalArea = "(Todos)";
            this.AreaNivelCombos.TextoAdicionalNivel = "(Todos)";
            this.AreaNivelCombos.UsarTextoAdicionalArea = true;
            this.AreaNivelCombos.UsarTextoAdicionalNivel = true;
            this.AreaNivelCombos.Enter += new System.EventHandler(this.AreaNivelCombos_Enter);
            // 
            // CursosComboBox
            // 
            this.CursosComboBox.DisplayMember = "Nombre";
            this.CursosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursosComboBox.FormattingEnabled = true;
            this.CursosComboBox.Location = new System.Drawing.Point(95, 69);
            this.CursosComboBox.Name = "CursosComboBox";
            this.CursosComboBox.Size = new System.Drawing.Size(248, 21);
            this.CursosComboBox.TabIndex = 9;
            this.CursosComboBox.ValueMember = "Id";
            this.CursosComboBox.SelectedIndexChanged += new System.EventHandler(this.CursosComboBox_SelectedIndexChanged);
            // 
            // TodosLabel
            // 
            this.TodosLabel.AutoSize = true;
            this.TodosLabel.Location = new System.Drawing.Point(26, 19);
            this.TodosLabel.Name = "TodosLabel";
            this.TodosLabel.Size = new System.Drawing.Size(37, 13);
            this.TodosLabel.TabIndex = 10;
            this.TodosLabel.Text = "Todos";
            // 
            // NoAlumnosLabel
            // 
            this.NoAlumnosLabel.AutoSize = true;
            this.NoAlumnosLabel.Location = new System.Drawing.Point(26, 97);
            this.NoAlumnosLabel.Name = "NoAlumnosLabel";
            this.NoAlumnosLabel.Size = new System.Drawing.Size(64, 13);
            this.NoAlumnosLabel.TabIndex = 11;
            this.NoAlumnosLabel.Text = "No Alumnos";
            // 
            // CursosLabel
            // 
            this.CursosLabel.Location = new System.Drawing.Point(26, 71);
            this.CursosLabel.Name = "CursosLabel";
            this.CursosLabel.Size = new System.Drawing.Size(61, 13);
            this.CursosLabel.TabIndex = 16;
            this.CursosLabel.Text = "Cursos";
            // 
            // NoAlumnosRadioButton
            // 
            this.NoAlumnosRadioButton.AutoSize = true;
            this.NoAlumnosRadioButton.Location = new System.Drawing.Point(6, 97);
            this.NoAlumnosRadioButton.Name = "NoAlumnosRadioButton";
            this.NoAlumnosRadioButton.Size = new System.Drawing.Size(14, 13);
            this.NoAlumnosRadioButton.TabIndex = 15;
            this.NoAlumnosRadioButton.UseVisualStyleBackColor = true;
            this.NoAlumnosRadioButton.CheckedChanged += new System.EventHandler(this.NoAlumnosRadioButton_CheckedChanged);
            // 
            // CursoRadioButton
            // 
            this.CursoRadioButton.AutoSize = true;
            this.CursoRadioButton.Location = new System.Drawing.Point(6, 71);
            this.CursoRadioButton.Name = "CursoRadioButton";
            this.CursoRadioButton.Size = new System.Drawing.Size(14, 13);
            this.CursoRadioButton.TabIndex = 14;
            this.CursoRadioButton.UseVisualStyleBackColor = true;
            this.CursoRadioButton.CheckedChanged += new System.EventHandler(this.CursoRadioButton_CheckedChanged);
            // 
            // AreaNivelRadioButton
            // 
            this.AreaNivelRadioButton.AutoSize = true;
            this.AreaNivelRadioButton.Location = new System.Drawing.Point(6, 45);
            this.AreaNivelRadioButton.Name = "AreaNivelRadioButton";
            this.AreaNivelRadioButton.Size = new System.Drawing.Size(14, 13);
            this.AreaNivelRadioButton.TabIndex = 13;
            this.AreaNivelRadioButton.UseVisualStyleBackColor = true;
            this.AreaNivelRadioButton.CheckedChanged += new System.EventHandler(this.AreaNivelRadioButton_CheckedChanged);
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(6, 19);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(14, 13);
            this.TodosRadioButton.TabIndex = 12;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            this.TodosRadioButton.CheckedChanged += new System.EventHandler(this.TodosRadioButton_CheckedChanged);
            // 
            // CorreosGroupBox
            // 
            this.CorreosGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CorreosGroupBox.Controls.Add(this.CursosComboBox);
            this.CorreosGroupBox.Controls.Add(this.NoAlumnosLabel);
            this.CorreosGroupBox.Controls.Add(this.CursosLabel);
            this.CorreosGroupBox.Controls.Add(this.TodosRadioButton);
            this.CorreosGroupBox.Controls.Add(this.AreaNivelCombos);
            this.CorreosGroupBox.Controls.Add(this.TodosLabel);
            this.CorreosGroupBox.Controls.Add(this.NoAlumnosRadioButton);
            this.CorreosGroupBox.Controls.Add(this.AreaNivelRadioButton);
            this.CorreosGroupBox.Controls.Add(this.CursoRadioButton);
            this.CorreosGroupBox.Location = new System.Drawing.Point(12, 31);
            this.CorreosGroupBox.Name = "CorreosGroupBox";
            this.CorreosGroupBox.Size = new System.Drawing.Size(669, 118);
            this.CorreosGroupBox.TabIndex = 13;
            this.CorreosGroupBox.TabStop = false;
            this.CorreosGroupBox.Text = "Tipo de Pertenencia";
            // 
            // CorreosElectronicosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 540);
            this.Controls.Add(this.CorreosGroupBox);
            this.Controls.Add(this.AlumnosDataGridView);
            this.Controls.Add(this.DireccionesTextBox);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "CorreosElectronicosForma";
            this.Text = "Correos Electrónicos";
            this.Load += new System.EventHandler(this.CorreosElectronicosForma_Load);
            this.Controls.SetChildIndex(this.DireccionesTextBox, 0);
            this.Controls.SetChildIndex(this.AlumnosDataGridView, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.CorreosGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosDataGridView)).EndInit();
            this.CorreosGroupBox.ResumeLayout(false);
            this.CorreosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DireccionesTextBox;
        private System.Windows.Forms.DataGridView AlumnosDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EscogerColumn;
        private System.Windows.Forms.Label TodosLabel;
        private Verdezul.IDH.Presentacion.Controles.AreaNivelUserControl AreaNivelCombos;
        private System.Windows.Forms.ComboBox CursosComboBox;
        private System.Windows.Forms.Label NoAlumnosLabel;
        private System.Windows.Forms.RadioButton NoAlumnosRadioButton;
        private System.Windows.Forms.RadioButton CursoRadioButton;
        private System.Windows.Forms.RadioButton AreaNivelRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.Label CursosLabel;
        private System.Windows.Forms.GroupBox CorreosGroupBox;
    }
}