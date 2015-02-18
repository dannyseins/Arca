namespace Verdezul.IDH.Presentacion.Controles
{
    partial class DataGridPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Escogido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagoTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumentoPagoTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estado,
            this.Escogido,
            this.Alumno,
            this.Valor,
            this.NumeroDocumento,
            this.Fecha,
            this.EstadoTexto,
            this.FormaPagoTexto,
            this.TipoDocumentoPagoTexto});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(710, 170);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseClick);
            this.DataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.DataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_CellMouseDoubleClick);
            this.DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Estado.Width = 5;
            // 
            // Escogido
            // 
            this.Escogido.DataPropertyName = "Escogido";
            this.Escogido.HeaderText = "";
            this.Escogido.IndeterminateValue = "False";
            this.Escogido.Name = "Escogido";
            this.Escogido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Escogido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Escogido.ToolTipText = "Marcar/Desmarcar para acción";
            this.Escogido.Width = 20;
            // 
            // Alumno
            // 
            this.Alumno.DataPropertyName = "Alumno";
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 60;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "No. Doc.";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 75;
            // 
            // EstadoTexto
            // 
            this.EstadoTexto.DataPropertyName = "EstadoTexto";
            this.EstadoTexto.HeaderText = "Estado";
            this.EstadoTexto.Name = "EstadoTexto";
            this.EstadoTexto.ReadOnly = true;
            this.EstadoTexto.Width = 70;
            // 
            // FormaPagoTexto
            // 
            this.FormaPagoTexto.DataPropertyName = "FormaPagoTexto";
            this.FormaPagoTexto.HeaderText = "Forma de Pago";
            this.FormaPagoTexto.Name = "FormaPagoTexto";
            this.FormaPagoTexto.ReadOnly = true;
            this.FormaPagoTexto.Width = 70;
            // 
            // TipoDocumentoPagoTexto
            // 
            this.TipoDocumentoPagoTexto.DataPropertyName = "TipoDocumentoPagoTexto";
            this.TipoDocumentoPagoTexto.HeaderText = "Tipo";
            this.TipoDocumentoPagoTexto.Name = "TipoDocumentoPagoTexto";
            this.TipoDocumentoPagoTexto.ReadOnly = true;
            this.TipoDocumentoPagoTexto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoDocumentoPagoTexto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataGridPagos
            // 
            this.Controls.Add(this.DataGridView);
            this.Name = "DataGridPagos";
            this.Size = new System.Drawing.Size(710, 170);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Escogido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagoTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumentoPagoTexto;
    }
}
