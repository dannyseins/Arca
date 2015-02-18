namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class CumpleanosFormaReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.MesCumpleanosComboBox = new System.Windows.Forms.ComboBox();
            this.DatosReporteGroupBox.SuspendLayout();
            this.ReporteSplitContainer.Panel1.SuspendLayout();
            this.ReporteSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosReporteGroupBox
            // 
            this.DatosReporteGroupBox.Controls.Add(this.MesCumpleanosComboBox);
            this.DatosReporteGroupBox.Controls.Add(this.label1);
            this.DatosReporteGroupBox.Size = new System.Drawing.Size(651, 39);
            // 
            // ReporteSplitContainer
            // 
            this.ReporteSplitContainer.IsSplitterFixed = true;
            this.ReporteSplitContainer.Size = new System.Drawing.Size(675, 545);
            this.ReporteSplitContainer.SplitterDistance = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes de Cumpleaños";
            // 
            // MesCumpleanosComboBox
            // 
            this.MesCumpleanosComboBox.DisplayMember = "NombreMes";
            this.MesCumpleanosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesCumpleanosComboBox.FormattingEnabled = true;
            this.MesCumpleanosComboBox.Location = new System.Drawing.Point(124, 13);
            this.MesCumpleanosComboBox.Name = "MesCumpleanosComboBox";
            this.MesCumpleanosComboBox.Size = new System.Drawing.Size(75, 21);
            this.MesCumpleanosComboBox.TabIndex = 74;
            this.MesCumpleanosComboBox.ValueMember = "Fecha";
            // 
            // CumpleanosFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 592);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.IsSplitterFixed = true;
            this.Name = "CumpleanosFormaReporte";
            this.Text = "Cumpleaños de Mes";
            this.Load += new System.EventHandler(this.AulasFormaReporte_Load);
            this.DatosReporteGroupBox.ResumeLayout(false);
            this.DatosReporteGroupBox.PerformLayout();
            this.ReporteSplitContainer.Panel1.ResumeLayout(false);
            this.ReporteSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MesCumpleanosComboBox;

    }
}
