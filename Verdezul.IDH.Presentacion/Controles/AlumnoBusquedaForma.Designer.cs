namespace Verdezul.IDH.Presentacion.Controles
{
    partial class AlumnoBusquedaForma
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
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.AlumnoControlBusqueda = new Verdezul.IDH.Presentacion.Controles.AlumnoControl();
            this.AlumnosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.AlumnoControlBusqueda);
            this.DatosGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatosGroupBox.Location = new System.Drawing.Point(0, 25);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(792, 54);
            this.DatosGroupBox.TabIndex = 0;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos";
            // 
            // AlumnoControlBusqueda
            // 
            this.AlumnoControlBusqueda.Apellido = "";
            this.AlumnoControlBusqueda.BuscarVisible = false;
            this.AlumnoControlBusqueda.Location = new System.Drawing.Point(12, 19);
            this.AlumnoControlBusqueda.MinimumSize = new System.Drawing.Size(475, 25);
            this.AlumnoControlBusqueda.Name = "AlumnoControlBusqueda";
            this.AlumnoControlBusqueda.Nombre = "";
            this.AlumnoControlBusqueda.PermitirCrearAlumno = false;
            this.AlumnoControlBusqueda.Size = new System.Drawing.Size(475, 25);
            this.AlumnoControlBusqueda.TabIndex = 0;
            // 
            // AlumnosDataGridView
            // 
            this.AlumnosDataGridView.AllowUserToAddRows = false;
            this.AlumnosDataGridView.AllowUserToDeleteRows = false;
            this.AlumnosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlumnosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlumnosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AlumnosDataGridView.Location = new System.Drawing.Point(0, 85);
            this.AlumnosDataGridView.Name = "AlumnosDataGridView";
            this.AlumnosDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlumnosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AlumnosDataGridView.RowHeadersVisible = false;
            this.AlumnosDataGridView.RowHeadersWidth = 20;
            this.AlumnosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlumnosDataGridView.Size = new System.Drawing.Size(792, 459);
            this.AlumnosDataGridView.TabIndex = 80;
            this.AlumnosDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AlumnosDataGridView_CellMouseDoubleClick);
            // 
            // AlumnoBusquedaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.DatosGroupBox);
            this.Controls.Add(this.AlumnosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlumnoBusquedaForma";
            this.Text = "Búsqueda de Alumnos";
            this.Load += new System.EventHandler(this.AlumnoForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.AlumnosDataGridView, 0);
            this.Controls.SetChildIndex(this.DatosGroupBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.DataGridView AlumnosDataGridView;
        private Verdezul.IDH.Presentacion.Controles.AlumnoControl AlumnoControlBusqueda;
    }
}