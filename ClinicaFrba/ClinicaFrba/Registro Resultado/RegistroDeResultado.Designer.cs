namespace ClinicaFrba.Registro_Resultado
{
    partial class RegistroDeResultado
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
            this.sintomas = new System.Windows.Forms.ListBox();
            this.sintoma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enfermedad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diagnostico = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nnombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sintomas
            // 
            this.sintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sintomas.FormattingEnabled = true;
            this.sintomas.ItemHeight = 16;
            this.sintomas.Location = new System.Drawing.Point(12, 254);
            this.sintomas.Name = "sintomas";
            this.sintomas.Size = new System.Drawing.Size(601, 84);
            this.sintomas.TabIndex = 1;
            this.sintomas.SelectedIndexChanged += new System.EventHandler(this.sintomas_SelectedIndexChanged);
            // 
            // sintoma
            // 
            this.sintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sintoma.Location = new System.Drawing.Point(12, 207);
            this.sintoma.Name = "sintoma";
            this.sintoma.Size = new System.Drawing.Size(454, 22);
            this.sintoma.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Agregar Sintoma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista Sintomas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enfermedad";
            // 
            // enfermedad
            // 
            this.enfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enfermedad.Location = new System.Drawing.Point(12, 59);
            this.enfermedad.Name = "enfermedad";
            this.enfermedad.Size = new System.Drawing.Size(601, 22);
            this.enfermedad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diagnostico";
            // 
            // diagnostico
            // 
            this.diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnostico.Location = new System.Drawing.Point(9, 105);
            this.diagnostico.MaxLength = 250;
            this.diagnostico.Multiline = true;
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.Size = new System.Drawing.Size(604, 79);
            this.diagnostico.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(472, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nnombre
            // 
            this.nnombre.AutoSize = true;
            this.nnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nnombre.Location = new System.Drawing.Point(12, 4);
            this.nnombre.Name = "nnombre";
            this.nnombre.Size = new System.Drawing.Size(257, 29);
            this.nnombre.TabIndex = 15;
            this.nnombre.Text = "Paciente rodolfo casas";
            // 
            // RegistroDeResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 391);
            this.Controls.Add(this.nnombre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diagnostico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enfermedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sintoma);
            this.Controls.Add(this.sintomas);
            this.Name = "RegistroDeResultado";
            this.Text = "Registro de resultados";
            this.Load += new System.EventHandler(this.RegistroDeResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sintomas;
        private System.Windows.Forms.TextBox sintoma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enfermedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diagnostico;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label nnombre;

    }
}