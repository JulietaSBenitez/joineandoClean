namespace ClinicaFrba.RegistrarAgendaMedico
{
    partial class PantallaDeSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeSeleccion));
            this.ModificarProfesionalIcono = new System.Windows.Forms.PictureBox();
            this.AgregarProfesionalIcono = new System.Windows.Forms.PictureBox();
            this.EliminarProfesionalIcono = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarProfesionalTexto = new System.Windows.Forms.Label();
            this.ModificarProfesionalTexto = new System.Windows.Forms.Label();
            this.EliminarProfesionalTexto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ModificarProfesionalIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarProfesionalIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarProfesionalIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificarProfesionalIcono
            // 
            this.ModificarProfesionalIcono.Image = ((System.Drawing.Image)(resources.GetObject("ModificarProfesionalIcono.Image")));
            this.ModificarProfesionalIcono.Location = new System.Drawing.Point(256, 66);
            this.ModificarProfesionalIcono.Name = "ModificarProfesionalIcono";
            this.ModificarProfesionalIcono.Size = new System.Drawing.Size(145, 151);
            this.ModificarProfesionalIcono.TabIndex = 0;
            this.ModificarProfesionalIcono.TabStop = false;
            // 
            // AgregarProfesionalIcono
            // 
            this.AgregarProfesionalIcono.Image = ((System.Drawing.Image)(resources.GetObject("AgregarProfesionalIcono.Image")));
            this.AgregarProfesionalIcono.Location = new System.Drawing.Point(41, 66);
            this.AgregarProfesionalIcono.Name = "AgregarProfesionalIcono";
            this.AgregarProfesionalIcono.Size = new System.Drawing.Size(153, 151);
            this.AgregarProfesionalIcono.TabIndex = 1;
            this.AgregarProfesionalIcono.TabStop = false;
            // 
            // EliminarProfesionalIcono
            // 
            this.EliminarProfesionalIcono.Image = ((System.Drawing.Image)(resources.GetObject("EliminarProfesionalIcono.Image")));
            this.EliminarProfesionalIcono.Location = new System.Drawing.Point(467, 66);
            this.EliminarProfesionalIcono.Name = "EliminarProfesionalIcono";
            this.EliminarProfesionalIcono.Size = new System.Drawing.Size(146, 151);
            this.EliminarProfesionalIcono.TabIndex = 2;
            this.EliminarProfesionalIcono.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la opción deseada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AgregarProfesionalTexto
            // 
            this.AgregarProfesionalTexto.AutoSize = true;
            this.AgregarProfesionalTexto.Location = new System.Drawing.Point(66, 204);
            this.AgregarProfesionalTexto.Name = "AgregarProfesionalTexto";
            this.AgregarProfesionalTexto.Size = new System.Drawing.Size(99, 13);
            this.AgregarProfesionalTexto.TabIndex = 4;
            this.AgregarProfesionalTexto.Text = "Agregar Profesional";
            this.AgregarProfesionalTexto.Click += new System.EventHandler(this.label2_Click);
            // 
            // ModificarProfesionalTexto
            // 
            this.ModificarProfesionalTexto.AutoSize = true;
            this.ModificarProfesionalTexto.Location = new System.Drawing.Point(277, 204);
            this.ModificarProfesionalTexto.Name = "ModificarProfesionalTexto";
            this.ModificarProfesionalTexto.Size = new System.Drawing.Size(105, 13);
            this.ModificarProfesionalTexto.TabIndex = 5;
            this.ModificarProfesionalTexto.Text = "Modificar Profesional";
            this.ModificarProfesionalTexto.Click += new System.EventHandler(this.label3_Click);
            // 
            // EliminarProfesionalTexto
            // 
            this.EliminarProfesionalTexto.AutoSize = true;
            this.EliminarProfesionalTexto.Location = new System.Drawing.Point(493, 204);
            this.EliminarProfesionalTexto.Name = "EliminarProfesionalTexto";
            this.EliminarProfesionalTexto.Size = new System.Drawing.Size(98, 13);
            this.EliminarProfesionalTexto.TabIndex = 6;
            this.EliminarProfesionalTexto.Text = "Eliminar Profesional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(198, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sección EN CONSTRUCCIÓN";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // PantallaDeSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarProfesionalTexto);
            this.Controls.Add(this.ModificarProfesionalTexto);
            this.Controls.Add(this.AgregarProfesionalTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarProfesionalIcono);
            this.Controls.Add(this.AgregarProfesionalIcono);
            this.Controls.Add(this.ModificarProfesionalIcono);
            this.MaximizeBox = false;
            this.Name = "PantallaDeSeleccion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Seleccionar Opcion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModificarProfesionalIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarProfesionalIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarProfesionalIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ModificarProfesionalIcono;
        private System.Windows.Forms.PictureBox AgregarProfesionalIcono;
        private System.Windows.Forms.PictureBox EliminarProfesionalIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AgregarProfesionalTexto;
        private System.Windows.Forms.Label ModificarProfesionalTexto;
        private System.Windows.Forms.Label EliminarProfesionalTexto;
        private System.Windows.Forms.Label label2;
    }
}