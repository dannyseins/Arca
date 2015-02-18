namespace Verdezul.IDH.Presentacion.Reportes
{
    partial class CierresDeCajaFormaReporte
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
            this.FechasGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.CierresDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.FechasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CierresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FechasGroupBox
            // 
            this.FechasGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FechasGroupBox.Controls.Add(this.HastaLabel);
            this.FechasGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechasGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechasGroupBox.Controls.Add(this.DesdeLabel);
            this.FechasGroupBox.Location = new System.Drawing.Point(12, 28);
            this.FechasGroupBox.Name = "FechasGroupBox";
            this.FechasGroupBox.Size = new System.Drawing.Size(639, 72);
            this.FechasGroupBox.TabIndex = 6;
            this.FechasGroupBox.TabStop = false;
            this.FechasGroupBox.Text = "Rango de Fechas de Cierres de Caja";
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(14, 49);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(35, 13);
            this.HastaLabel.TabIndex = 4;
            this.HastaLabel.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Location = new System.Drawing.Point(58, 45);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastaDateTimePicker.TabIndex = 3;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(58, 19);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdeDateTimePicker.TabIndex = 2;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Location = new System.Drawing.Point(14, 23);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(38, 13);
            this.DesdeLabel.TabIndex = 5;
            this.DesdeLabel.Text = "Desde";
            // 
            // CierresDataGridView
            // 
            this.CierresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CierresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CierresDataGridView.Location = new System.Drawing.Point(0, 108);
            this.CierresDataGridView.Name = "CierresDataGridView";
            this.CierresDataGridView.Size = new System.Drawing.Size(663, 347);
            this.CierresDataGridView.TabIndex = 7;
            this.CierresDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CierresDataGridView_CellMouseDoubleClick);
            this.CierresDataGridView.AllowUserToAddRows = false;
            this.CierresDataGridView.AllowUserToDeleteRows = false;
            this.CierresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CierresDataGridView.ReadOnly = true;
            this.CierresDataGridView.RowHeadersVisible = false;
            this.CierresDataGridView.RowHeadersWidth = 20;
            this.CierresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // CierresDeCajaFormaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.FechasGroupBox);
            this.Controls.Add(this.CierresDataGridView);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.Name = "CierresDeCajaFormaReporte";
            this.Text = "Reporte de Cierres de Caja";
            this.Controls.SetChildIndex(this.CierresDataGridView, 0);
            this.Controls.SetChildIndex(this.FechasGroupBox, 0);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.FechasGroupBox.ResumeLayout(false);
            this.FechasGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CierresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FechasGroupBox;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.DataGridView CierresDataGridView;
    }
}
