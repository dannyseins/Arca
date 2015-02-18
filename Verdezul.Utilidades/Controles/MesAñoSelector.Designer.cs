namespace Verdezul.Utilidades.Controles
{
    partial class MesAñoSelector
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
            this.MesComboBox = new System.Windows.Forms.ComboBox();
            this.AñoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MesComboBox
            // 
            this.MesComboBox.DisplayMember = "Texto";
            this.MesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesComboBox.FormattingEnabled = true;
            this.MesComboBox.Location = new System.Drawing.Point(0, 0);
            this.MesComboBox.Name = "MesComboBox";
            this.MesComboBox.Size = new System.Drawing.Size(75, 21);
            this.MesComboBox.TabIndex = 0;
            this.MesComboBox.ValueMember = "Valor";
            // 
            // AñoComboBox
            // 
            this.AñoComboBox.DisplayMember = "Texto";
            this.AñoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AñoComboBox.FormattingEnabled = true;
            this.AñoComboBox.Location = new System.Drawing.Point(80, 0);
            this.AñoComboBox.Name = "AñoComboBox";
            this.AñoComboBox.Size = new System.Drawing.Size(50, 21);
            this.AñoComboBox.TabIndex = 1;
            this.AñoComboBox.ValueMember = "Valor";
            // 
            // MesAñoSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MesComboBox);
            this.Controls.Add(this.AñoComboBox);
            this.MaximumSize = new System.Drawing.Size(130, 21);
            this.MinimumSize = new System.Drawing.Size(130, 21);
            this.Name = "MesAñoSelector";
            this.Size = new System.Drawing.Size(130, 21);
            this.Load += new System.EventHandler(this.MesAñoSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox MesComboBox;
        private System.Windows.Forms.ComboBox AñoComboBox;
    }
}
