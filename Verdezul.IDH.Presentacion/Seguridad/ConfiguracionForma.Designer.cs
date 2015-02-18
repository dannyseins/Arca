namespace Verdezul.IDH.Presentacion.Seguridad
{
    partial class ConfiguracionForma
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
            this.ConfiguracionTabControl = new System.Windows.Forms.TabControl();
            this.Conexiones = new System.Windows.Forms.TabPage();
            this.CajaGroupBox = new System.Windows.Forms.GroupBox();
            this.CajaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CajaLabel = new System.Windows.Forms.Label();
            this.Reportes = new System.Windows.Forms.GroupBox();
            this.ReportesLabel = new System.Windows.Forms.Label();
            this.ReportesTextBox = new System.Windows.Forms.TextBox();
            this.ExaminarCarpetaBoton = new System.Windows.Forms.Button();
            this.ReporteProbarBoton = new System.Windows.Forms.Button();
            this.BaseDatosGroupBox = new System.Windows.Forms.GroupBox();
            this.ConexionComboBox = new System.Windows.Forms.ComboBox();
            this.ConexionLabel = new System.Windows.Forms.Label();
            this.BaseProbarBoton = new System.Windows.Forms.Button();
            this.CajaLocal = new System.Windows.Forms.TabPage();
            this.TipoLetraGroupBox = new System.Windows.Forms.GroupBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.PosicionLabel = new System.Windows.Forms.Label();
            this.XNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TamanoLetraTextBoxLabel = new System.Windows.Forms.Label();
            this.TipoLetraLabel = new System.Windows.Forms.Label();
            this.TamanoLetraNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TipoLetraTextBox = new System.Windows.Forms.TextBox();
            this.TipoLetraButton = new System.Windows.Forms.Button();
            this.ImpresoraGroupBox = new System.Windows.Forms.GroupBox();
            this.ImpresoraButton = new System.Windows.Forms.Button();
            this.BandejaTextBox = new System.Windows.Forms.TextBox();
            this.ImpresoraTextBox = new System.Windows.Forms.TextBox();
            this.BandejaLabel = new System.Windows.Forms.Label();
            this.NombreImpresoraLabel = new System.Windows.Forms.Label();
            this.MostrarDialogoCheckBox = new System.Windows.Forms.CheckBox();
            this.CarpetaDialogo = new System.Windows.Forms.FolderBrowserDialog();
            this.ArchivoDialogo = new System.Windows.Forms.OpenFileDialog();
            this.VentanaFuentes = new System.Windows.Forms.FontDialog();
            this.VentanaImpresion = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.ConfiguracionTabControl.SuspendLayout();
            this.Conexiones.SuspendLayout();
            this.CajaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CajaNumericUpDown)).BeginInit();
            this.Reportes.SuspendLayout();
            this.BaseDatosGroupBox.SuspendLayout();
            this.CajaLocal.SuspendLayout();
            this.TipoLetraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamanoLetraNumericUpDown)).BeginInit();
            this.ImpresoraGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentanaImpresion
            // 
            this.VentanaImpresion.AllowPrintToFile = false;
            this.VentanaImpresion.ShowNetwork = false;
            // 
            // ConfiguracionTabControl
            // 
            this.ConfiguracionTabControl.Controls.Add(this.Conexiones);
            this.ConfiguracionTabControl.Controls.Add(this.CajaLocal);
            this.ConfiguracionTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfiguracionTabControl.Location = new System.Drawing.Point(0, 25);
            this.ConfiguracionTabControl.Name = "ConfiguracionTabControl";
            this.ConfiguracionTabControl.SelectedIndex = 0;
            this.ConfiguracionTabControl.Size = new System.Drawing.Size(616, 241);
            this.ConfiguracionTabControl.TabIndex = 0;
            this.ConfiguracionTabControl.SelectedIndexChanged += new System.EventHandler(this.ConfiguracionTabControl_SelectedIndexChanged);
            // 
            // Conexiones
            // 
            this.Conexiones.Controls.Add(this.CajaGroupBox);
            this.Conexiones.Controls.Add(this.Reportes);
            this.Conexiones.Controls.Add(this.BaseDatosGroupBox);
            this.Conexiones.Location = new System.Drawing.Point(4, 22);
            this.Conexiones.Name = "Conexiones";
            this.Conexiones.Padding = new System.Windows.Forms.Padding(3);
            this.Conexiones.Size = new System.Drawing.Size(608, 215);
            this.Conexiones.TabIndex = 0;
            this.Conexiones.Text = "Conexiones";
            this.Conexiones.UseVisualStyleBackColor = true;
            // 
            // CajaGroupBox
            // 
            this.CajaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CajaGroupBox.Controls.Add(this.CajaNumericUpDown);
            this.CajaGroupBox.Controls.Add(this.CajaLabel);
            this.CajaGroupBox.Location = new System.Drawing.Point(8, 144);
            this.CajaGroupBox.Name = "CajaGroupBox";
            this.CajaGroupBox.Size = new System.Drawing.Size(592, 42);
            this.CajaGroupBox.TabIndex = 14;
            this.CajaGroupBox.TabStop = false;
            this.CajaGroupBox.Text = "Configuración de Caja";
            // 
            // CajaNumericUpDown
            // 
            this.CajaNumericUpDown.Location = new System.Drawing.Point(145, 14);
            this.CajaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CajaNumericUpDown.Name = "CajaNumericUpDown";
            this.CajaNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.CajaNumericUpDown.TabIndex = 21;
            this.CajaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CajaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CajaLabel
            // 
            this.CajaLabel.AutoSize = true;
            this.CajaLabel.Location = new System.Drawing.Point(6, 16);
            this.CajaLabel.Name = "CajaLabel";
            this.CajaLabel.Size = new System.Drawing.Size(133, 13);
            this.CajaLabel.TabIndex = 18;
            this.CajaLabel.Text = "Identificador de Caja Local";
            // 
            // Reportes
            // 
            this.Reportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Reportes.Controls.Add(this.ReportesLabel);
            this.Reportes.Controls.Add(this.ReportesTextBox);
            this.Reportes.Controls.Add(this.ExaminarCarpetaBoton);
            this.Reportes.Controls.Add(this.ReporteProbarBoton);
            this.Reportes.Location = new System.Drawing.Point(8, 75);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(592, 63);
            this.Reportes.TabIndex = 7;
            this.Reportes.TabStop = false;
            this.Reportes.Text = "Reportes";
            // 
            // ReportesLabel
            // 
            this.ReportesLabel.AutoSize = true;
            this.ReportesLabel.Location = new System.Drawing.Point(6, 14);
            this.ReportesLabel.Name = "ReportesLabel";
            this.ReportesLabel.Size = new System.Drawing.Size(116, 13);
            this.ReportesLabel.TabIndex = 8;
            this.ReportesLabel.Text = "Ubicación de Reportes";
            // 
            // ReportesTextBox
            // 
            this.ReportesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportesTextBox.Location = new System.Drawing.Point(9, 30);
            this.ReportesTextBox.Name = "ReportesTextBox";
            this.ReportesTextBox.ReadOnly = true;
            this.ReportesTextBox.Size = new System.Drawing.Size(415, 20);
            this.ReportesTextBox.TabIndex = 4;
            // 
            // ExaminarCarpetaBoton
            // 
            this.ExaminarCarpetaBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExaminarCarpetaBoton.Location = new System.Drawing.Point(430, 28);
            this.ExaminarCarpetaBoton.Name = "ExaminarCarpetaBoton";
            this.ExaminarCarpetaBoton.Size = new System.Drawing.Size(75, 23);
            this.ExaminarCarpetaBoton.TabIndex = 5;
            this.ExaminarCarpetaBoton.Text = "Examinar";
            this.ExaminarCarpetaBoton.UseVisualStyleBackColor = true;
            this.ExaminarCarpetaBoton.Click += new System.EventHandler(this.ExaminarCarpetaBoton_Click);
            // 
            // ReporteProbarBoton
            // 
            this.ReporteProbarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReporteProbarBoton.Location = new System.Drawing.Point(511, 27);
            this.ReporteProbarBoton.Name = "ReporteProbarBoton";
            this.ReporteProbarBoton.Size = new System.Drawing.Size(75, 23);
            this.ReporteProbarBoton.TabIndex = 7;
            this.ReporteProbarBoton.Text = "Probar";
            this.ReporteProbarBoton.UseVisualStyleBackColor = true;
            this.ReporteProbarBoton.Click += new System.EventHandler(this.ReporteProbarBoton_Click);
            // 
            // BaseDatosGroupBox
            // 
            this.BaseDatosGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseDatosGroupBox.Controls.Add(this.ConexionComboBox);
            this.BaseDatosGroupBox.Controls.Add(this.ConexionLabel);
            this.BaseDatosGroupBox.Controls.Add(this.BaseProbarBoton);
            this.BaseDatosGroupBox.Location = new System.Drawing.Point(8, 6);
            this.BaseDatosGroupBox.Name = "BaseDatosGroupBox";
            this.BaseDatosGroupBox.Size = new System.Drawing.Size(592, 63);
            this.BaseDatosGroupBox.TabIndex = 9;
            this.BaseDatosGroupBox.TabStop = false;
            this.BaseDatosGroupBox.Text = "Base de Datos";
            // 
            // ConexionComboBox
            // 
            this.ConexionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ConexionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConexionComboBox.Location = new System.Drawing.Point(9, 32);
            this.ConexionComboBox.Name = "ConexionComboBox";
            this.ConexionComboBox.Size = new System.Drawing.Size(496, 21);
            this.ConexionComboBox.TabIndex = 2;
            // 
            // ConexionLabel
            // 
            this.ConexionLabel.AutoSize = true;
            this.ConexionLabel.Location = new System.Drawing.Point(6, 16);
            this.ConexionLabel.Name = "ConexionLabel";
            this.ConexionLabel.Size = new System.Drawing.Size(97, 13);
            this.ConexionLabel.TabIndex = 3;
            this.ConexionLabel.Text = "Conexión de Datos";
            // 
            // BaseProbarBoton
            // 
            this.BaseProbarBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseProbarBoton.Location = new System.Drawing.Point(511, 30);
            this.BaseProbarBoton.Name = "BaseProbarBoton";
            this.BaseProbarBoton.Size = new System.Drawing.Size(75, 23);
            this.BaseProbarBoton.TabIndex = 6;
            this.BaseProbarBoton.Text = "Probar";
            this.BaseProbarBoton.UseVisualStyleBackColor = true;
            this.BaseProbarBoton.Click += new System.EventHandler(this.BaseProbarBoton_Click);
            // 
            // CajaLocal
            // 
            this.CajaLocal.Controls.Add(this.TipoLetraGroupBox);
            this.CajaLocal.Controls.Add(this.ImpresoraGroupBox);
            this.CajaLocal.Location = new System.Drawing.Point(4, 22);
            this.CajaLocal.Name = "CajaLocal";
            this.CajaLocal.Padding = new System.Windows.Forms.Padding(3);
            this.CajaLocal.Size = new System.Drawing.Size(608, 215);
            this.CajaLocal.TabIndex = 1;
            this.CajaLocal.Text = "Caja Local";
            this.CajaLocal.UseVisualStyleBackColor = true;
            // 
            // TipoLetraGroupBox
            // 
            this.TipoLetraGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoLetraGroupBox.Controls.Add(this.YLabel);
            this.TipoLetraGroupBox.Controls.Add(this.XLabel);
            this.TipoLetraGroupBox.Controls.Add(this.PosicionLabel);
            this.TipoLetraGroupBox.Controls.Add(this.XNumericUpDown);
            this.TipoLetraGroupBox.Controls.Add(this.YNumericUpDown);
            this.TipoLetraGroupBox.Controls.Add(this.TamanoLetraTextBoxLabel);
            this.TipoLetraGroupBox.Controls.Add(this.TipoLetraLabel);
            this.TipoLetraGroupBox.Controls.Add(this.TamanoLetraNumericUpDown);
            this.TipoLetraGroupBox.Controls.Add(this.TipoLetraTextBox);
            this.TipoLetraGroupBox.Controls.Add(this.TipoLetraButton);
            this.TipoLetraGroupBox.Location = new System.Drawing.Point(8, 94);
            this.TipoLetraGroupBox.Name = "TipoLetraGroupBox";
            this.TipoLetraGroupBox.Size = new System.Drawing.Size(592, 113);
            this.TipoLetraGroupBox.TabIndex = 12;
            this.TipoLetraGroupBox.TabStop = false;
            this.TipoLetraGroupBox.Text = "Tipo de Letra y Posición de Impresión";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(183, 87);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 17;
            this.YLabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(183, 60);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 16;
            this.XLabel.Text = "X";
            // 
            // PosicionLabel
            // 
            this.PosicionLabel.AutoSize = true;
            this.PosicionLabel.Location = new System.Drawing.Point(67, 60);
            this.PosicionLabel.Name = "PosicionLabel";
            this.PosicionLabel.Size = new System.Drawing.Size(110, 13);
            this.PosicionLabel.TabIndex = 15;
            this.PosicionLabel.Text = "Posición de Impresión";
            // 
            // XNumericUpDown
            // 
            this.XNumericUpDown.Location = new System.Drawing.Point(203, 58);
            this.XNumericUpDown.Name = "XNumericUpDown";
            this.XNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.XNumericUpDown.TabIndex = 9;
            // 
            // YNumericUpDown
            // 
            this.YNumericUpDown.Location = new System.Drawing.Point(203, 85);
            this.YNumericUpDown.Name = "YNumericUpDown";
            this.YNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.YNumericUpDown.TabIndex = 10;
            // 
            // TamanoLetraTextBoxLabel
            // 
            this.TamanoLetraTextBoxLabel.AutoSize = true;
            this.TamanoLetraTextBoxLabel.Location = new System.Drawing.Point(200, 16);
            this.TamanoLetraTextBoxLabel.Name = "TamanoLetraTextBoxLabel";
            this.TamanoLetraTextBoxLabel.Size = new System.Drawing.Size(46, 13);
            this.TamanoLetraTextBoxLabel.TabIndex = 14;
            this.TamanoLetraTextBoxLabel.Text = "Tamaño";
            // 
            // TipoLetraLabel
            // 
            this.TipoLetraLabel.AutoSize = true;
            this.TipoLetraLabel.Location = new System.Drawing.Point(6, 16);
            this.TipoLetraLabel.Name = "TipoLetraLabel";
            this.TipoLetraLabel.Size = new System.Drawing.Size(70, 13);
            this.TipoLetraLabel.TabIndex = 13;
            this.TipoLetraLabel.Text = "Tipo de Letra";
            // 
            // TamanoLetraNumericUpDown
            // 
            this.TamanoLetraNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TamanoLetraNumericUpDown.Location = new System.Drawing.Point(203, 32);
            this.TamanoLetraNumericUpDown.Name = "TamanoLetraNumericUpDown";
            this.TamanoLetraNumericUpDown.ReadOnly = true;
            this.TamanoLetraNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.TamanoLetraNumericUpDown.TabIndex = 4;
            // 
            // TipoLetraTextBox
            // 
            this.TipoLetraTextBox.Location = new System.Drawing.Point(9, 32);
            this.TipoLetraTextBox.Name = "TipoLetraTextBox";
            this.TipoLetraTextBox.ReadOnly = true;
            this.TipoLetraTextBox.Size = new System.Drawing.Size(188, 20);
            this.TipoLetraTextBox.TabIndex = 5;
            // 
            // TipoLetraButton
            // 
            this.TipoLetraButton.Location = new System.Drawing.Point(252, 30);
            this.TipoLetraButton.Name = "TipoLetraButton";
            this.TipoLetraButton.Size = new System.Drawing.Size(75, 23);
            this.TipoLetraButton.TabIndex = 6;
            this.TipoLetraButton.Text = "Escoger";
            this.TipoLetraButton.UseVisualStyleBackColor = true;
            this.TipoLetraButton.Click += new System.EventHandler(this.TipoLetraButton_Click);
            // 
            // ImpresoraGroupBox
            // 
            this.ImpresoraGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ImpresoraGroupBox.Controls.Add(this.ImpresoraButton);
            this.ImpresoraGroupBox.Controls.Add(this.BandejaTextBox);
            this.ImpresoraGroupBox.Controls.Add(this.ImpresoraTextBox);
            this.ImpresoraGroupBox.Controls.Add(this.BandejaLabel);
            this.ImpresoraGroupBox.Controls.Add(this.NombreImpresoraLabel);
            this.ImpresoraGroupBox.Controls.Add(this.MostrarDialogoCheckBox);
            this.ImpresoraGroupBox.Location = new System.Drawing.Point(8, 6);
            this.ImpresoraGroupBox.Name = "ImpresoraGroupBox";
            this.ImpresoraGroupBox.Size = new System.Drawing.Size(592, 82);
            this.ImpresoraGroupBox.TabIndex = 11;
            this.ImpresoraGroupBox.TabStop = false;
            this.ImpresoraGroupBox.Text = "Impresora";
            // 
            // ImpresoraButton
            // 
            this.ImpresoraButton.Location = new System.Drawing.Point(397, 30);
            this.ImpresoraButton.Name = "ImpresoraButton";
            this.ImpresoraButton.Size = new System.Drawing.Size(75, 23);
            this.ImpresoraButton.TabIndex = 7;
            this.ImpresoraButton.Text = "Escoger";
            this.ImpresoraButton.UseVisualStyleBackColor = true;
            this.ImpresoraButton.Click += new System.EventHandler(this.ImpresoraButton_Click);
            // 
            // BandejaTextBox
            // 
            this.BandejaTextBox.Location = new System.Drawing.Point(203, 32);
            this.BandejaTextBox.Name = "BandejaTextBox";
            this.BandejaTextBox.ReadOnly = true;
            this.BandejaTextBox.Size = new System.Drawing.Size(188, 20);
            this.BandejaTextBox.TabIndex = 12;
            // 
            // ImpresoraTextBox
            // 
            this.ImpresoraTextBox.Location = new System.Drawing.Point(9, 32);
            this.ImpresoraTextBox.Name = "ImpresoraTextBox";
            this.ImpresoraTextBox.ReadOnly = true;
            this.ImpresoraTextBox.Size = new System.Drawing.Size(188, 20);
            this.ImpresoraTextBox.TabIndex = 11;
            // 
            // BandejaLabel
            // 
            this.BandejaLabel.AutoSize = true;
            this.BandejaLabel.Location = new System.Drawing.Point(200, 16);
            this.BandejaLabel.Name = "BandejaLabel";
            this.BandejaLabel.Size = new System.Drawing.Size(46, 13);
            this.BandejaLabel.TabIndex = 10;
            this.BandejaLabel.Text = "Bandeja";
            // 
            // NombreImpresoraLabel
            // 
            this.NombreImpresoraLabel.AutoSize = true;
            this.NombreImpresoraLabel.Location = new System.Drawing.Point(6, 16);
            this.NombreImpresoraLabel.Name = "NombreImpresoraLabel";
            this.NombreImpresoraLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreImpresoraLabel.TabIndex = 9;
            this.NombreImpresoraLabel.Text = "Nombre";
            // 
            // MostrarDialogoCheckBox
            // 
            this.MostrarDialogoCheckBox.AutoSize = true;
            this.MostrarDialogoCheckBox.Location = new System.Drawing.Point(9, 58);
            this.MostrarDialogoCheckBox.Name = "MostrarDialogoCheckBox";
            this.MostrarDialogoCheckBox.Size = new System.Drawing.Size(100, 17);
            this.MostrarDialogoCheckBox.TabIndex = 3;
            this.MostrarDialogoCheckBox.Text = "Mostrar Diálogo";
            this.MostrarDialogoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CarpetaDialogo
            // 
            this.CarpetaDialogo.Description = "Escoja la Carpeta donde se encuentran los reportes";
            this.CarpetaDialogo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.CarpetaDialogo.ShowNewFolderButton = false;
            // 
            // ArchivoDialogo
            // 
            this.ArchivoDialogo.Filter = "Base de Datos (*.mdf)|*.mdf";
            this.ArchivoDialogo.Title = "Escoger Base de Datos";
            // 
            // VentanaFuentes
            // 
            this.VentanaFuentes.FontMustExist = true;
            this.VentanaFuentes.ScriptsOnly = true;
            this.VentanaFuentes.ShowEffects = false;
            // 
            // ConfiguracionForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 288);
            this.Controls.Add(this.ConfiguracionTabControl);
            this.Name = "ConfiguracionForma";
            this.Text = "Configuración Local";
            this.Load += new System.EventHandler(this.ConfiguracionForma_Load);
            this.Controls.SetChildIndex(this.BotonEsc, 0);
            this.Controls.SetChildIndex(this.ConfiguracionTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ConfiguracionTabControl.ResumeLayout(false);
            this.Conexiones.ResumeLayout(false);
            this.CajaGroupBox.ResumeLayout(false);
            this.CajaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CajaNumericUpDown)).EndInit();
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            this.BaseDatosGroupBox.ResumeLayout(false);
            this.BaseDatosGroupBox.PerformLayout();
            this.CajaLocal.ResumeLayout(false);
            this.TipoLetraGroupBox.ResumeLayout(false);
            this.TipoLetraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamanoLetraNumericUpDown)).EndInit();
            this.ImpresoraGroupBox.ResumeLayout(false);
            this.ImpresoraGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ConfiguracionTabControl;
        private System.Windows.Forms.TabPage Conexiones;
        private System.Windows.Forms.TabPage CajaLocal;
        private System.Windows.Forms.Label ConexionLabel;
        private System.Windows.Forms.ComboBox ConexionComboBox;
        private System.Windows.Forms.FolderBrowserDialog CarpetaDialogo;
        private System.Windows.Forms.OpenFileDialog ArchivoDialogo;
        private System.Windows.Forms.Label ReportesLabel;
        private System.Windows.Forms.Button ReporteProbarBoton;
        private System.Windows.Forms.Button BaseProbarBoton;
        private System.Windows.Forms.Button ExaminarCarpetaBoton;
        private System.Windows.Forms.TextBox ReportesTextBox;
        private System.Windows.Forms.GroupBox Reportes;
        private System.Windows.Forms.GroupBox BaseDatosGroupBox;
        private System.Windows.Forms.FontDialog VentanaFuentes;
        private System.Windows.Forms.Button TipoLetraButton;
        private System.Windows.Forms.TextBox TipoLetraTextBox;
        private System.Windows.Forms.NumericUpDown TamanoLetraNumericUpDown;
        private System.Windows.Forms.CheckBox MostrarDialogoCheckBox;
        private System.Windows.Forms.NumericUpDown YNumericUpDown;
        private System.Windows.Forms.NumericUpDown XNumericUpDown;
        private System.Windows.Forms.GroupBox TipoLetraGroupBox;
        private System.Windows.Forms.GroupBox ImpresoraGroupBox;
        private System.Windows.Forms.Label BandejaLabel;
        private System.Windows.Forms.Label NombreImpresoraLabel;
        private System.Windows.Forms.TextBox ImpresoraTextBox;
        private System.Windows.Forms.Button ImpresoraButton;
        private System.Windows.Forms.TextBox BandejaTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label PosicionLabel;
        private System.Windows.Forms.Label TamanoLetraTextBoxLabel;
        private System.Windows.Forms.Label TipoLetraLabel;
        private System.Windows.Forms.GroupBox CajaGroupBox;
        private System.Windows.Forms.Label CajaLabel;
        private System.Windows.Forms.NumericUpDown CajaNumericUpDown;
        private System.Windows.Forms.PrintDialog VentanaImpresion;
    }
}