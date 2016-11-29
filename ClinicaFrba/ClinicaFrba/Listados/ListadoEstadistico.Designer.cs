namespace ClinicaFrba.Listados
{
    partial class ListadoEstadistico
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
            this.TablaListado = new System.Windows.Forms.DataGridView();
            this.Acciones = new System.Windows.Forms.ComboBox();
            this.mostrar = new System.Windows.Forms.Button();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaListado)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaListado
            // 
            this.TablaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaListado.Location = new System.Drawing.Point(12, 112);
            this.TablaListado.Name = "TablaListado";
            this.TablaListado.Size = new System.Drawing.Size(684, 212);
            this.TablaListado.TabIndex = 0;
             // 
            // Acciones
            // 
            this.Acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acciones.FormattingEnabled = true;
            this.Acciones.Items.AddRange(new object[] {
            "Top 5 de las especialidades con mas cancelaciones",
            "Top 5 de los profesionales más consultados por Plan",
            "Top 5 de los profesionales con menos horas trabajadas",
            "Top 5 de los afiliados con mayor cantidad de bonos comprados",
            "Top 5 de las especialidades con más bonos utilizados"});
            this.Acciones.Location = new System.Drawing.Point(12, 12);
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(463, 28);
            this.Acciones.TabIndex = 1;
            // 
            // mostrar
            // 
            this.mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(495, 12);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(201, 28);
            this.mostrar.TabIndex = 2;
            this.mostrar.Text = "Mostrar Listado";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // semestre
            // 
            this.semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.semestre.Location = new System.Drawing.Point(211, 44);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(144, 28);
            this.semestre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semestre";
            // 
            // ano
            // 
            this.ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano.Location = new System.Drawing.Point(56, 45);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(62, 26);
            this.ano.TabIndex = 7;
            this.ano.Text = "2016";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Especialidad";
            // 
            // especialidad
            // 
            this.especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.especialidad.Location = new System.Drawing.Point(470, 46);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(226, 28);
            this.especialidad.TabIndex = 8;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.Acciones);
            this.Controls.Add(this.TablaListado);
            this.Name = "ListadoEstadistico";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaListado;
        private System.Windows.Forms.ComboBox Acciones;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.ComboBox semestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox especialidad;
    }
}