namespace ClinicaFrba.Abm_Profesional
{
    partial class BajaProfesional
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.LimpiarBoton = new System.Windows.Forms.Button();
            this.MatrículaLabel = new System.Windows.Forms.CheckBox();
            this.TipoDNIComboBox = new System.Windows.Forms.ComboBox();
            this.MatrículaTextBox = new System.Windows.Forms.TextBox();
            this.NumeroDNILabel = new System.Windows.Forms.CheckBox();
            this.NumeroDNITextBox = new System.Windows.Forms.TextBox();
            this.TipoDeDocumentoLabel = new System.Windows.Forms.CheckBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoLabel = new System.Windows.Forms.CheckBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.CheckBox();
            this.AceptarBoton = new System.Windows.Forms.Button();
            this.tablaRoles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaRoles);
            this.groupBox1.Controls.Add(this.CancelarBoton);
            this.groupBox1.Controls.Add(this.LimpiarBoton);
            this.groupBox1.Controls.Add(this.MatrículaLabel);
            this.groupBox1.Controls.Add(this.TipoDNIComboBox);
            this.groupBox1.Controls.Add(this.MatrículaTextBox);
            this.groupBox1.Controls.Add(this.NumeroDNILabel);
            this.groupBox1.Controls.Add(this.NumeroDNITextBox);
            this.groupBox1.Controls.Add(this.TipoDeDocumentoLabel);
            this.groupBox1.Controls.Add(this.ApellidoTextBox);
            this.groupBox1.Controls.Add(this.ApellidoLabel);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.NombreLabel);
            this.groupBox1.Controls.Add(this.AceptarBoton);
            this.groupBox1.Location = new System.Drawing.Point(25, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el/los campos a filtrar:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.BackColor = System.Drawing.Color.Brown;
            this.CancelarBoton.Location = new System.Drawing.Point(467, 369);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(93, 31);
            this.CancelarBoton.TabIndex = 42;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = false;
            // 
            // LimpiarBoton
            // 
            this.LimpiarBoton.Location = new System.Drawing.Point(467, 162);
            this.LimpiarBoton.Name = "LimpiarBoton";
            this.LimpiarBoton.Size = new System.Drawing.Size(84, 23);
            this.LimpiarBoton.TabIndex = 41;
            this.LimpiarBoton.Text = "Limpiar";
            this.LimpiarBoton.UseVisualStyleBackColor = true;
            // 
            // MatrículaLabel
            // 
            this.MatrículaLabel.AutoSize = true;
            this.MatrículaLabel.Location = new System.Drawing.Point(21, 139);
            this.MatrículaLabel.Name = "MatrículaLabel";
            this.MatrículaLabel.Size = new System.Drawing.Size(71, 17);
            this.MatrículaLabel.TabIndex = 40;
            this.MatrículaLabel.Text = "Matrícula";
            this.MatrículaLabel.UseVisualStyleBackColor = true;
            this.MatrículaLabel.CheckedChanged += new System.EventHandler(this.chMail_CheckedChanged);
            // 
            // TipoDNIComboBox
            // 
            this.TipoDNIComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDNIComboBox.FormattingEnabled = true;
            this.TipoDNIComboBox.Items.AddRange(new object[] {
            "CI",
            "DNI",
            "LC",
            "LE",
            "DU"});
            this.TipoDNIComboBox.Location = new System.Drawing.Point(37, 112);
            this.TipoDNIComboBox.Name = "TipoDNIComboBox";
            this.TipoDNIComboBox.Size = new System.Drawing.Size(237, 21);
            this.TipoDNIComboBox.TabIndex = 39;
            // 
            // MatrículaTextBox
            // 
            this.MatrículaTextBox.Location = new System.Drawing.Point(37, 162);
            this.MatrículaTextBox.Name = "MatrículaTextBox";
            this.MatrículaTextBox.Size = new System.Drawing.Size(237, 20);
            this.MatrículaTextBox.TabIndex = 10;
            // 
            // NumeroDNILabel
            // 
            this.NumeroDNILabel.AutoSize = true;
            this.NumeroDNILabel.Location = new System.Drawing.Point(305, 89);
            this.NumeroDNILabel.Name = "NumeroDNILabel";
            this.NumeroDNILabel.Size = new System.Drawing.Size(136, 17);
            this.NumeroDNILabel.TabIndex = 9;
            this.NumeroDNILabel.Text = "Número de Documento";
            this.NumeroDNILabel.UseVisualStyleBackColor = true;
            // 
            // NumeroDNITextBox
            // 
            this.NumeroDNITextBox.Location = new System.Drawing.Point(305, 113);
            this.NumeroDNITextBox.MaxLength = 8;
            this.NumeroDNITextBox.Name = "NumeroDNITextBox";
            this.NumeroDNITextBox.Size = new System.Drawing.Size(237, 20);
            this.NumeroDNITextBox.TabIndex = 8;
            // 
            // TipoDeDocumentoLabel
            // 
            this.TipoDeDocumentoLabel.AutoSize = true;
            this.TipoDeDocumentoLabel.Location = new System.Drawing.Point(16, 89);
            this.TipoDeDocumentoLabel.Name = "TipoDeDocumentoLabel";
            this.TipoDeDocumentoLabel.Size = new System.Drawing.Size(120, 17);
            this.TipoDeDocumentoLabel.TabIndex = 7;
            this.TipoDeDocumentoLabel.Text = "Tipo de Documento";
            this.TipoDeDocumentoLabel.UseVisualStyleBackColor = true;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(305, 62);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(237, 20);
            this.ApellidoTextBox.TabIndex = 6;
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(305, 39);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(63, 17);
            this.ApellidoLabel.TabIndex = 5;
            this.ApellidoLabel.Text = "Apellido";
            this.ApellidoLabel.UseVisualStyleBackColor = true;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(37, 63);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(237, 20);
            this.NombreTextBox.TabIndex = 4;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(21, 39);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(63, 17);
            this.NombreLabel.TabIndex = 3;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.UseVisualStyleBackColor = true;
            // 
            // AceptarBoton
            // 
            this.AceptarBoton.Location = new System.Drawing.Point(380, 162);
            this.AceptarBoton.Name = "AceptarBoton";
            this.AceptarBoton.Size = new System.Drawing.Size(81, 23);
            this.AceptarBoton.TabIndex = 2;
            this.AceptarBoton.Text = "Aceptar";
            this.AceptarBoton.UseVisualStyleBackColor = true;
            // 
            // tablaRoles
            // 
            this.tablaRoles.AllowUserToAddRows = false;
            this.tablaRoles.AllowUserToDeleteRows = false;
            this.tablaRoles.AllowUserToResizeColumns = false;
            this.tablaRoles.AllowUserToResizeRows = false;
            this.tablaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRoles.Location = new System.Drawing.Point(21, 213);
            this.tablaRoles.Name = "tablaRoles";
            this.tablaRoles.ReadOnly = true;
            this.tablaRoles.Size = new System.Drawing.Size(539, 150);
            this.tablaRoles.TabIndex = 43;
            // 
            // BajaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 429);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "BajaProfesional";
            this.Text = "Eliminar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.Button LimpiarBoton;
        private System.Windows.Forms.CheckBox MatrículaLabel;
        private System.Windows.Forms.ComboBox TipoDNIComboBox;
        private System.Windows.Forms.TextBox MatrículaTextBox;
        private System.Windows.Forms.CheckBox NumeroDNILabel;
        private System.Windows.Forms.TextBox NumeroDNITextBox;
        private System.Windows.Forms.CheckBox TipoDeDocumentoLabel;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.CheckBox ApellidoLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.CheckBox NombreLabel;
        private System.Windows.Forms.Button AceptarBoton;
        private System.Windows.Forms.DataGridView tablaRoles;

    }
}