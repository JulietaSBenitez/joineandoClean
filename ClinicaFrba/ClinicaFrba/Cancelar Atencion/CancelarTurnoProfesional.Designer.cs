namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarTurnoProfesional
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
            this.VolverButton = new System.Windows.Forms.Button();
            this.CancelarTurnosButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CalendarioProfesional = new System.Windows.Forms.MonthCalendar();
            this.ListadoDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListadoDGV);
            this.groupBox1.Controls.Add(this.VolverButton);
            this.groupBox1.Controls.Add(this.CancelarTurnosButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CalendarioProfesional);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // VolverButton
            // 
            this.VolverButton.BackColor = System.Drawing.Color.IndianRed;
            this.VolverButton.Location = new System.Drawing.Point(381, 379);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(105, 30);
            this.VolverButton.TabIndex = 9;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = false;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // CancelarTurnosButton
            // 
            this.CancelarTurnosButton.Location = new System.Drawing.Point(262, 379);
            this.CancelarTurnosButton.Name = "CancelarTurnosButton";
            this.CancelarTurnosButton.Size = new System.Drawing.Size(105, 30);
            this.CancelarTurnosButton.TabIndex = 1;
            this.CancelarTurnosButton.Text = "Cancelar Turno/s";
            this.CancelarTurnosButton.UseVisualStyleBackColor = true;
            this.CancelarTurnosButton.Click += new System.EventHandler(this.CancelarTurnosButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccione Día/s";
            // 
            // CalendarioProfesional
            // 
            this.CalendarioProfesional.Location = new System.Drawing.Point(160, 59);
            this.CalendarioProfesional.Name = "CalendarioProfesional";
            this.CalendarioProfesional.TabIndex = 7;
            // 
            // ListadoDGV
            // 
            this.ListadoDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListadoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDGV.Location = new System.Drawing.Point(21, 241);
            this.ListadoDGV.MultiSelect = false;
            this.ListadoDGV.Name = "ListadoDGV";
            this.ListadoDGV.ReadOnly = true;
            this.ListadoDGV.Size = new System.Drawing.Size(450, 125);
            this.ListadoDGV.TabIndex = 11;
            // 
            // CancelarTurnoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 439);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarTurnoProfesional";
            this.Text = "Cancelar Turno de un dia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarTurnosButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar CalendarioProfesional;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.DataGridView ListadoDGV;
    }
}