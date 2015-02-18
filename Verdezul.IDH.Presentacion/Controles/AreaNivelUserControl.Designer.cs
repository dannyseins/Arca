namespace Verdezul.IDH.Presentacion.Controles
{
    partial class AreaNivelUserControl
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
            this.AreaNivelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.NivelComboBox = new System.Windows.Forms.ComboBox();
            this.AreaNivelLabel = new System.Windows.Forms.Label();
            this.AreaNivelDatos = new Verdezul.IDH.Entidades.AreaDataSet();
            this.MarcaError = new System.Windows.Forms.ErrorProvider(this.components);
            this.AreaNivelFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNivelDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaNivelFlowLayoutPanel
            // 
            this.AreaNivelFlowLayoutPanel.Controls.Add(this.AreaComboBox);
            this.AreaNivelFlowLayoutPanel.Controls.Add(this.NivelComboBox);
            this.AreaNivelFlowLayoutPanel.Location = new System.Drawing.Point(67, 0);
            this.AreaNivelFlowLayoutPanel.Name = "AreaNivelFlowLayoutPanel";
            this.AreaNivelFlowLayoutPanel.Size = new System.Drawing.Size(272, 50);
            this.AreaNivelFlowLayoutPanel.TabIndex = 0;
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.DisplayMember = "Nombre";
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(3, 3);
            this.AreaComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(121, 21);
            this.AreaComboBox.TabIndex = 0;
            this.AreaComboBox.ValueMember = "Id";
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
            // 
            // NivelComboBox
            // 
            this.NivelComboBox.DisplayMember = "Nombre";
            this.NivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelComboBox.FormattingEnabled = true;
            this.NivelComboBox.Location = new System.Drawing.Point(127, 3);
            this.NivelComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.NivelComboBox.Name = "NivelComboBox";
            this.NivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.NivelComboBox.TabIndex = 1;
            this.NivelComboBox.ValueMember = "Id";
            this.NivelComboBox.SelectedIndexChanged += new System.EventHandler(this.NivelComboBox_SelectedIndexChanged);
            // 
            // AreaNivelLabel
            // 
            this.AreaNivelLabel.Location = new System.Drawing.Point(3, 6);
            this.AreaNivelLabel.Name = "AreaNivelLabel";
            this.AreaNivelLabel.Size = new System.Drawing.Size(58, 13);
            this.AreaNivelLabel.TabIndex = 2;
            this.AreaNivelLabel.Text = "Área/Nivel";
            this.AreaNivelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AreaNivelDatos
            // 
            this.AreaNivelDatos.DataSetName = "AreaDataSet";
            this.AreaNivelDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MarcaError
            // 
            this.MarcaError.ContainerControl = this;
            // 
            // AreaNivelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.AreaNivelFlowLayoutPanel);
            this.Controls.Add(this.AreaNivelLabel);
            this.Name = "AreaNivelUserControl";
            this.Size = new System.Drawing.Size(342, 50);
            this.AreaNivelFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AreaNivelDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AreaNivelFlowLayoutPanel;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.ComboBox NivelComboBox;
        private System.Windows.Forms.Label AreaNivelLabel;
        private System.Windows.Forms.ErrorProvider MarcaError;
        private Verdezul.IDH.Entidades.AreaDataSet AreaNivelDatos;
    }
}
