namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class ReimpresionFacturaFormaReporte
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
            this.IdPagoTextBox = new System.Windows.Forms.TextBox();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.NumeroDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.IdPagoRadioButton = new System.Windows.Forms.RadioButton();
            this.NumeroDocumentoRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdPagoTextBox
            // 
            this.IdPagoTextBox.Location = new System.Drawing.Point(140, 22);
            this.IdPagoTextBox.Name = "IdPagoTextBox";
            this.IdPagoTextBox.Size = new System.Drawing.Size(133, 20);
            this.IdPagoTextBox.TabIndex = 1;
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosGroupBox.Controls.Add(this.NumeroDocumentoTextBox);
            this.DatosGroupBox.Controls.Add(this.IdPagoTextBox);
            this.DatosGroupBox.Controls.Add(this.IdPagoRadioButton);
            this.DatosGroupBox.Controls.Add(this.NumeroDocumentoRadioButton);
            this.DatosGroupBox.Location = new System.Drawing.Point(12, 28);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(304, 83);
            this.DatosGroupBox.TabIndex = 3;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos de Pago";
            // 
            // NumeroDocumentoTextBox
            // 
            this.NumeroDocumentoTextBox.Location = new System.Drawing.Point(140, 52);
            this.NumeroDocumentoTextBox.Name = "NumeroDocumentoTextBox";
            this.NumeroDocumentoTextBox.Size = new System.Drawing.Size(133, 20);
            this.NumeroDocumentoTextBox.TabIndex = 3;
            // 
            // IdPagoRadioButton
            // 
            this.IdPagoRadioButton.Checked = true;
            this.IdPagoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.IdPagoRadioButton.Name = "IdPagoRadioButton";
            this.IdPagoRadioButton.Size = new System.Drawing.Size(128, 24);
            this.IdPagoRadioButton.TabIndex = 5;
            this.IdPagoRadioButton.TabStop = true;
            this.IdPagoRadioButton.Text = "Identificador de Pago";
            // 
            // NumeroDocumentoRadioButton
            // 
            this.NumeroDocumentoRadioButton.Location = new System.Drawing.Point(6, 49);
            this.NumeroDocumentoRadioButton.Name = "NumeroDocumentoRadioButton";
            this.NumeroDocumentoRadioButton.Size = new System.Drawing.Size(128, 24);
            this.NumeroDocumentoRadioButton.TabIndex = 6;
            this.NumeroDocumentoRadioButton.Text = "Numero Documento";
            // 
            // ReimpresionFacturaFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(328, 136);
            this.Controls.Add(this.DatosGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.MaximizeBox = false;
            this.Name = "ReimpresionFacturaFormaReporte";
            this.Text = "Revisión de Documentos de Pago";
            this.Load += new System.EventHandler(this.ReimpresionFacturaFormaReporte_Load);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.TextBox IdPagoTextBox;
        private System.Windows.Forms.TextBox NumeroDocumentoTextBox;
        private System.Windows.Forms.RadioButton IdPagoRadioButton;
        private System.Windows.Forms.RadioButton NumeroDocumentoRadioButton;

    }
}
