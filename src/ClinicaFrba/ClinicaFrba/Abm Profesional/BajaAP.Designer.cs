namespace ClinicaFrba.RegistrarAgendaMedico
{
    partial class BajaAP
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
            this.AgendaTabla = new System.Windows.Forms.DataGridView();
            this.NombreMedicoLabel = new System.Windows.Forms.Label();
            this.EspecialidadMedicoLabel = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.EspecialidadTB = new System.Windows.Forms.TextBox();
            this.BotonLimpiarRoles = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelarBoton);
            this.groupBox1.Controls.Add(this.BotonLimpiarRoles);
            this.groupBox1.Controls.Add(this.EspecialidadTB);
            this.groupBox1.Controls.Add(this.NombreTB);
            this.groupBox1.Controls.Add(this.EspecialidadMedicoLabel);
            this.groupBox1.Controls.Add(this.NombreMedicoLabel);
            this.groupBox1.Controls.Add(this.AgendaTabla);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la agenda a eliminar:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AgendaTabla
            // 
            this.AgendaTabla.AllowUserToAddRows = false;
            this.AgendaTabla.AllowUserToDeleteRows = false;
            this.AgendaTabla.AllowUserToResizeColumns = false;
            this.AgendaTabla.AllowUserToResizeRows = false;
            this.AgendaTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgendaTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AgendaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendaTabla.Location = new System.Drawing.Point(6, 122);
            this.AgendaTabla.Name = "AgendaTabla";
            this.AgendaTabla.ReadOnly = true;
            this.AgendaTabla.Size = new System.Drawing.Size(489, 186);
            this.AgendaTabla.TabIndex = 1;
            // 
            // NombreMedicoLabel
            // 
            this.NombreMedicoLabel.AutoSize = true;
            this.NombreMedicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMedicoLabel.Location = new System.Drawing.Point(17, 50);
            this.NombreMedicoLabel.Name = "NombreMedicoLabel";
            this.NombreMedicoLabel.Size = new System.Drawing.Size(111, 17);
            this.NombreMedicoLabel.TabIndex = 2;
            this.NombreMedicoLabel.Text = "Nombre Médico:";
            this.NombreMedicoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EspecialidadMedicoLabel
            // 
            this.EspecialidadMedicoLabel.AutoSize = true;
            this.EspecialidadMedicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecialidadMedicoLabel.Location = new System.Drawing.Point(17, 82);
            this.EspecialidadMedicoLabel.Name = "EspecialidadMedicoLabel";
            this.EspecialidadMedicoLabel.Size = new System.Drawing.Size(92, 17);
            this.EspecialidadMedicoLabel.TabIndex = 3;
            this.EspecialidadMedicoLabel.Text = "Especialidad:";
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(146, 47);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(320, 20);
            this.NombreTB.TabIndex = 4;
            // 
            // EspecialidadTB
            // 
            this.EspecialidadTB.Location = new System.Drawing.Point(146, 79);
            this.EspecialidadTB.Name = "EspecialidadTB";
            this.EspecialidadTB.Size = new System.Drawing.Size(320, 20);
            this.EspecialidadTB.TabIndex = 5;
            // 
            // BotonLimpiarRoles
            // 
            this.BotonLimpiarRoles.Location = new System.Drawing.Point(6, 327);
            this.BotonLimpiarRoles.Name = "BotonLimpiarRoles";
            this.BotonLimpiarRoles.Size = new System.Drawing.Size(95, 38);
            this.BotonLimpiarRoles.TabIndex = 7;
            this.BotonLimpiarRoles.Text = "Limpiar";
            this.BotonLimpiarRoles.UseVisualStyleBackColor = true;
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarBoton.Location = new System.Drawing.Point(397, 327);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(98, 38);
            this.CancelarBoton.TabIndex = 8;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = false;
            // 
            // BajaAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaAP";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EspecialidadMedicoLabel;
        private System.Windows.Forms.Label NombreMedicoLabel;
        private System.Windows.Forms.DataGridView AgendaTabla;
        private System.Windows.Forms.TextBox EspecialidadTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Button BotonLimpiarRoles;
        private System.Windows.Forms.Button CancelarBoton;
    }
}