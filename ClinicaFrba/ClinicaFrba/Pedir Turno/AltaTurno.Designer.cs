using ClinicaFrba.src;

namespace ClinicaFrba.Pedir_Turno
{
    partial class AltaTurno
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
            this.SeleccionarEspecialidadGP = new System.Windows.Forms.GroupBox();
            this.ContinuarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ProfesionalCB = new System.Windows.Forms.ComboBox();
            this.ProfesionalText = new System.Windows.Forms.Label();
            this.EspecialidadMedicaCB = new System.Windows.Forms.ComboBox();
            this.EspecialidadMedicaText = new System.Windows.Forms.Label();
            this.SeleccionarEspecialidadGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeleccionarEspecialidadGP
            // 
            this.SeleccionarEspecialidadGP.Controls.Add(this.ContinuarButton);
            this.SeleccionarEspecialidadGP.Controls.Add(this.CancelarButton);
            this.SeleccionarEspecialidadGP.Controls.Add(this.ProfesionalCB);
            this.SeleccionarEspecialidadGP.Controls.Add(this.ProfesionalText);
            this.SeleccionarEspecialidadGP.Controls.Add(this.EspecialidadMedicaCB);
            this.SeleccionarEspecialidadGP.Controls.Add(this.EspecialidadMedicaText);
            this.SeleccionarEspecialidadGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarEspecialidadGP.Location = new System.Drawing.Point(12, 13);
            this.SeleccionarEspecialidadGP.Name = "SeleccionarEspecialidadGP";
            this.SeleccionarEspecialidadGP.Size = new System.Drawing.Size(486, 288);
            this.SeleccionarEspecialidadGP.TabIndex = 0;
            this.SeleccionarEspecialidadGP.TabStop = false;
            this.SeleccionarEspecialidadGP.Text = "Complete los campos a continuación:";
            // 
            // ContinuarButton
            // 
            this.ContinuarButton.Location = new System.Drawing.Point(300, 246);
            this.ContinuarButton.Name = "ContinuarButton";
            this.ContinuarButton.Size = new System.Drawing.Size(84, 32);
            this.ContinuarButton.TabIndex = 5;
            this.ContinuarButton.Text = "Continuar";
            this.ContinuarButton.UseVisualStyleBackColor = true;
            this.ContinuarButton.Click += new System.EventHandler(this.ContinuarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarButton.Location = new System.Drawing.Point(392, 246);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(84, 32);
            this.CancelarButton.TabIndex = 4;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            // 
            // ProfesionalCB
            // 
            this.ProfesionalCB.FormattingEnabled = true;
            this.ProfesionalCB.Location = new System.Drawing.Point(53, 180);
            this.ProfesionalCB.Name = "ProfesionalCB";
            this.ProfesionalCB.Size = new System.Drawing.Size(376, 24);
            this.ProfesionalCB.TabIndex = 3;
            // 
            // ProfesionalText
            // 
            this.ProfesionalText.AutoSize = true;
            this.ProfesionalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesionalText.Location = new System.Drawing.Point(205, 147);
            this.ProfesionalText.Name = "ProfesionalText";
            this.ProfesionalText.Size = new System.Drawing.Size(88, 20);
            this.ProfesionalText.TabIndex = 2;
            this.ProfesionalText.Text = "Profesional";
            // 
            // EspecialidadMedicaCB
            // 
            this.EspecialidadMedicaCB.FormattingEnabled = true;
            this.EspecialidadMedicaCB.Location = new System.Drawing.Point(53, 71);
            this.EspecialidadMedicaCB.Name = "EspecialidadMedicaCB";
            this.EspecialidadMedicaCB.Size = new System.Drawing.Size(376, 24);
            this.EspecialidadMedicaCB.TabIndex = 1;
            this.EspecialidadMedicaCB.SelectedIndexChanged += new System.EventHandler(this.EspecialidadMedicaCB_SelectedIndexChanged);
            // 
            // EspecialidadMedicaText
            // 
            this.EspecialidadMedicaText.AutoSize = true;
            this.EspecialidadMedicaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecialidadMedicaText.Location = new System.Drawing.Point(173, 38);
            this.EspecialidadMedicaText.Name = "EspecialidadMedicaText";
            this.EspecialidadMedicaText.Size = new System.Drawing.Size(154, 20);
            this.EspecialidadMedicaText.TabIndex = 0;
            this.EspecialidadMedicaText.Text = "Especialidad Medica";
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 308);
            this.Controls.Add(this.SeleccionarEspecialidadGP);
            this.MaximizeBox = false;
            this.Name = "AltaTurno";
            this.Text = "Selección de Médico y Especialidad";
            this.SeleccionarEspecialidadGP.ResumeLayout(false);
            this.SeleccionarEspecialidadGP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeleccionarEspecialidadGP;
        private System.Windows.Forms.Label EspecialidadMedicaText;
        private System.Windows.Forms.Button ContinuarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ComboBox ProfesionalCB;
        private System.Windows.Forms.Label ProfesionalText;
        private System.Windows.Forms.ComboBox EspecialidadMedicaCB;

        public System.EventHandler FormTurnos_Load { get; set; }
    }
}