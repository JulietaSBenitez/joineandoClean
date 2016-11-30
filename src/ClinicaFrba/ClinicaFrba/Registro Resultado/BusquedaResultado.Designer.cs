namespace ClinicaFrba.Registro_Resultado
{
    partial class BusquedaResultado
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
            this.horario = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroAfiliado = new System.Windows.Forms.TextBox();
            this.numeroTurno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaTurnos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // horario
            // 
            this.horario.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario.Location = new System.Drawing.Point(571, 42);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(168, 22);
            this.horario.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, -3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Numero de Afiliado";
            // 
            // numeroAfiliado
            // 
            this.numeroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroAfiliado.Location = new System.Drawing.Point(424, 42);
            this.numeroAfiliado.Name = "numeroAfiliado";
            this.numeroAfiliado.Size = new System.Drawing.Size(141, 22);
            this.numeroAfiliado.TabIndex = 50;
            // 
            // numeroTurno
            // 
            this.numeroTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTurno.Location = new System.Drawing.Point(131, 43);
            this.numeroTurno.Name = "numeroTurno";
            this.numeroTurno.Size = new System.Drawing.Size(158, 22);
            this.numeroTurno.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Numero de Turno";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(14, 72);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnlimpiar.TabIndex = 46;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(631, 72);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(111, 35);
            this.btnfiltrar.TabIndex = 45;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 41;
            // 
            // tablaTurnos
            // 
            this.tablaTurnos.AllowUserToAddRows = false;
            this.tablaTurnos.AllowUserToDeleteRows = false;
            this.tablaTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTurnos.Location = new System.Drawing.Point(12, 116);
            this.tablaTurnos.Name = "tablaTurnos";
            this.tablaTurnos.ReadOnly = true;
            this.tablaTurnos.Size = new System.Drawing.Size(737, 251);
            this.tablaTurnos.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Seleccione turno para cargar diagnostico";
            // 
            // BusquedaResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeroAfiliado);
            this.Controls.Add(this.numeroTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTurnos);
            this.Name = "BusquedaResultado";
            this.Text = "BusquedaConsulta";
            this.Load += new System.EventHandler(this.BusquedaResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker horario;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox numeroAfiliado;
        public System.Windows.Forms.TextBox numeroTurno;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.Button btnfiltrar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tablaTurnos;
        private System.Windows.Forms.Label label2;
    }
}