namespace ClinicaFrba.Abm_Afiliado
{
    partial class HistorialCambiosPlan
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
            this.tablahistorial = new System.Windows.Forms.DataGridView();
            this.afiliado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablahistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // tablahistorial
            // 
            this.tablahistorial.AllowUserToAddRows = false;
            this.tablahistorial.AllowUserToDeleteRows = false;
            this.tablahistorial.AllowUserToResizeColumns = false;
            this.tablahistorial.AllowUserToResizeRows = false;
            this.tablahistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablahistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablahistorial.Location = new System.Drawing.Point(12, 13);
            this.tablahistorial.Name = "tablahistorial";
            this.tablahistorial.ReadOnly = true;
            this.tablahistorial.Size = new System.Drawing.Size(557, 247);
            this.tablahistorial.TabIndex = 0;
            this.tablahistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablahistorial_CellContentClick);
            // 
            // afiliado
            // 
            this.afiliado.AutoSize = true;
            this.afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afiliado.Location = new System.Drawing.Point(12, 9);
            this.afiliado.Name = "afiliado";
            this.afiliado.Size = new System.Drawing.Size(0, 25);
            this.afiliado.TabIndex = 1;
            // 
            // HistorialCambiosPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 272);
            this.Controls.Add(this.afiliado);
            this.Controls.Add(this.tablahistorial);
            this.Name = "HistorialCambiosPlan";
            this.Text = "Historial de Cambios de plan medico";
            this.Load += new System.EventHandler(this.HistorialCambiosPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablahistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label afiliado;
        private System.Windows.Forms.DataGridView tablahistorial;
    }
}