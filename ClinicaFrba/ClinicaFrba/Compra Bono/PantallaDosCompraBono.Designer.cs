﻿namespace ClinicaFrba.Compra_Bono
{
    partial class PantallaDosCompraBono
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
            this.nombret = new System.Windows.Forms.Label();
            this.numeroafiliadot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preciobono = new System.Windows.Forms.Label();
            this.preciofinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de Bonos";
            // 
            // nombret
            // 
            this.nombret.AutoSize = true;
            this.nombret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombret.Location = new System.Drawing.Point(25, 56);
            this.nombret.Name = "nombret";
            this.nombret.Size = new System.Drawing.Size(108, 25);
            this.nombret.TabIndex = 1;
            this.nombret.Text = "Paciente: ";
            // 
            // numeroafiliadot
            // 
            this.numeroafiliadot.AutoSize = true;
            this.numeroafiliadot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroafiliadot.Location = new System.Drawing.Point(25, 81);
            this.numeroafiliadot.Name = "numeroafiliadot";
            this.numeroafiliadot.Size = new System.Drawing.Size(206, 25);
            this.numeroafiliadot.TabIndex = 2;
            this.numeroafiliadot.Text = "Numero de Afiliado: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar Operacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad de Bonos a comprar";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(346, 283);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 29;
            this.lineShape2.X2 = 320;
            this.lineShape2.Y1 = 172;
            this.lineShape2.Y2 = 172;
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(250, 113);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(70, 26);
            this.cantidad.TabIndex = 7;
            this.cantidad.Text = "0";
            this.cantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(25, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto a abonar: $";
            // 
            // preciobono
            // 
            this.preciobono.AutoSize = true;
            this.preciobono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciobono.ForeColor = System.Drawing.Color.Maroon;
            this.preciobono.Location = new System.Drawing.Point(202, 143);
            this.preciobono.Name = "preciobono";
            this.preciobono.Size = new System.Drawing.Size(0, 18);
            this.preciobono.TabIndex = 9;
            // 
            // preciofinal
            // 
            this.preciofinal.AutoSize = true;
            this.preciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciofinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.preciofinal.Location = new System.Drawing.Point(223, 180);
            this.preciofinal.Name = "preciofinal";
            this.preciofinal.Size = new System.Drawing.Size(25, 25);
            this.preciofinal.TabIndex = 10;
            this.preciofinal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio unitario por bono: ";
            // 
            // PantallaDosCompraBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preciofinal);
            this.Controls.Add(this.preciobono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeroafiliadot);
            this.Controls.Add(this.nombret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PantallaDosCompraBono";
            this.Text = "PantallaDosCompraBono";
            this.Load += new System.EventHandler(this.PantallaDosCompraBono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombret;
        private System.Windows.Forms.Label numeroafiliadot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label preciobono;
        private System.Windows.Forms.Label preciofinal;
        private System.Windows.Forms.Label label2;

    }
}