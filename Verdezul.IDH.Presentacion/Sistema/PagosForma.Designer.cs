using System.Windows.Forms;
using Verdezul.IDH.Presentacion.Controles;

namespace Verdezul.IDH.Presentacion.Sistema
{
    public partial class PagosForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosForma));
            this.DetallePagosDataGrid = new System.Windows.Forms.DataGridView();
            this.CantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVAColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAbonoTextoColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Total3 = new System.Windows.Forms.Label();
            this.Total2 = new System.Windows.Forms.Label();
            this.Total1 = new System.Windows.Forms.Label();
            this.Total4 = new System.Windows.Forms.Label();
            this.TotalPagarTextBox = new System.Windows.Forms.TextBox();
            this.TotalIVATextBox = new System.Windows.Forms.TextBox();
            this.TotalValorTextBox = new System.Windows.Forms.TextBox();
            this.TotalItemsTextBox = new System.Windows.Forms.TextBox();
            this.AlumnoGrouBox = new System.Windows.Forms.GroupBox();
            this.AlumnoPago = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
            this.AlumnoLabel = new System.Windows.Forms.Label();
            this.Recibo = new System.Windows.Forms.RadioButton();
            this.ConNotaDeVenta = new System.Windows.Forms.RadioButton();
            this.ConFactura = new System.Windows.Forms.RadioButton();
            this.PagoTabControl = new System.Windows.Forms.TabControl();
            this.RegistroTabPage = new System.Windows.Forms.TabPage();
            this.DetallePagoGroupBox = new System.Windows.Forms.GroupBox();
            this.AbonoLabel = new System.Windows.Forms.Label();
            this.TipoAbonoComboBox = new System.Windows.Forms.ComboBox();
            this.MotivoLabel = new System.Windows.Forms.Label();
            this.ValorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MotivoPagoComboBox = new System.Windows.Forms.ComboBox();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DescuentoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BorrarDetalleButton = new System.Windows.Forms.Button();
            this.IVANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.PVPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValorLabel = new System.Windows.Forms.Label();
            this.DescuentoLabel = new System.Windows.Forms.Label();
            this.IVALabel = new System.Windows.Forms.Label();
            this.PVPLabel = new System.Windows.Forms.Label();
            this.MensualidadCursoPanel = new System.Windows.Forms.Panel();
            this.CursoLabel = new System.Windows.Forms.Label();
            this.HorarioCursoComboBox = new System.Windows.Forms.ComboBox();
            this.MesCursoComboBox = new System.Windows.Forms.ComboBox();
            this.AnoCursoComboBox = new System.Windows.Forms.ComboBox();
            this.MensualidadNivelPanel = new System.Windows.Forms.Panel();
            this.AnoNivelComboBox = new System.Windows.Forms.ComboBox();
            this.AreaNivelLabel = new System.Windows.Forms.Label();
            this.HorarioNivelComboBox = new System.Windows.Forms.ComboBox();
            this.MesNivelComboBox = new System.Windows.Forms.ComboBox();
            this.ConferenciaPanel = new System.Windows.Forms.Panel();
            this.ConferenciaLabel = new System.Windows.Forms.Label();
            this.ConferenciaComboBox = new System.Windows.Forms.ComboBox();
            this.RubroPanel = new System.Windows.Forms.Panel();
            this.RubroLabel = new System.Windows.Forms.Label();
            this.RubroComboBox = new System.Windows.Forms.ComboBox();
            this.Logotipo = new System.Windows.Forms.PictureBox();
            this.PagosRealizadosTabPage = new System.Windows.Forms.TabPage();
            this.DetallePagoVentana = new Verdezul.IDH.Presentacion.Controles.DetallePagoControl();
            this.TotalGroupBox = new System.Windows.Forms.GroupBox();
            this.ValorTotalLabel = new System.Windows.Forms.Label();
            this.TextoValorLabel = new System.Windows.Forms.Label();
            this.PagosRealizadosDataGrid = new Verdezul.IDH.Presentacion.Controles.DataGridPagos();
            this.estadoToolStripDropDown = new System.Windows.Forms.ToolStripDropDown();
            this.ingresadoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.facturadoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.anuladoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePagosDataGrid)).BeginInit();
            this.AlumnoGrouBox.SuspendLayout();
            this.PagoTabControl.SuspendLayout();
            this.RegistroTabPage.SuspendLayout();
            this.DetallePagoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVANumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PVPNumericUpDown)).BeginInit();
            this.MensualidadCursoPanel.SuspendLayout();
            this.MensualidadNivelPanel.SuspendLayout();
            this.ConferenciaPanel.SuspendLayout();
            this.RubroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo)).BeginInit();
            this.PagosRealizadosTabPage.SuspendLayout();
            this.TotalGroupBox.SuspendLayout();
            this.estadoToolStripDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetallePagosDataGrid
            // 
            this.DetallePagosDataGrid.AllowUserToAddRows = false;
            this.DetallePagosDataGrid.AllowUserToOrderColumns = true;
            this.DetallePagosDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallePagosDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetallePagosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CantidadColumn,
            this.DescripcionColumn,
            this.ValorColumn,
            this.IVAColumn,
            this.DescuentoColumn,
            this.PVPColumn,
            this.TipoAbonoTextoColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetallePagosDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetallePagosDataGrid.Location = new System.Drawing.Point(2, 75);
            this.DetallePagosDataGrid.Name = "DetallePagosDataGrid";
            this.DetallePagosDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetallePagosDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetallePagosDataGrid.Size = new System.Drawing.Size(875, 287);
            this.DetallePagosDataGrid.TabIndex = 40;
            this.DetallePagosDataGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.PagosDataGrid_UserDeletedRow);
            // 
            // CantidadColumn
            // 
            this.CantidadColumn.DataPropertyName = "Cantidad";
            this.CantidadColumn.HeaderText = "Cantidad";
            this.CantidadColumn.Name = "CantidadColumn";
            this.CantidadColumn.ReadOnly = true;
            this.CantidadColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CantidadColumn.Width = 60;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.DataPropertyName = "Descripcion";
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            this.DescripcionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescripcionColumn.Width = 320;
            // 
            // ValorColumn
            // 
            this.ValorColumn.DataPropertyName = "Valor";
            this.ValorColumn.HeaderText = "Val. Unit.";
            this.ValorColumn.Name = "ValorColumn";
            this.ValorColumn.ReadOnly = true;
            this.ValorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValorColumn.Width = 60;
            // 
            // IVAColumn
            // 
            this.IVAColumn.DataPropertyName = "IVA";
            this.IVAColumn.HeaderText = "IVA";
            this.IVAColumn.Name = "IVAColumn";
            this.IVAColumn.ReadOnly = true;
            this.IVAColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IVAColumn.Width = 60;
            // 
            // DescuentoColumn
            // 
            this.DescuentoColumn.DataPropertyName = "Descuento";
            this.DescuentoColumn.HeaderText = "Desc. (%)";
            this.DescuentoColumn.Name = "DescuentoColumn";
            this.DescuentoColumn.ReadOnly = true;
            this.DescuentoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescuentoColumn.Width = 60;
            // 
            // PVPColumn
            // 
            this.PVPColumn.DataPropertyName = "PVP";
            this.PVPColumn.HeaderText = "PVP";
            this.PVPColumn.Name = "PVPColumn";
            this.PVPColumn.ReadOnly = true;
            this.PVPColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PVPColumn.Width = 60;
            // 
            // TipoAbonoTextoColumn
            // 
            this.TipoAbonoTextoColumn.DataPropertyName = "TipoAbono";
            this.TipoAbonoTextoColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TipoAbonoTextoColumn.HeaderText = "Abono";
            this.TipoAbonoTextoColumn.Name = "TipoAbonoTextoColumn";
            this.TipoAbonoTextoColumn.ReadOnly = true;
            this.TipoAbonoTextoColumn.Width = 70;
            // 
            // Total3
            // 
            this.Total3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total3.Location = new System.Drawing.Point(593, 375);
            this.Total3.Name = "Total3";
            this.Total3.Size = new System.Drawing.Size(27, 14);
            this.Total3.TabIndex = 18;
            this.Total3.Text = "IVA";
            // 
            // Total2
            // 
            this.Total2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total2.Location = new System.Drawing.Point(467, 375);
            this.Total2.Name = "Total2";
            this.Total2.Size = new System.Drawing.Size(35, 14);
            this.Total2.TabIndex = 17;
            this.Total2.Text = "Valor";
            // 
            // Total1
            // 
            this.Total1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total1.Location = new System.Drawing.Point(347, 375);
            this.Total1.Name = "Total1";
            this.Total1.Size = new System.Drawing.Size(37, 14);
            this.Total1.TabIndex = 16;
            this.Total1.Text = "Items";
            // 
            // Total4
            // 
            this.Total4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total4.Location = new System.Drawing.Point(718, 375);
            this.Total4.Name = "Total4";
            this.Total4.Size = new System.Drawing.Size(72, 14);
            this.Total4.TabIndex = 15;
            this.Total4.Text = "Total a Pagar";
            // 
            // TotalPagarTextBox
            // 
            this.TotalPagarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPagarTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalPagarTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagarTextBox.ForeColor = System.Drawing.Color.Red;
            this.TotalPagarTextBox.Location = new System.Drawing.Point(795, 366);
            this.TotalPagarTextBox.Name = "TotalPagarTextBox";
            this.TotalPagarTextBox.ReadOnly = true;
            this.TotalPagarTextBox.Size = new System.Drawing.Size(81, 26);
            this.TotalPagarTextBox.TabIndex = 14;
            this.TotalPagarTextBox.TabStop = false;
            this.TotalPagarTextBox.Text = "0";
            this.TotalPagarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalIVATextBox
            // 
            this.TotalIVATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalIVATextBox.Location = new System.Drawing.Point(627, 372);
            this.TotalIVATextBox.Name = "TotalIVATextBox";
            this.TotalIVATextBox.ReadOnly = true;
            this.TotalIVATextBox.Size = new System.Drawing.Size(63, 20);
            this.TotalIVATextBox.TabIndex = 13;
            this.TotalIVATextBox.TabStop = false;
            this.TotalIVATextBox.Text = "0";
            this.TotalIVATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalValorTextBox
            // 
            this.TotalValorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalValorTextBox.Location = new System.Drawing.Point(508, 372);
            this.TotalValorTextBox.Name = "TotalValorTextBox";
            this.TotalValorTextBox.ReadOnly = true;
            this.TotalValorTextBox.Size = new System.Drawing.Size(63, 20);
            this.TotalValorTextBox.TabIndex = 12;
            this.TotalValorTextBox.TabStop = false;
            this.TotalValorTextBox.Text = "0";
            this.TotalValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalItemsTextBox
            // 
            this.TotalItemsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalItemsTextBox.Location = new System.Drawing.Point(390, 372);
            this.TotalItemsTextBox.Name = "TotalItemsTextBox";
            this.TotalItemsTextBox.ReadOnly = true;
            this.TotalItemsTextBox.Size = new System.Drawing.Size(63, 20);
            this.TotalItemsTextBox.TabIndex = 11;
            this.TotalItemsTextBox.TabStop = false;
            this.TotalItemsTextBox.Text = "0";
            this.TotalItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AlumnoGrouBox
            // 
            this.AlumnoGrouBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AlumnoGrouBox.Controls.Add(this.AlumnoPago);
            this.AlumnoGrouBox.Controls.Add(this.AlumnoLabel);
            this.AlumnoGrouBox.Location = new System.Drawing.Point(6, 6);
            this.AlumnoGrouBox.Name = "AlumnoGrouBox";
            this.AlumnoGrouBox.Size = new System.Drawing.Size(820, 44);
            this.AlumnoGrouBox.TabIndex = 15;
            this.AlumnoGrouBox.TabStop = false;
            this.AlumnoGrouBox.Text = "Alumno";
            // 
            // AlumnoPago
            // 
            this.AlumnoPago.Apellido = "";
            this.AlumnoPago.BuscarVisible = false;
            this.AlumnoPago.Location = new System.Drawing.Point(74, 14);
            this.AlumnoPago.MinimumSize = new System.Drawing.Size(450, 25);
            this.AlumnoPago.Name = "AlumnoPago";
            this.AlumnoPago.Nombre = "";
            this.AlumnoPago.PermitirCrearAlumno = true;
            this.AlumnoPago.Size = new System.Drawing.Size(552, 25);
            this.AlumnoPago.TabIndex = 0;
            this.AlumnoPago.AlumnoEncontrado += new System.EventHandler(this.AlumnoPago_AlumnoEncontrado);
            // 
            // AlumnoLabel
            // 
            this.AlumnoLabel.Location = new System.Drawing.Point(34, 17);
            this.AlumnoLabel.Name = "AlumnoLabel";
            this.AlumnoLabel.Size = new System.Drawing.Size(42, 23);
            this.AlumnoLabel.TabIndex = 3;
            this.AlumnoLabel.Text = "Escoja";
            // 
            // Recibo
            // 
            this.Recibo.AutoSize = true;
            this.Recibo.Location = new System.Drawing.Point(598, 14);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(59, 17);
            this.Recibo.TabIndex = 54;
            this.Recibo.Text = "Recibo";
            this.Recibo.UseVisualStyleBackColor = true;
            // 
            // ConNotaDeVenta
            // 
            this.ConNotaDeVenta.AutoSize = true;
            this.ConNotaDeVenta.Location = new System.Drawing.Point(498, 14);
            this.ConNotaDeVenta.Name = "ConNotaDeVenta";
            this.ConNotaDeVenta.Size = new System.Drawing.Size(94, 17);
            this.ConNotaDeVenta.TabIndex = 53;
            this.ConNotaDeVenta.Text = "Nota de Venta";
            this.ConNotaDeVenta.UseVisualStyleBackColor = true;
            // 
            // ConFactura
            // 
            this.ConFactura.AutoSize = true;
            this.ConFactura.Checked = true;
            this.ConFactura.Location = new System.Drawing.Point(431, 14);
            this.ConFactura.Name = "ConFactura";
            this.ConFactura.Size = new System.Drawing.Size(61, 17);
            this.ConFactura.TabIndex = 52;
            this.ConFactura.TabStop = true;
            this.ConFactura.Text = "Factura";
            this.ConFactura.UseVisualStyleBackColor = true;
            // 
            // PagoTabControl
            // 
            this.PagoTabControl.Controls.Add(this.RegistroTabPage);
            this.PagoTabControl.Controls.Add(this.PagosRealizadosTabPage);
            this.PagoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagoTabControl.Location = new System.Drawing.Point(0, 25);
            this.PagoTabControl.Name = "PagoTabControl";
            this.PagoTabControl.SelectedIndex = 0;
            this.PagoTabControl.Size = new System.Drawing.Size(905, 486);
            this.PagoTabControl.TabIndex = 16;
            this.PagoTabControl.SelectedIndexChanged += new System.EventHandler(this.PagoTabControl_SelectedIndexChanged);
            // 
            // RegistroTabPage
            // 
            this.RegistroTabPage.Controls.Add(this.DetallePagoGroupBox);
            this.RegistroTabPage.Controls.Add(this.Logotipo);
            this.RegistroTabPage.Controls.Add(this.AlumnoGrouBox);
            this.RegistroTabPage.Location = new System.Drawing.Point(4, 22);
            this.RegistroTabPage.Name = "RegistroTabPage";
            this.RegistroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroTabPage.Size = new System.Drawing.Size(897, 460);
            this.RegistroTabPage.TabIndex = 0;
            this.RegistroTabPage.Text = "Registro de Pagos";
            this.RegistroTabPage.UseVisualStyleBackColor = true;
            // 
            // DetallePagoGroupBox
            // 
            this.DetallePagoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallePagoGroupBox.Controls.Add(this.AbonoLabel);
            this.DetallePagoGroupBox.Controls.Add(this.Recibo);
            this.DetallePagoGroupBox.Controls.Add(this.TipoAbonoComboBox);
            this.DetallePagoGroupBox.Controls.Add(this.ConNotaDeVenta);
            this.DetallePagoGroupBox.Controls.Add(this.Total3);
            this.DetallePagoGroupBox.Controls.Add(this.ConFactura);
            this.DetallePagoGroupBox.Controls.Add(this.MotivoLabel);
            this.DetallePagoGroupBox.Controls.Add(this.Total2);
            this.DetallePagoGroupBox.Controls.Add(this.Total1);
            this.DetallePagoGroupBox.Controls.Add(this.ValorNumericUpDown);
            this.DetallePagoGroupBox.Controls.Add(this.Total4);
            this.DetallePagoGroupBox.Controls.Add(this.TotalPagarTextBox);
            this.DetallePagoGroupBox.Controls.Add(this.MotivoPagoComboBox);
            this.DetallePagoGroupBox.Controls.Add(this.TotalIVATextBox);
            this.DetallePagoGroupBox.Controls.Add(this.TotalValorTextBox);
            this.DetallePagoGroupBox.Controls.Add(this.CantidadNumericUpDown);
            this.DetallePagoGroupBox.Controls.Add(this.TotalItemsTextBox);
            this.DetallePagoGroupBox.Controls.Add(this.AgregarButton);
            this.DetallePagoGroupBox.Controls.Add(this.DetallePagosDataGrid);
            this.DetallePagoGroupBox.Controls.Add(this.DescuentoNumericUpDown);
            this.DetallePagoGroupBox.Controls.Add(this.BorrarDetalleButton);
            this.DetallePagoGroupBox.Controls.Add(this.IVANumericUpDown);
            this.DetallePagoGroupBox.Controls.Add(this.CantidadLabel);
            this.DetallePagoGroupBox.Controls.Add(this.PVPNumericUpDown);
            this.DetallePagoGroupBox.Controls.Add(this.ValorLabel);
            this.DetallePagoGroupBox.Controls.Add(this.DescuentoLabel);
            this.DetallePagoGroupBox.Controls.Add(this.IVALabel);
            this.DetallePagoGroupBox.Controls.Add(this.PVPLabel);
            this.DetallePagoGroupBox.Controls.Add(this.MensualidadCursoPanel);
            this.DetallePagoGroupBox.Controls.Add(this.MensualidadNivelPanel);
            this.DetallePagoGroupBox.Controls.Add(this.ConferenciaPanel);
            this.DetallePagoGroupBox.Controls.Add(this.RubroPanel);
            this.DetallePagoGroupBox.Enabled = false;
            this.DetallePagoGroupBox.Location = new System.Drawing.Point(6, 56);
            this.DetallePagoGroupBox.Name = "DetallePagoGroupBox";
            this.DetallePagoGroupBox.Size = new System.Drawing.Size(883, 398);
            this.DetallePagoGroupBox.TabIndex = 93;
            this.DetallePagoGroupBox.TabStop = false;
            this.DetallePagoGroupBox.Text = "Detalle de Pago";
            // 
            // AbonoLabel
            // 
            this.AbonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbonoLabel.Location = new System.Drawing.Point(470, 33);
            this.AbonoLabel.Name = "AbonoLabel";
            this.AbonoLabel.Size = new System.Drawing.Size(80, 13);
            this.AbonoLabel.TabIndex = 94;
            this.AbonoLabel.Text = "Abono";
            this.AbonoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TipoAbonoComboBox
            // 
            this.TipoAbonoComboBox.DisplayMember = "Texto";
            this.TipoAbonoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAbonoComboBox.FormattingEnabled = true;
            this.TipoAbonoComboBox.Location = new System.Drawing.Point(470, 47);
            this.TipoAbonoComboBox.Name = "TipoAbonoComboBox";
            this.TipoAbonoComboBox.Size = new System.Drawing.Size(80, 21);
            this.TipoAbonoComboBox.TabIndex = 93;
            this.TipoAbonoComboBox.ValueMember = "Valor";
            this.TipoAbonoComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoAbonoComboBox_SelectedIndexChanged);
            // 
            // MotivoLabel
            // 
            this.MotivoLabel.Location = new System.Drawing.Point(35, 16);
            this.MotivoLabel.Name = "MotivoLabel";
            this.MotivoLabel.Size = new System.Drawing.Size(41, 18);
            this.MotivoLabel.TabIndex = 76;
            this.MotivoLabel.Text = "Motivo";
            // 
            // ValorNumericUpDown
            // 
            this.ValorNumericUpDown.DecimalPlaces = 3;
            this.ValorNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ValorNumericUpDown.Location = new System.Drawing.Point(611, 47);
            this.ValorNumericUpDown.Name = "ValorNumericUpDown";
            this.ValorNumericUpDown.ReadOnly = true;
            this.ValorNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.ValorNumericUpDown.TabIndex = 77;
            this.ValorNumericUpDown.ValueChanged += new System.EventHandler(this.ValorNumericUpDown_ValueChanged);
            // 
            // MotivoPagoComboBox
            // 
            this.MotivoPagoComboBox.DisplayMember = "Texto";
            this.MotivoPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotivoPagoComboBox.FormattingEnabled = true;
            this.MotivoPagoComboBox.Location = new System.Drawing.Point(80, 13);
            this.MotivoPagoComboBox.Name = "MotivoPagoComboBox";
            this.MotivoPagoComboBox.Size = new System.Drawing.Size(170, 21);
            this.MotivoPagoComboBox.TabIndex = 79;
            this.MotivoPagoComboBox.ValueMember = "Valor";
            this.MotivoPagoComboBox.SelectedValueChanged += new System.EventHandler(this.MotivoPagoComboBox_SelectedValueChanged);
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(555, 47);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.CantidadNumericUpDown.TabIndex = 81;
            this.CantidadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackgroundImage = global::Verdezul.IDH.Presentacion.Imagenes.Mas;
            this.AgregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AgregarButton.Location = new System.Drawing.Point(264, 12);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(25, 23);
            this.AgregarButton.TabIndex = 80;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DescuentoNumericUpDown
            // 
            this.DescuentoNumericUpDown.Location = new System.Drawing.Point(723, 47);
            this.DescuentoNumericUpDown.Name = "DescuentoNumericUpDown";
            this.DescuentoNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.DescuentoNumericUpDown.TabIndex = 82;
            this.DescuentoNumericUpDown.ValueChanged += new System.EventHandler(this.DescuentoNumericUpDown_ValueChanged);
            // 
            // BorrarDetalleButton
            // 
            this.BorrarDetalleButton.BackgroundImage = global::Verdezul.IDH.Presentacion.Imagenes.Menos;
            this.BorrarDetalleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorrarDetalleButton.Location = new System.Drawing.Point(295, 12);
            this.BorrarDetalleButton.Name = "BorrarDetalleButton";
            this.BorrarDetalleButton.Size = new System.Drawing.Size(25, 23);
            this.BorrarDetalleButton.TabIndex = 78;
            this.BorrarDetalleButton.UseVisualStyleBackColor = true;
            this.BorrarDetalleButton.Click += new System.EventHandler(this.BorrarDetalleButton_Click);
            // 
            // IVANumericUpDown
            // 
            this.IVANumericUpDown.DecimalPlaces = 3;
            this.IVANumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IVANumericUpDown.Location = new System.Drawing.Point(667, 47);
            this.IVANumericUpDown.Name = "IVANumericUpDown";
            this.IVANumericUpDown.ReadOnly = true;
            this.IVANumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.IVANumericUpDown.TabIndex = 83;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(555, 33);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(50, 13);
            this.CantidadLabel.TabIndex = 89;
            this.CantidadLabel.Text = "Cantidad";
            this.CantidadLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PVPNumericUpDown
            // 
            this.PVPNumericUpDown.DecimalPlaces = 3;
            this.PVPNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PVPNumericUpDown.Location = new System.Drawing.Point(779, 47);
            this.PVPNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PVPNumericUpDown.Name = "PVPNumericUpDown";
            this.PVPNumericUpDown.ReadOnly = true;
            this.PVPNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.PVPNumericUpDown.TabIndex = 84;
            // 
            // ValorLabel
            // 
            this.ValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorLabel.Location = new System.Drawing.Point(611, 33);
            this.ValorLabel.Name = "ValorLabel";
            this.ValorLabel.Size = new System.Drawing.Size(50, 13);
            this.ValorLabel.TabIndex = 88;
            this.ValorLabel.Text = "Valor";
            this.ValorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DescuentoLabel
            // 
            this.DescuentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoLabel.Location = new System.Drawing.Point(723, 33);
            this.DescuentoLabel.Name = "DescuentoLabel";
            this.DescuentoLabel.Size = new System.Drawing.Size(50, 13);
            this.DescuentoLabel.TabIndex = 85;
            this.DescuentoLabel.Text = "Desc(%)";
            this.DescuentoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IVALabel
            // 
            this.IVALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVALabel.Location = new System.Drawing.Point(667, 33);
            this.IVALabel.Name = "IVALabel";
            this.IVALabel.Size = new System.Drawing.Size(50, 13);
            this.IVALabel.TabIndex = 87;
            this.IVALabel.Text = "IVA";
            this.IVALabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PVPLabel
            // 
            this.PVPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVPLabel.Location = new System.Drawing.Point(779, 33);
            this.PVPLabel.Name = "PVPLabel";
            this.PVPLabel.Size = new System.Drawing.Size(50, 13);
            this.PVPLabel.TabIndex = 86;
            this.PVPLabel.Text = "PVP";
            this.PVPLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MensualidadCursoPanel
            // 
            this.MensualidadCursoPanel.Controls.Add(this.CursoLabel);
            this.MensualidadCursoPanel.Controls.Add(this.HorarioCursoComboBox);
            this.MensualidadCursoPanel.Controls.Add(this.MesCursoComboBox);
            this.MensualidadCursoPanel.Controls.Add(this.AnoCursoComboBox);
            this.MensualidadCursoPanel.Location = new System.Drawing.Point(6, 44);
            this.MensualidadCursoPanel.Name = "MensualidadCursoPanel";
            this.MensualidadCursoPanel.Size = new System.Drawing.Size(458, 25);
            this.MensualidadCursoPanel.TabIndex = 91;
            // 
            // CursoLabel
            // 
            this.CursoLabel.Location = new System.Drawing.Point(3, 3);
            this.CursoLabel.Name = "CursoLabel";
            this.CursoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CursoLabel.Size = new System.Drawing.Size(64, 18);
            this.CursoLabel.TabIndex = 71;
            this.CursoLabel.Text = "Curso";
            this.CursoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HorarioCursoComboBox
            // 
            this.HorarioCursoComboBox.DisplayMember = "NombreHorario";
            this.HorarioCursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorarioCursoComboBox.FormattingEnabled = true;
            this.HorarioCursoComboBox.Location = new System.Drawing.Point(74, 3);
            this.HorarioCursoComboBox.Name = "HorarioCursoComboBox";
            this.HorarioCursoComboBox.Size = new System.Drawing.Size(245, 21);
            this.HorarioCursoComboBox.TabIndex = 68;
            this.HorarioCursoComboBox.ValueMember = "Id";
            // 
            // MesCursoComboBox
            // 
            this.MesCursoComboBox.DisplayMember = "NombreMes";
            this.MesCursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesCursoComboBox.FormattingEnabled = true;
            this.MesCursoComboBox.Location = new System.Drawing.Point(340, 3);
            this.MesCursoComboBox.Name = "MesCursoComboBox";
            this.MesCursoComboBox.Size = new System.Drawing.Size(63, 21);
            this.MesCursoComboBox.TabIndex = 73;
            this.MesCursoComboBox.ValueMember = "NumeroMes";
            // 
            // AnoCursoComboBox
            // 
            this.AnoCursoComboBox.DisplayMember = "NombreAno";
            this.AnoCursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnoCursoComboBox.FormattingEnabled = true;
            this.AnoCursoComboBox.Location = new System.Drawing.Point(406, 3);
            this.AnoCursoComboBox.Name = "AnoCursoComboBox";
            this.AnoCursoComboBox.Size = new System.Drawing.Size(48, 21);
            this.AnoCursoComboBox.TabIndex = 77;
            this.AnoCursoComboBox.ValueMember = "NombreAno";
            // 
            // MensualidadNivelPanel
            // 
            this.MensualidadNivelPanel.Controls.Add(this.AnoNivelComboBox);
            this.MensualidadNivelPanel.Controls.Add(this.AreaNivelLabel);
            this.MensualidadNivelPanel.Controls.Add(this.HorarioNivelComboBox);
            this.MensualidadNivelPanel.Controls.Add(this.MesNivelComboBox);
            this.MensualidadNivelPanel.Location = new System.Drawing.Point(6, 44);
            this.MensualidadNivelPanel.Name = "MensualidadNivelPanel";
            this.MensualidadNivelPanel.Size = new System.Drawing.Size(458, 25);
            this.MensualidadNivelPanel.TabIndex = 90;
            // 
            // AnoNivelComboBox
            // 
            this.AnoNivelComboBox.DisplayMember = "NombreAno";
            this.AnoNivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnoNivelComboBox.FormattingEnabled = true;
            this.AnoNivelComboBox.Location = new System.Drawing.Point(406, 3);
            this.AnoNivelComboBox.Name = "AnoNivelComboBox";
            this.AnoNivelComboBox.Size = new System.Drawing.Size(48, 21);
            this.AnoNivelComboBox.TabIndex = 76;
            this.AnoNivelComboBox.ValueMember = "NombreAno";
            // 
            // AreaNivelLabel
            // 
            this.AreaNivelLabel.Location = new System.Drawing.Point(3, 4);
            this.AreaNivelLabel.Name = "AreaNivelLabel";
            this.AreaNivelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AreaNivelLabel.Size = new System.Drawing.Size(64, 18);
            this.AreaNivelLabel.TabIndex = 75;
            this.AreaNivelLabel.Text = "Area/Nivel";
            this.AreaNivelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HorarioNivelComboBox
            // 
            this.HorarioNivelComboBox.DisplayMember = "NombreHorario";
            this.HorarioNivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorarioNivelComboBox.FormattingEnabled = true;
            this.HorarioNivelComboBox.Location = new System.Drawing.Point(74, 3);
            this.HorarioNivelComboBox.Name = "HorarioNivelComboBox";
            this.HorarioNivelComboBox.Size = new System.Drawing.Size(245, 21);
            this.HorarioNivelComboBox.TabIndex = 74;
            this.HorarioNivelComboBox.ValueMember = "Id";
            // 
            // MesNivelComboBox
            // 
            this.MesNivelComboBox.DisplayMember = "NombreMes";
            this.MesNivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesNivelComboBox.FormattingEnabled = true;
            this.MesNivelComboBox.Location = new System.Drawing.Point(340, 3);
            this.MesNivelComboBox.Name = "MesNivelComboBox";
            this.MesNivelComboBox.Size = new System.Drawing.Size(63, 21);
            this.MesNivelComboBox.TabIndex = 73;
            this.MesNivelComboBox.ValueMember = "NumeroMes";
            // 
            // ConferenciaPanel
            // 
            this.ConferenciaPanel.Controls.Add(this.ConferenciaLabel);
            this.ConferenciaPanel.Controls.Add(this.ConferenciaComboBox);
            this.ConferenciaPanel.Location = new System.Drawing.Point(6, 44);
            this.ConferenciaPanel.Name = "ConferenciaPanel";
            this.ConferenciaPanel.Size = new System.Drawing.Size(458, 25);
            this.ConferenciaPanel.TabIndex = 92;
            // 
            // ConferenciaLabel
            // 
            this.ConferenciaLabel.Location = new System.Drawing.Point(3, 3);
            this.ConferenciaLabel.Name = "ConferenciaLabel";
            this.ConferenciaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConferenciaLabel.Size = new System.Drawing.Size(64, 21);
            this.ConferenciaLabel.TabIndex = 70;
            this.ConferenciaLabel.Text = "Conferencia";
            this.ConferenciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConferenciaComboBox
            // 
            this.ConferenciaComboBox.DisplayMember = "Nombre";
            this.ConferenciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConferenciaComboBox.FormattingEnabled = true;
            this.ConferenciaComboBox.Location = new System.Drawing.Point(74, 3);
            this.ConferenciaComboBox.Name = "ConferenciaComboBox";
            this.ConferenciaComboBox.Size = new System.Drawing.Size(266, 21);
            this.ConferenciaComboBox.TabIndex = 67;
            this.ConferenciaComboBox.ValueMember = "Id";
            // 
            // RubroPanel
            // 
            this.RubroPanel.Controls.Add(this.RubroLabel);
            this.RubroPanel.Controls.Add(this.RubroComboBox);
            this.RubroPanel.Location = new System.Drawing.Point(6, 44);
            this.RubroPanel.Name = "RubroPanel";
            this.RubroPanel.Size = new System.Drawing.Size(458, 25);
            this.RubroPanel.TabIndex = 91;
            // 
            // RubroLabel
            // 
            this.RubroLabel.Location = new System.Drawing.Point(3, 3);
            this.RubroLabel.Name = "RubroLabel";
            this.RubroLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RubroLabel.Size = new System.Drawing.Size(64, 21);
            this.RubroLabel.TabIndex = 69;
            this.RubroLabel.Text = "Rubro";
            this.RubroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RubroComboBox
            // 
            this.RubroComboBox.DisplayMember = "Nombre";
            this.RubroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RubroComboBox.FormattingEnabled = true;
            this.RubroComboBox.Location = new System.Drawing.Point(74, 3);
            this.RubroComboBox.Name = "RubroComboBox";
            this.RubroComboBox.Size = new System.Drawing.Size(245, 21);
            this.RubroComboBox.TabIndex = 66;
            this.RubroComboBox.ValueMember = "Id";
            this.RubroComboBox.SelectedIndexChanged += new System.EventHandler(this.RubroComboBox_SelectedIndexChanged);
            // 
            // Logotipo
            // 
            this.Logotipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logotipo.Location = new System.Drawing.Point(835, 6);
            this.Logotipo.Name = "Logotipo";
            this.Logotipo.Size = new System.Drawing.Size(54, 44);
            this.Logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logotipo.TabIndex = 14;
            this.Logotipo.TabStop = false;
            // 
            // PagosRealizadosTabPage
            // 
            this.PagosRealizadosTabPage.Controls.Add(this.DetallePagoVentana);
            this.PagosRealizadosTabPage.Controls.Add(this.TotalGroupBox);
            this.PagosRealizadosTabPage.Controls.Add(this.PagosRealizadosDataGrid);
            this.PagosRealizadosTabPage.Location = new System.Drawing.Point(4, 22);
            this.PagosRealizadosTabPage.Name = "PagosRealizadosTabPage";
            this.PagosRealizadosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PagosRealizadosTabPage.Size = new System.Drawing.Size(897, 460);
            this.PagosRealizadosTabPage.TabIndex = 0;
            this.PagosRealizadosTabPage.Text = "Pagos Realizados";
            this.PagosRealizadosTabPage.UseVisualStyleBackColor = true;
            // 
            // DetallePagoVentana
            // 
            this.DetallePagoVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DetallePagoVentana.ColumnasNoVisibles = ((System.Collections.Generic.List<string>)(resources.GetObject("DetallePagoVentana.ColumnasNoVisibles")));
            this.DetallePagoVentana.DataSource = null;
            this.DetallePagoVentana.Location = new System.Drawing.Point(195, 111);
            this.DetallePagoVentana.Name = "DetallePagoVentana";
            this.DetallePagoVentana.Size = new System.Drawing.Size(575, 240);
            this.DetallePagoVentana.TabIndex = 5;
            this.DetallePagoVentana.Visible = false;
            // 
            // TotalGroupBox
            // 
            this.TotalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalGroupBox.Controls.Add(this.ValorTotalLabel);
            this.TotalGroupBox.Controls.Add(this.TextoValorLabel);
            this.TotalGroupBox.Location = new System.Drawing.Point(6, 6);
            this.TotalGroupBox.Name = "TotalGroupBox";
            this.TotalGroupBox.Size = new System.Drawing.Size(883, 39);
            this.TotalGroupBox.TabIndex = 3;
            this.TotalGroupBox.TabStop = false;
            // 
            // ValorTotalLabel
            // 
            this.ValorTotalLabel.AutoSize = true;
            this.ValorTotalLabel.Location = new System.Drawing.Point(136, 16);
            this.ValorTotalLabel.Name = "ValorTotalLabel";
            this.ValorTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.ValorTotalLabel.TabIndex = 1;
            this.ValorTotalLabel.Text = "1000";
            // 
            // TextoValorLabel
            // 
            this.TextoValorLabel.AutoSize = true;
            this.TextoValorLabel.Location = new System.Drawing.Point(6, 16);
            this.TextoValorLabel.Name = "TextoValorLabel";
            this.TextoValorLabel.Size = new System.Drawing.Size(115, 13);
            this.TextoValorLabel.TabIndex = 0;
            this.TextoValorLabel.Text = "Valor de Cierre de Caja";
            // 
            // PagosRealizadosDataGrid
            // 
            this.PagosRealizadosDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PagosRealizadosDataGrid.ColumnasNoVisibles = ((System.Collections.Generic.List<string>)(resources.GetObject("PagosRealizadosDataGrid.ColumnasNoVisibles")));
            this.PagosRealizadosDataGrid.DataSource = null;
            this.PagosRealizadosDataGrid.Location = new System.Drawing.Point(6, 51);
            this.PagosRealizadosDataGrid.Name = "PagosRealizadosDataGrid";
            this.PagosRealizadosDataGrid.Size = new System.Drawing.Size(883, 403);
            this.PagosRealizadosDataGrid.TabIndex = 4;
            this.PagosRealizadosDataGrid.PagoDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PagosRealizadosDataGrid_PagoDoubleClick);
            // 
            // estadoToolStripDropDown
            // 
            this.estadoToolStripDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresadoToolStripButton,
            this.facturadoToolStripButton,
            this.anuladoToolStripButton});
            this.estadoToolStripDropDown.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.estadoToolStripDropDown.Name = "estadoToolStripDropDown";
            this.estadoToolStripDropDown.Size = new System.Drawing.Size(62, 64);
            // 
            // ingresadoToolStripButton
            // 
            this.ingresadoToolStripButton.Name = "ingresadoToolStripButton";
            this.ingresadoToolStripButton.Size = new System.Drawing.Size(60, 17);
            this.ingresadoToolStripButton.Tag = Verdezul.IDH.Configuracion.Enumerados.EstadoPago.Ingresado;
            this.ingresadoToolStripButton.Text = "Ingresado";
            // 
            // facturadoToolStripButton
            // 
            this.facturadoToolStripButton.Name = "facturadoToolStripButton";
            this.facturadoToolStripButton.Size = new System.Drawing.Size(60, 17);
            this.facturadoToolStripButton.Tag = Verdezul.IDH.Configuracion.Enumerados.EstadoPago.Facturado;
            this.facturadoToolStripButton.Text = "Facturado";
            // 
            // anuladoToolStripButton
            // 
            this.anuladoToolStripButton.Name = "anuladoToolStripButton";
            this.anuladoToolStripButton.Size = new System.Drawing.Size(50, 17);
            this.anuladoToolStripButton.Tag = Verdezul.IDH.Configuracion.Enumerados.EstadoPago.Anulado;
            this.anuladoToolStripButton.Text = "Anulado";
            // 
            // PagosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(905, 533);
            this.Controls.Add(this.PagoTabControl);
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoFormaBase;
            this.MinimumSize = new System.Drawing.Size(782, 532);
            this.Name = "PagosForma";
            this.Text = "Pagos de Alumnos";
            this.Load += new System.EventHandler(this.CajaForma_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PagosForma_FormClosing);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.PagoTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePagosDataGrid)).EndInit();
            this.AlumnoGrouBox.ResumeLayout(false);
            this.PagoTabControl.ResumeLayout(false);
            this.RegistroTabPage.ResumeLayout(false);
            this.DetallePagoGroupBox.ResumeLayout(false);
            this.DetallePagoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVANumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PVPNumericUpDown)).EndInit();
            this.MensualidadCursoPanel.ResumeLayout(false);
            this.MensualidadNivelPanel.ResumeLayout(false);
            this.ConferenciaPanel.ResumeLayout(false);
            this.RubroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo)).EndInit();
            this.PagosRealizadosTabPage.ResumeLayout(false);
            this.TotalGroupBox.ResumeLayout(false);
            this.TotalGroupBox.PerformLayout();
            this.estadoToolStripDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Logotipo;
        private TabControl PagoTabControl;
        private TabPage RegistroTabPage;
        private TabPage PagosRealizadosTabPage;
        private DataGridView DetallePagosDataGrid;
        private GroupBox AlumnoGrouBox;
        private GroupBox DetallePagoGroupBox;
        private RadioButton Recibo;
        private RadioButton ConNotaDeVenta;
        private RadioButton ConFactura;
        private Panel MensualidadCursoPanel;
        private Panel MensualidadNivelPanel;
        private Panel ConferenciaPanel;
        private Panel RubroPanel;
        private ComboBox MotivoPagoComboBox;
        private ComboBox MesNivelComboBox;
        private ComboBox ConferenciaComboBox;
        private ComboBox RubroComboBox;
        private Button AgregarButton;
        private Button BorrarDetalleButton;
        private TextBox TotalPagarTextBox;
        private TextBox TotalIVATextBox;
        private TextBox TotalValorTextBox;
        private TextBox TotalItemsTextBox;
        private NumericUpDown PVPNumericUpDown;
        private NumericUpDown IVANumericUpDown;
        private NumericUpDown ValorNumericUpDown;
        private NumericUpDown DescuentoNumericUpDown;
        private NumericUpDown CantidadNumericUpDown;
        private AlumnoControl AlumnoPago;
        private Label CantidadLabel;
        private Label ValorLabel;
        private Label IVALabel;
        private Label PVPLabel;
        private Label DescuentoLabel;
        private Label AlumnoLabel;
        private Label ConferenciaLabel;
        private Label RubroLabel;
        private Label MotivoLabel;
        private Label AreaNivelLabel;
        private Label Total1;
        private Label Total2;
        private Label Total3;
        private Label Total4;
        private GroupBox TotalGroupBox;
        private Label ValorTotalLabel;
        private Label TextoValorLabel;
        private DataGridPagos PagosRealizadosDataGrid;
        private ToolStripDropDown estadoToolStripDropDown;
        private ToolStripButton ingresadoToolStripButton;
        private ToolStripButton facturadoToolStripButton;
        private ToolStripButton anuladoToolStripButton;
        private DetallePagoControl DetallePagoVentana;
        private Label CursoLabel;
        private ComboBox HorarioCursoComboBox;
        private ComboBox MesCursoComboBox;
        private ComboBox HorarioNivelComboBox;
        private ComboBox TipoAbonoComboBox;
        private Label AbonoLabel;
        private DataGridViewTextBoxColumn CantidadColumn;
        private DataGridViewTextBoxColumn DescripcionColumn;
        private DataGridViewTextBoxColumn ValorColumn;
        private DataGridViewTextBoxColumn IVAColumn;
        private DataGridViewTextBoxColumn DescuentoColumn;
        private DataGridViewTextBoxColumn PVPColumn;
        private DataGridViewComboBoxColumn TipoAbonoTextoColumn;
        private ComboBox AnoNivelComboBox;
        private ComboBox AnoCursoComboBox;
    }
}