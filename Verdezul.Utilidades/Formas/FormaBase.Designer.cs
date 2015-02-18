namespace Verdezul.Utilidades.Formas
{
    partial class FormaBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            this.BarraBotones = new System.Windows.Forms.ToolStrip();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.BotonEsc = new System.Windows.Forms.Button();
            this.MarcaError = new System.Windows.Forms.ErrorProvider(this.components);
            this._MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraBotones
            // 
            this.BarraBotones.Location = new System.Drawing.Point(0, 0);
            this.BarraBotones.Name = "BarraBotones";
            this.BarraBotones.Size = new System.Drawing.Size(448, 25);
            this.BarraBotones.TabIndex = 0;
            this.BarraBotones.Text = "Botones";
            // 
            // BarraEstado
            // 
            this.BarraEstado.Location = new System.Drawing.Point(0, 244);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(448, 22);
            this.BarraEstado.TabIndex = 1;
            this.BarraEstado.Text = "Estado";
            // 
            // BotonEsc
            // 
            this.BotonEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotonEsc.Location = new System.Drawing.Point(0, 0);
            this.BotonEsc.Name = "BotonEsc";
            this.BotonEsc.Size = new System.Drawing.Size(0, 0);
            this.BotonEsc.TabIndex = 1;
            this.BotonEsc.TabStop = false;
            this.BotonEsc.Click += new System.EventHandler(this.BotonEsc_Click);
            // 
            // MarcaError
            // 
            this.MarcaError.ContainerControl = this;
            // 
            // _MenuItem
            // 
            this._MenuItem.Name = "_MenuItem";
            this._MenuItem.Size = new System.Drawing.Size(32, 19);
            this._MenuItem.Click += new System.EventHandler(this.MenuItemForma_Click);
            // 
            // FormaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BotonEsc;
            this.ClientSize = new System.Drawing.Size(448, 266);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.BarraBotones);
            this.Controls.Add(this.BotonEsc);
            this.Name = "FormaBase";
            this.Text = "FormaBase";
            this.Deactivate += new System.EventHandler(this.FormaBase_Deactivate);
            this.Shown += new System.EventHandler(this.FormaBase_Shown);
            this.Activated += new System.EventHandler(this.FormaBase_Activated);
            this.TextChanged += new System.EventHandler(this.FormaBase_TextChanged);
            this.BarraBotones.ResumeLayout(false);
            this.BarraBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.StatusStrip BarraEstado;
        public System.Windows.Forms.ErrorProvider MarcaError;
        protected System.Windows.Forms.Button BotonEsc;
        private System.Windows.Forms.ToolStripMenuItem _MenuItem;
        protected System.Windows.Forms.ToolStrip BarraBotones;
    }
}