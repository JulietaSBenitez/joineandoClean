﻿namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarTurnoProfesionalHorario
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ListadoDGV = new System.Windows.Forms.DataGridView();
            this.ListadoTurnosLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TurnosDisponibles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.NombreProfesionalTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelarButton);
            this.groupBox1.Controls.Add(this.ListadoDGV);
            this.groupBox1.Controls.Add(this.ListadoTurnosLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TurnosDisponibles);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.NombreProfesionalTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el turno a eliminar:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarButton.Location = new System.Drawing.Point(390, 497);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(87, 31);
            this.CancelarButton.TabIndex = 11;
            this.CancelarButton.Text = "Volver";
            this.CancelarButton.UseVisualStyleBackColor = false;
            // 
            // ListadoDGV
            // 
            this.ListadoDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListadoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDGV.Location = new System.Drawing.Point(28, 355);
            this.ListadoDGV.MultiSelect = false;
            this.ListadoDGV.Name = "ListadoDGV";
            this.ListadoDGV.ReadOnly = true;
            this.ListadoDGV.Size = new System.Drawing.Size(426, 125);
            this.ListadoDGV.TabIndex = 10;
            // 
            // ListadoTurnosLabel
            // 
            this.ListadoTurnosLabel.AutoSize = true;
            this.ListadoTurnosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadoTurnosLabel.Location = new System.Drawing.Point(160, 324);
            this.ListadoTurnosLabel.Name = "ListadoTurnosLabel";
            this.ListadoTurnosLabel.Size = new System.Drawing.Size(150, 18);
            this.ListadoTurnosLabel.TabIndex = 9;
            this.ListadoTurnosLabel.Text = "Listado de sus turnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione Horario";
            // 
            // TurnosDisponibles
            // 
            this.TurnosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TurnosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnosDisponibles.Location = new System.Drawing.Point(316, 124);
            this.TurnosDisponibles.MultiSelect = false;
            this.TurnosDisponibles.Name = "TurnosDisponibles";
            this.TurnosDisponibles.ReadOnly = true;
            this.TurnosDisponibles.Size = new System.Drawing.Size(132, 162);
            this.TurnosDisponibles.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione Día";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 124);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // NombreProfesionalTB
            // 
            this.NombreProfesionalTB.Location = new System.Drawing.Point(208, 35);
            this.NombreProfesionalTB.Name = "NombreProfesionalTB";
            this.NombreProfesionalTB.Size = new System.Drawing.Size(240, 22);
            this.NombreProfesionalTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Paciente:";
            // 
            // CancelarTurnoProfesionalHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 553);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarTurnoProfesionalHorario";
            this.Text = "Cancelar Turno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnosDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView ListadoDGV;
        private System.Windows.Forms.Label ListadoTurnosLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TurnosDisponibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox NombreProfesionalTB;
        private System.Windows.Forms.Label label1;
    }
}