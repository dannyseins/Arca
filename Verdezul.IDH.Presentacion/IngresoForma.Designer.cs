namespace Verdezul.IDH.Presentacion
{
    partial class IngresoForma
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
            this.Ingresar = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.Informacion2 = new System.Windows.Forms.Label();
            this.Informacion1 = new System.Windows.Forms.Label();
            this.IDHPictureBox = new System.Windows.Forms.PictureBox();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDHPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(16, 71);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 30;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(62, 19);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(110, 20);
            this.Usuario.TabIndex = 10;
            this.Usuario.Text = "admin";
            // 
            // Clave
            // 
            this.Clave.Location = new System.Drawing.Point(62, 45);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(110, 20);
            this.Clave.TabIndex = 20;
            this.Clave.Text = "admin";
            this.Clave.UseSystemPasswordChar = true;
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(97, 71);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 40;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.Informacion2);
            this.DatosGroupBox.Controls.Add(this.Cancelar);
            this.DatosGroupBox.Controls.Add(this.Informacion1);
            this.DatosGroupBox.Controls.Add(this.Ingresar);
            this.DatosGroupBox.Controls.Add(this.Usuario);
            this.DatosGroupBox.Controls.Add(this.Clave);
            this.DatosGroupBox.Location = new System.Drawing.Point(152, 12);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(181, 106);
            this.DatosGroupBox.TabIndex = 13;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Text = "Datos de Acceso";
            // 
            // Informacion2
            // 
            this.Informacion2.Location = new System.Drawing.Point(9, 45);
            this.Informacion2.Name = "Informacion2";
            this.Informacion2.Size = new System.Drawing.Size(47, 23);
            this.Informacion2.TabIndex = 8;
            this.Informacion2.Text = "Clave";
            this.Informacion2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Informacion1
            // 
            this.Informacion1.Location = new System.Drawing.Point(9, 19);
            this.Informacion1.Name = "Informacion1";
            this.Informacion1.Size = new System.Drawing.Size(47, 23);
            this.Informacion1.TabIndex = 3;
            this.Informacion1.Text = "Usuario";
            this.Informacion1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDHPictureBox
            // 
            this.IDHPictureBox.Location = new System.Drawing.Point(12, 12);
            this.IDHPictureBox.Name = "IDHPictureBox";
            this.IDHPictureBox.Size = new System.Drawing.Size(123, 106);
            this.IDHPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IDHPictureBox.TabIndex = 14;
            this.IDHPictureBox.TabStop = false;
            // 
            // IngresoForma
            // 
            this.AcceptButton = this.Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(342, 129);
            this.Controls.Add(this.IDHPictureBox);
            this.Controls.Add(this.DatosGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Verdezul.IDH.Presentacion.Properties.Resources.IconoPrincipal;
            this.MaximizeBox = false;
            this.Name = "IngresoForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.IngresoForma_Load);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDHPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.Label Informacion2;
        private System.Windows.Forms.Label Informacion1;
        private System.Windows.Forms.PictureBox IDHPictureBox;
    }
}