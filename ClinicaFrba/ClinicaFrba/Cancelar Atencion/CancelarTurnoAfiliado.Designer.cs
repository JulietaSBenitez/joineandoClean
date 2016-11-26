namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarTurnoAfiliado
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
            this.label3 = new System.Windows.Forms.Label();
            this.LimpiarDiaButton = new System.Windows.Forms.Button();
            this.EspecialidadMedicaCB = new System.Windows.Forms.ComboBox();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ListadoDGV = new System.Windows.Forms.DataGridView();
            this.ListadoTurnosLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalendarioTurnos = new System.Windows.Forms.MonthCalendar();
            this.ApellidoProfesionalTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreProfesionalTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LimpiarDiaButton);
            this.groupBox1.Controls.Add(this.EspecialidadMedicaCB);
            this.groupBox1.Controls.Add(this.FiltrarButton);
            this.groupBox1.Controls.Add(this.CancelarButton);
            this.groupBox1.Controls.Add(this.ListadoDGV);
            this.groupBox1.Controls.Add(this.ListadoTurnosLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CalendarioTurnos);
            this.groupBox1.Controls.Add(this.ApellidoProfesionalTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NombreProfesionalTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el turno a eliminar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido del Profesional:";
            // 
            // LimpiarDiaButton
            // 
            this.LimpiarDiaButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.LimpiarDiaButton.Location = new System.Drawing.Point(313, 183);
            this.LimpiarDiaButton.Name = "LimpiarDiaButton";
            this.LimpiarDiaButton.Size = new System.Drawing.Size(230, 43);
            this.LimpiarDiaButton.TabIndex = 17;
            this.LimpiarDiaButton.Text = "Limpiar Día";
            this.LimpiarDiaButton.UseVisualStyleBackColor = false;
            this.LimpiarDiaButton.Click += new System.EventHandler(this.LimpiarDiaButton_Click);
            // 
            // EspecialidadMedicaCB
            // 
            this.EspecialidadMedicaCB.FormattingEnabled = true;
            this.EspecialidadMedicaCB.Location = new System.Drawing.Point(267, 85);
            this.EspecialidadMedicaCB.Name = "EspecialidadMedicaCB";
            this.EspecialidadMedicaCB.Size = new System.Drawing.Size(276, 24);
            this.EspecialidadMedicaCB.TabIndex = 16;
            this.EspecialidadMedicaCB.SelectedIndexChanged += new System.EventHandler(this.EspecialidadCB_SelectedIndexChanged);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.BackColor = System.Drawing.Color.DarkOrange;
            this.FiltrarButton.Location = new System.Drawing.Point(313, 251);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(230, 43);
            this.FiltrarButton.TabIndex = 5;
            this.FiltrarButton.Text = "Buscar Turnos";
            this.FiltrarButton.UseVisualStyleBackColor = false;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarButton.Location = new System.Drawing.Point(492, 499);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(87, 31);
            this.CancelarButton.TabIndex = 11;
            this.CancelarButton.Text = "Volver";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ListadoDGV
            // 
            this.ListadoDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListadoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDGV.Location = new System.Drawing.Point(22, 365);
            this.ListadoDGV.MultiSelect = false;
            this.ListadoDGV.Name = "ListadoDGV";
            this.ListadoDGV.ReadOnly = true;
            this.ListadoDGV.Size = new System.Drawing.Size(545, 125);
            this.ListadoDGV.TabIndex = 10;
            this.ListadoDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDGV_CellContentDoubleClick);
            this.ListadoDGV.SelectionChanged += new System.EventHandler(this.ListadoDGV_SelectionChanged);
            // 
            // ListadoTurnosLabel
            // 
            this.ListadoTurnosLabel.AutoSize = true;
            this.ListadoTurnosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadoTurnosLabel.Location = new System.Drawing.Point(224, 344);
            this.ListadoTurnosLabel.Name = "ListadoTurnosLabel";
            this.ListadoTurnosLabel.Size = new System.Drawing.Size(150, 18);
            this.ListadoTurnosLabel.TabIndex = 9;
            this.ListadoTurnosLabel.Text = "Listado de sus turnos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione Día";
            // 
            // CalendarioTurnos
            // 
            this.CalendarioTurnos.Location = new System.Drawing.Point(64, 157);
            this.CalendarioTurnos.Name = "CalendarioTurnos";
            this.CalendarioTurnos.TabIndex = 5;
            this.CalendarioTurnos.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioTurnos_DateChanged);
            // 
            // ApellidoProfesionalTB
            // 
            this.ApellidoProfesionalTB.Location = new System.Drawing.Point(267, 59);
            this.ApellidoProfesionalTB.Name = "ApellidoProfesionalTB";
            this.ApellidoProfesionalTB.Size = new System.Drawing.Size(276, 22);
            this.ApellidoProfesionalTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especialidad Profesional:";
            // 
            // NombreProfesionalTB
            // 
            this.NombreProfesionalTB.Location = new System.Drawing.Point(267, 31);
            this.NombreProfesionalTB.Name = "NombreProfesionalTB";
            this.NombreProfesionalTB.Size = new System.Drawing.Size(276, 22);
            this.NombreProfesionalTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Profesional:";
            // 
            // CancelarTurnoAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 553);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarTurnoAfiliado";
            this.Text = "Cancelación de Turno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoProfesionalTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreProfesionalTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView ListadoDGV;
        private System.Windows.Forms.Label ListadoTurnosLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar CalendarioTurnos;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.ComboBox EspecialidadMedicaCB;
        private System.Windows.Forms.Button LimpiarDiaButton;
        private System.Windows.Forms.Label label3;
    }
}