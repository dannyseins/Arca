namespace Verdezul.IDH.Presentacion.Controles
{
    partial class DetallePagoControl
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.DetallePagosDataGrid = new System.Windows.Forms.DataGridView();
            this.DetallePagosLabel = new System.Windows.Forms.Label();
            this.MoverPanel = new System.Windows.Forms.Panel();
            this.SalirPanel = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAbono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePagosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox.Controls.Add(this.DetallePagosDataGrid);
            this.GroupBox.Location = new System.Drawing.Point(3, 20);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(574, 217);
            this.GroupBox.TabIndex = 3;
            this.GroupBox.TabStop = false;
            // 
            // DetallePagosDataGrid
            // 
            this.DetallePagosDataGrid.AllowUserToAddRows = false;
            this.DetallePagosDataGrid.AllowUserToDeleteRows = false;
            this.DetallePagosDataGrid.AllowUserToResizeRows = false;
            this.DetallePagosDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DetallePagosDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DetallePagosDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallePagosDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallePagosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cantidad,
            this.Descripcion,
            this.Valor,
            this.IVA,
            this.Descuento,
            this.PVP,
            this.TipoAbono});
            this.DetallePagosDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallePagosDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DetallePagosDataGrid.Location = new System.Drawing.Point(3, 16);
            this.DetallePagosDataGrid.MultiSelect = false;
            this.DetallePagosDataGrid.Name = "DetallePagosDataGrid";
            this.DetallePagosDataGrid.ReadOnly = true;
            this.DetallePagosDataGrid.RowHeadersVisible = false;
            this.DetallePagosDataGrid.Size = new System.Drawing.Size(568, 198);
            this.DetallePagosDataGrid.TabIndex = 0;
            this.DetallePagosDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            // 
            // DetallePagosLabel
            // 
            this.DetallePagosLabel.AutoSize = true;
            this.DetallePagosLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetallePagosLabel.Location = new System.Drawing.Point(27, 4);
            this.DetallePagosLabel.Name = "DetallePagosLabel";
            this.DetallePagosLabel.Size = new System.Drawing.Size(83, 13);
            this.DetallePagosLabel.TabIndex = 5;
            this.DetallePagosLabel.Text = "Detalle de Pago";
            // 
            // MoverPanel
            // 
            this.MoverPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MoverPanel.BackgroundImage = global::Verdezul.IDH.Presentacion.Imagenes.Mover;
            this.MoverPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoverPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoverPanel.Location = new System.Drawing.Point(0, 0);
            this.MoverPanel.Name = "MoverPanel";
            this.MoverPanel.Size = new System.Drawing.Size(20, 20);
            this.MoverPanel.TabIndex = 6;
            this.MoverPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverPanel_MouseMove);
            // 
            // SalirPanel
            // 
            this.SalirPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalirPanel.BackgroundImage = global::Verdezul.IDH.Presentacion.Imagenes.Salir;
            this.SalirPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SalirPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirPanel.Location = new System.Drawing.Point(560, 0);
            this.SalirPanel.Name = "SalirPanel";
            this.SalirPanel.Size = new System.Drawing.Size(20, 20);
            this.SalirPanel.TabIndex = 7;
            this.SalirPanel.Click += new System.EventHandler(this.SalirPanel_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 55;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 55;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle4;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Width = 55;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle5;
            this.Descuento.HeaderText = "Desc. (%)";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 55;
            // 
            // PVP
            // 
            this.PVP.DataPropertyName = "PVP";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PVP.DefaultCellStyle = dataGridViewCellStyle6;
            this.PVP.HeaderText = "Valor";
            this.PVP.Name = "PVP";
            this.PVP.ReadOnly = true;
            this.PVP.Width = 55;
            // 
            // TipoAbono
            // 
            this.TipoAbono.DataPropertyName = "TipoAbono";
            this.TipoAbono.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TipoAbono.HeaderText = "Abono";
            this.TipoAbono.Name = "TipoAbono";
            this.TipoAbono.ReadOnly = true;
            this.TipoAbono.Width = 70;
            // 
            // DetallePagoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.SalirPanel);
            this.Controls.Add(this.MoverPanel);
            this.Controls.Add(this.DetallePagosLabel);
            this.Controls.Add(this.GroupBox);
            this.Name = "DetallePagoControl";
            this.Size = new System.Drawing.Size(580, 240);
            this.Load += new System.EventHandler(this.DetallePagoControl_Load);
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetallePagosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label DetallePagosLabel;
        private System.Windows.Forms.Panel MoverPanel;
        private System.Windows.Forms.DataGridView DetallePagosDataGrid;
        private System.Windows.Forms.Panel SalirPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVP;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoAbono;

    }
}