namespace ClinicaFrba.Registro_Llegada
{
    partial class BusquedaTurno
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
            this.components = new System.ComponentModel.Container();
            this.tablaTurnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.medico = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.especialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroAfiliado = new System.Windows.Forms.TextBox();
            this.numeroTurno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.horario = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaTurnos
            // 
            this.tablaTurnos.AllowUserToAddRows = false;
            this.tablaTurnos.AllowUserToDeleteRows = false;
            this.tablaTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTurnos.Location = new System.Drawing.Point(12, 135);
            this.tablaTurnos.Name = "tablaTurnos";
            this.tablaTurnos.ReadOnly = true;
            this.tablaTurnos.Size = new System.Drawing.Size(737, 159);
            this.tablaTurnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // medico
            // 
            this.medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medico.Location = new System.Drawing.Point(71, 61);
            this.medico.Name = "medico";
            this.medico.Size = new System.Drawing.Size(335, 22);
            this.medico.TabIndex = 27;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(12, 89);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnlimpiar.TabIndex = 26;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(631, 91);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(111, 35);
            this.btnfiltrar.TabIndex = 25;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            // 
            // especialidad
            // 
            this.especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.especialidad.Location = new System.Drawing.Point(565, 63);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(174, 21);
            this.especialidad.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Medico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Numero de Afiliado";
            // 
            // numeroAfiliado
            // 
            this.numeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroAfiliado.Location = new System.Drawing.Point(441, 33);
            this.numeroAfiliado.Name = "numeroAfiliado";
            this.numeroAfiliado.Size = new System.Drawing.Size(141, 22);
            this.numeroAfiliado.TabIndex = 34;
            this.numeroAfiliado.TextChanged += new System.EventHandler(this.numeroAfiliado_TextChanged);
            // 
            // numeroTurno
            // 
            this.numeroTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTurno.Location = new System.Drawing.Point(131, 33);
            this.numeroTurno.Name = "numeroTurno";
            this.numeroTurno.Size = new System.Drawing.Size(158, 22);
            this.numeroTurno.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Numero de Turno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 38;
            // 
            // horario
            // 
            this.horario.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario.Location = new System.Drawing.Point(589, 32);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(150, 22);
            this.horario.TabIndex = 39;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BusquedaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 306);
            this.Controls.Add(this.horario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeroAfiliado);
            this.Controls.Add(this.numeroTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.medico);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTurnos);
            this.Name = "BusquedaTurno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BusquedaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tablaTurnos;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox medico;
        public System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.Button btnfiltrar;
        public System.Windows.Forms.ComboBox especialidad;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox numeroAfiliado;
        public System.Windows.Forms.TextBox numeroTurno;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker horario;
        public System.Windows.Forms.Timer timer1;
    }
}