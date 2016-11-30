namespace ClinicaFrba.RegistrarAgendaMedico
{
    partial class AltaAP
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
            this.asd = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonVolverAgenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sabadoAgendaCB = new System.Windows.Forms.CheckBox();
            this.viernesAgendaCB = new System.Windows.Forms.CheckBox();
            this.juevesAgendaCB = new System.Windows.Forms.CheckBox();
            this.miercolesAgendaCB = new System.Windows.Forms.CheckBox();
            this.martesAgendaCB = new System.Windows.Forms.CheckBox();
            this.lunesAgendaCB = new System.Windows.Forms.CheckBox();
            this.comboBoxFinSabado = new System.Windows.Forms.ComboBox();
            this.comboBoxInicioSabado = new System.Windows.Forms.ComboBox();
            this.comboBoxInicioViernes = new System.Windows.Forms.ComboBox();
            this.comboBoxInicioJueves = new System.Windows.Forms.ComboBox();
            this.comboBoxFinLunes = new System.Windows.Forms.ComboBox();
            this.comboBoxInicioMartes = new System.Windows.Forms.ComboBox();
            this.comboBoxFinMartes = new System.Windows.Forms.ComboBox();
            this.comboBoxFinJueves = new System.Windows.Forms.ComboBox();
            this.comboBoxFinViernes = new System.Windows.Forms.ComboBox();
            this.comboBoxInicioMiercoles = new System.Windows.Forms.ComboBox();
            this.comboBoxFinMiercoles = new System.Windows.Forms.ComboBox();
            this.comboBoxInicioLunes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.especialidadesAgendaCB = new System.Windows.Forms.ComboBox();
            this.EspecialidadLabel = new System.Windows.Forms.Label();
            this.asd.SuspendLayout();
            this.SuspendLayout();
            // 
            // asd
            // 
            this.asd.Controls.Add(this.label5);
            this.asd.Controls.Add(this.label4);
            this.asd.Controls.Add(this.botonVolverAgenda);
            this.asd.Controls.Add(this.button1);
            this.asd.Controls.Add(this.label3);
            this.asd.Controls.Add(this.label2);
            this.asd.Controls.Add(this.sabadoAgendaCB);
            this.asd.Controls.Add(this.viernesAgendaCB);
            this.asd.Controls.Add(this.juevesAgendaCB);
            this.asd.Controls.Add(this.miercolesAgendaCB);
            this.asd.Controls.Add(this.martesAgendaCB);
            this.asd.Controls.Add(this.lunesAgendaCB);
            this.asd.Controls.Add(this.comboBoxFinSabado);
            this.asd.Controls.Add(this.comboBoxInicioSabado);
            this.asd.Controls.Add(this.comboBoxInicioViernes);
            this.asd.Controls.Add(this.comboBoxInicioJueves);
            this.asd.Controls.Add(this.comboBoxFinLunes);
            this.asd.Controls.Add(this.comboBoxInicioMartes);
            this.asd.Controls.Add(this.comboBoxFinMartes);
            this.asd.Controls.Add(this.comboBoxFinJueves);
            this.asd.Controls.Add(this.comboBoxFinViernes);
            this.asd.Controls.Add(this.comboBoxInicioMiercoles);
            this.asd.Controls.Add(this.comboBoxFinMiercoles);
            this.asd.Controls.Add(this.comboBoxInicioLunes);
            this.asd.Controls.Add(this.label1);
            this.asd.Controls.Add(this.especialidadesAgendaCB);
            this.asd.Controls.Add(this.EspecialidadLabel);
            this.asd.Location = new System.Drawing.Point(13, 13);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(449, 352);
            this.asd.TabIndex = 0;
            this.asd.TabStop = false;
            this.asd.Text = "Complete los campos para crear un nueva agenda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = " * Si no aparece especialidad alguna es porque ya tiene una agenda para todas sus" +
    " especialidades.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // botonVolverAgenda
            // 
            this.botonVolverAgenda.BackColor = System.Drawing.Color.IndianRed;
            this.botonVolverAgenda.Location = new System.Drawing.Point(368, 318);
            this.botonVolverAgenda.Name = "botonVolverAgenda";
            this.botonVolverAgenda.Size = new System.Drawing.Size(75, 23);
            this.botonVolverAgenda.TabIndex = 24;
            this.botonVolverAgenda.Text = "Volver";
            this.botonVolverAgenda.UseVisualStyleBackColor = false;
            this.botonVolverAgenda.Click += new System.EventHandler(this.botonVolverAgenda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fin Rango";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Inicio Rango";
            // 
            // sabadoAgendaCB
            // 
            this.sabadoAgendaCB.AutoSize = true;
            this.sabadoAgendaCB.Location = new System.Drawing.Point(28, 273);
            this.sabadoAgendaCB.Name = "sabadoAgendaCB";
            this.sabadoAgendaCB.Size = new System.Drawing.Size(63, 17);
            this.sabadoAgendaCB.TabIndex = 20;
            this.sabadoAgendaCB.Text = "Sábado";
            this.sabadoAgendaCB.UseVisualStyleBackColor = true;
            this.sabadoAgendaCB.CheckedChanged += new System.EventHandler(this.SabadoAgendaCB_CheckedChanged);
            // 
            // viernesAgendaCB
            // 
            this.viernesAgendaCB.AutoSize = true;
            this.viernesAgendaCB.Location = new System.Drawing.Point(28, 246);
            this.viernesAgendaCB.Name = "viernesAgendaCB";
            this.viernesAgendaCB.Size = new System.Drawing.Size(61, 17);
            this.viernesAgendaCB.TabIndex = 19;
            this.viernesAgendaCB.Text = "Viernes";
            this.viernesAgendaCB.UseVisualStyleBackColor = true;
            this.viernesAgendaCB.CheckedChanged += new System.EventHandler(this.ViernesAgendaCB_CheckedChanged);
            // 
            // juevesAgendaCB
            // 
            this.juevesAgendaCB.AutoSize = true;
            this.juevesAgendaCB.Location = new System.Drawing.Point(28, 219);
            this.juevesAgendaCB.Name = "juevesAgendaCB";
            this.juevesAgendaCB.Size = new System.Drawing.Size(60, 17);
            this.juevesAgendaCB.TabIndex = 18;
            this.juevesAgendaCB.Text = "Jueves";
            this.juevesAgendaCB.UseVisualStyleBackColor = true;
            this.juevesAgendaCB.CheckedChanged += new System.EventHandler(this.JuevesAgendaCB_CheckedChanged);
            // 
            // miercolesAgendaCB
            // 
            this.miercolesAgendaCB.AutoSize = true;
            this.miercolesAgendaCB.Location = new System.Drawing.Point(28, 192);
            this.miercolesAgendaCB.Name = "miercolesAgendaCB";
            this.miercolesAgendaCB.Size = new System.Drawing.Size(71, 17);
            this.miercolesAgendaCB.TabIndex = 17;
            this.miercolesAgendaCB.Text = "Miércoles";
            this.miercolesAgendaCB.UseVisualStyleBackColor = true;
            this.miercolesAgendaCB.CheckedChanged += new System.EventHandler(this.MiercolesAgendaCB_CheckedChanged);
            // 
            // martesAgendaCB
            // 
            this.martesAgendaCB.AutoSize = true;
            this.martesAgendaCB.Location = new System.Drawing.Point(28, 165);
            this.martesAgendaCB.Name = "martesAgendaCB";
            this.martesAgendaCB.Size = new System.Drawing.Size(58, 17);
            this.martesAgendaCB.TabIndex = 16;
            this.martesAgendaCB.Text = "Martes";
            this.martesAgendaCB.UseVisualStyleBackColor = true;
            this.martesAgendaCB.CheckedChanged += new System.EventHandler(this.MartesAgendaCB_CheckedChanged);
            // 
            // lunesAgendaCB
            // 
            this.lunesAgendaCB.AutoSize = true;
            this.lunesAgendaCB.Location = new System.Drawing.Point(28, 137);
            this.lunesAgendaCB.Name = "lunesAgendaCB";
            this.lunesAgendaCB.Size = new System.Drawing.Size(55, 17);
            this.lunesAgendaCB.TabIndex = 15;
            this.lunesAgendaCB.Text = "Lunes";
            this.lunesAgendaCB.UseVisualStyleBackColor = true;
            this.lunesAgendaCB.CheckedChanged += new System.EventHandler(this.LunesAgendaCB_CheckedChanged);
            // 
            // comboBoxFinSabado
            // 
            this.comboBoxFinSabado.FormattingEnabled = true;
            this.comboBoxFinSabado.Location = new System.Drawing.Point(322, 269);
            this.comboBoxFinSabado.Name = "comboBoxFinSabado";
            this.comboBoxFinSabado.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFinSabado.TabIndex = 14;
            // 
            // comboBoxInicioSabado
            // 
            this.comboBoxInicioSabado.FormattingEnabled = true;
            this.comboBoxInicioSabado.Location = new System.Drawing.Point(197, 269);
            this.comboBoxInicioSabado.Name = "comboBoxInicioSabado";
            this.comboBoxInicioSabado.Size = new System.Drawing.Size(64, 21);
            this.comboBoxInicioSabado.TabIndex = 13;
            // 
            // comboBoxInicioViernes
            // 
            this.comboBoxInicioViernes.FormattingEnabled = true;
            this.comboBoxInicioViernes.Location = new System.Drawing.Point(197, 242);
            this.comboBoxInicioViernes.Name = "comboBoxInicioViernes";
            this.comboBoxInicioViernes.Size = new System.Drawing.Size(64, 21);
            this.comboBoxInicioViernes.TabIndex = 12;
            // 
            // comboBoxInicioJueves
            // 
            this.comboBoxInicioJueves.FormattingEnabled = true;
            this.comboBoxInicioJueves.Location = new System.Drawing.Point(197, 215);
            this.comboBoxInicioJueves.Name = "comboBoxInicioJueves";
            this.comboBoxInicioJueves.Size = new System.Drawing.Size(64, 21);
            this.comboBoxInicioJueves.TabIndex = 11;
            // 
            // comboBoxFinLunes
            // 
            this.comboBoxFinLunes.FormattingEnabled = true;
            this.comboBoxFinLunes.Location = new System.Drawing.Point(322, 134);
            this.comboBoxFinLunes.Name = "comboBoxFinLunes";
            this.comboBoxFinLunes.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFinLunes.TabIndex = 10;
            // 
            // comboBoxInicioMartes
            // 
            this.comboBoxInicioMartes.FormattingEnabled = true;
            this.comboBoxInicioMartes.Location = new System.Drawing.Point(197, 161);
            this.comboBoxInicioMartes.Name = "comboBoxInicioMartes";
            this.comboBoxInicioMartes.Size = new System.Drawing.Size(64, 21);
            this.comboBoxInicioMartes.TabIndex = 9;
            // 
            // comboBoxFinMartes
            // 
            this.comboBoxFinMartes.FormattingEnabled = true;
            this.comboBoxFinMartes.Location = new System.Drawing.Point(322, 161);
            this.comboBoxFinMartes.Name = "comboBoxFinMartes";
            this.comboBoxFinMartes.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFinMartes.TabIndex = 8;
            // 
            // comboBoxFinJueves
            // 
            this.comboBoxFinJueves.FormattingEnabled = true;
            this.comboBoxFinJueves.Location = new System.Drawing.Point(322, 215);
            this.comboBoxFinJueves.Name = "comboBoxFinJueves";
            this.comboBoxFinJueves.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFinJueves.TabIndex = 7;
            // 
            // comboBoxFinViernes
            // 
            this.comboBoxFinViernes.FormattingEnabled = true;
            this.comboBoxFinViernes.Location = new System.Drawing.Point(322, 242);
            this.comboBoxFinViernes.Name = "comboBoxFinViernes";
            this.comboBoxFinViernes.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFinViernes.TabIndex = 6;
            // 
            // comboBoxInicioMiercoles
            // 
            this.comboBoxInicioMiercoles.FormattingEnabled = true;
            this.comboBoxInicioMiercoles.Location = new System.Drawing.Point(197, 188);
            this.comboBoxInicioMiercoles.Name = "comboBoxInicioMiercoles";
            this.comboBoxInicioMiercoles.Size = new System.Drawing.Size(64, 21);
            this.comboBoxInicioMiercoles.TabIndex = 5;
            // 
            // comboBoxFinMiercoles
            // 
            this.comboBoxFinMiercoles.FormattingEnabled = true;
            this.comboBoxFinMiercoles.Location = new System.Drawing.Point(322, 188);
            this.comboBoxFinMiercoles.Name = "comboBoxFinMiercoles";
            this.comboBoxFinMiercoles.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFinMiercoles.TabIndex = 4;
            // 
            // comboBoxInicioLunes
            // 
            this.comboBoxInicioLunes.FormattingEnabled = true;
            this.comboBoxInicioLunes.Location = new System.Drawing.Point(197, 134);
            this.comboBoxInicioLunes.Name = "comboBoxInicioLunes";
            this.comboBoxInicioLunes.Size = new System.Drawing.Size(64, 21);
            this.comboBoxInicioLunes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Día";
            // 
            // especialidadesAgendaCB
            // 
            this.especialidadesAgendaCB.FormattingEnabled = true;
            this.especialidadesAgendaCB.Location = new System.Drawing.Point(159, 41);
            this.especialidadesAgendaCB.Name = "especialidadesAgendaCB";
            this.especialidadesAgendaCB.Size = new System.Drawing.Size(266, 21);
            this.especialidadesAgendaCB.TabIndex = 1;
            // 
            // EspecialidadLabel
            // 
            this.EspecialidadLabel.AutoSize = true;
            this.EspecialidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspecialidadLabel.Location = new System.Drawing.Point(25, 42);
            this.EspecialidadLabel.Name = "EspecialidadLabel";
            this.EspecialidadLabel.Size = new System.Drawing.Size(92, 17);
            this.EspecialidadLabel.TabIndex = 0;
            this.EspecialidadLabel.Text = "Especialidad:";
            // 
            // AltaAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 377);
            this.Controls.Add(this.asd);
            this.Name = "AltaAP";
            this.Text = "Crear Agenda Profesional";
            this.Load += new System.EventHandler(this.AltaAP_Load);
            this.asd.ResumeLayout(false);
            this.asd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox asd;
        private System.Windows.Forms.Label EspecialidadLabel;
        private System.Windows.Forms.ComboBox especialidadesAgendaCB;
        private System.Windows.Forms.ComboBox comboBoxInicioLunes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVolverAgenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox sabadoAgendaCB;
        private System.Windows.Forms.CheckBox viernesAgendaCB;
        private System.Windows.Forms.CheckBox juevesAgendaCB;
        private System.Windows.Forms.CheckBox miercolesAgendaCB;
        private System.Windows.Forms.CheckBox martesAgendaCB;
        private System.Windows.Forms.CheckBox lunesAgendaCB;
        private System.Windows.Forms.ComboBox comboBoxFinSabado;
        private System.Windows.Forms.ComboBox comboBoxInicioSabado;
        private System.Windows.Forms.ComboBox comboBoxInicioViernes;
        private System.Windows.Forms.ComboBox comboBoxInicioJueves;
        private System.Windows.Forms.ComboBox comboBoxFinLunes;
        private System.Windows.Forms.ComboBox comboBoxInicioMartes;
        private System.Windows.Forms.ComboBox comboBoxFinMartes;
        private System.Windows.Forms.ComboBox comboBoxFinJueves;
        private System.Windows.Forms.ComboBox comboBoxFinViernes;
        private System.Windows.Forms.ComboBox comboBoxInicioMiercoles;
        private System.Windows.Forms.ComboBox comboBoxFinMiercoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}