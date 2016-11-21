namespace ClinicaFrba.Abm_Afiliado
{
    partial class ListadoAfiliadosBaja
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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tiposDeDocumentos
            // 
            this.tiposDeDocumentos.SelectedIndexChanged += new System.EventHandler(this.tiposDeDocumentos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seleccione afiliado para realizar la baja";
            // 
            // ListadoAfiliadosBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 354);
            this.Controls.Add(this.label5);
            this.Name = "ListadoAfiliadosBaja";
            this.Text = "ListadoAfiliadosBaja";
            this.Load += new System.EventHandler(this.ListadoAfiliadosBaja_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tiposDeDocumentos, 0);
            this.Controls.SetChildIndex(this.btnfiltrar, 0);
            this.Controls.SetChildIndex(this.btnlimpiar, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.apellido, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.numerodocumento, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
    }
}