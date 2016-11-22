namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarTurnoTipoRazon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CancelarTurnoBoton = new System.Windows.Forms.Button();
            this.VolverBoton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo De Cancelación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolverBoton);
            this.groupBox1.Controls.Add(this.CancelarTurnoBoton);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los campos a continuación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Cancelación:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 81);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // CancelarTurnoBoton
            // 
            this.CancelarTurnoBoton.Location = new System.Drawing.Point(238, 207);
            this.CancelarTurnoBoton.Name = "CancelarTurnoBoton";
            this.CancelarTurnoBoton.Size = new System.Drawing.Size(117, 30);
            this.CancelarTurnoBoton.TabIndex = 5;
            this.CancelarTurnoBoton.Text = "Cancelar Turno";
            this.CancelarTurnoBoton.UseVisualStyleBackColor = true;
            // 
            // VolverBoton
            // 
            this.VolverBoton.BackColor = System.Drawing.Color.IndianRed;
            this.VolverBoton.Location = new System.Drawing.Point(361, 207);
            this.VolverBoton.Name = "VolverBoton";
            this.VolverBoton.Size = new System.Drawing.Size(117, 30);
            this.VolverBoton.TabIndex = 6;
            this.VolverBoton.Text = "Volver";
            this.VolverBoton.UseVisualStyleBackColor = false;
            // 
            // CancelarTurnoTipoRazon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarTurnoTipoRazon";
            this.Text = "Tipo y Razón de la Cancelación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarTurnoBoton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VolverBoton;
    }
}