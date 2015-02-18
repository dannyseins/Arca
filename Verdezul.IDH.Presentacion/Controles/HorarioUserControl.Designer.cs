namespace Verdezul.IDH.Presentacion.Controles
{
    partial class HorarioUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CursoHorarioFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.HorarioComboBox = new System.Windows.Forms.ComboBox();
            this.CursoHorarioLabel = new System.Windows.Forms.Label();
            this.MarcaError = new System.Windows.Forms.ErrorProvider(this.components);
            this.CursoHorarioFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoHorarioFlowLayoutPanel
            // 
            this.CursoHorarioFlowLayoutPanel.Controls.Add(this.CursoComboBox);
            this.CursoHorarioFlowLayoutPanel.Controls.Add(this.HorarioComboBox);
            this.CursoHorarioFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CursoHorarioFlowLayoutPanel.Location = new System.Drawing.Point(85, 0);
            this.CursoHorarioFlowLayoutPanel.Name = "CursoHorarioFlowLayoutPanel";
            this.CursoHorarioFlowLayoutPanel.Size = new System.Drawing.Size(466, 55);
            this.CursoHorarioFlowLayoutPanel.TabIndex = 0;
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.DisplayMember = "Nombre";
            this.CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CursoComboBox.FormattingEnabled = true;
            this.CursoComboBox.Location = new System.Drawing.Point(3, 3);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(220, 21);
            this.CursoComboBox.TabIndex = 0;
            this.CursoComboBox.ValueMember = "Id";
            this.CursoComboBox.SelectedIndexChanged += new System.EventHandler(this.CursoComboBox_SelectedIndexChanged);
            // 
            // HorarioComboBox
            // 
            this.HorarioComboBox.DisplayMember = "NombreHorario";
            this.HorarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorarioComboBox.FormattingEnabled = true;
            this.HorarioComboBox.Location = new System.Drawing.Point(3, 30);
            this.HorarioComboBox.Name = "HorarioComboBox";
            this.HorarioComboBox.Size = new System.Drawing.Size(220, 21);
            this.HorarioComboBox.TabIndex = 1;
            this.HorarioComboBox.ValueMember = "Id";
            // 
            // CursoHorarioLabel
            // 
            this.CursoHorarioLabel.Location = new System.Drawing.Point(3, 3);
            this.CursoHorarioLabel.Name = "CursoHorarioLabel";
            this.CursoHorarioLabel.Size = new System.Drawing.Size(76, 16);
            this.CursoHorarioLabel.TabIndex = 2;
            this.CursoHorarioLabel.Text = "Curso/Horario";
            this.CursoHorarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarcaError
            // 
            this.MarcaError.ContainerControl = this;
            // 
            // HorarioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CursoHorarioFlowLayoutPanel);
            this.Controls.Add(this.CursoHorarioLabel);
            this.Name = "HorarioUserControl";
            this.Size = new System.Drawing.Size(564, 55);
            this.CursoHorarioFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CursoHorarioFlowLayoutPanel;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.ComboBox HorarioComboBox;
        private System.Windows.Forms.Label CursoHorarioLabel;
        private System.Windows.Forms.ErrorProvider MarcaError;
    }
}
