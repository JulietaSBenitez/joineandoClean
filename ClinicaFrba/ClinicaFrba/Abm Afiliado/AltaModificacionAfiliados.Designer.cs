namespace ClinicaFrba.Abm_Afiliado
{
    partial class AltaModificacionAfiliados
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
            this.tipo = new System.Windows.Forms.ComboBox();
            this.numerodocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BotonGuardarRol = new System.Windows.Forms.Button();
            this.BotonLimpiarRoles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fechanac = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.plan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.familiaresacargo = new System.Windows.Forms.TextBox();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.botonHistorial = new System.Windows.Forms.Button();
            this.razont = new System.Windows.Forms.Label();
            this.razon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(126, 81);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(119, 24);
            this.tipo.TabIndex = 25;
            // 
            // numerodocumento
            // 
            this.numerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodocumento.Location = new System.Drawing.Point(341, 80);
            this.numerodocumento.Name = "numerodocumento";
            this.numerodocumento.Size = new System.Drawing.Size(166, 22);
            this.numerodocumento.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Numero Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(315, 49);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(192, 22);
            this.apellido.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(133, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Modificar/Agregar Afiliado";
            // 
            // BotonGuardarRol
            // 
            this.BotonGuardarRol.Location = new System.Drawing.Point(410, 313);
            this.BotonGuardarRol.Name = "BotonGuardarRol";
            this.BotonGuardarRol.Size = new System.Drawing.Size(98, 38);
            this.BotonGuardarRol.TabIndex = 18;
            this.BotonGuardarRol.Text = "Guardar";
            this.BotonGuardarRol.UseVisualStyleBackColor = true;
            this.BotonGuardarRol.Click += new System.EventHandler(this.BotonGuardarRol_Click);
            // 
            // BotonLimpiarRoles
            // 
            this.BotonLimpiarRoles.Location = new System.Drawing.Point(18, 313);
            this.BotonLimpiarRoles.Name = "BotonLimpiarRoles";
            this.BotonLimpiarRoles.Size = new System.Drawing.Size(95, 38);
            this.BotonLimpiarRoles.TabIndex = 17;
            this.BotonLimpiarRoles.Text = "Limpiar";
            this.BotonLimpiarRoles.UseVisualStyleBackColor = true;
            this.BotonLimpiarRoles.Click += new System.EventHandler(this.BotonLimpiarRoles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(83, 46);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(146, 22);
            this.nombre.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefono";
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(83, 150);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(148, 22);
            this.telefono.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Direccion";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(83, 119);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(424, 22);
            this.direccion.TabIndex = 26;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(315, 150);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(192, 22);
            this.email.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Email";
            // 
            // fechanac
            // 
            this.fechanac.Location = new System.Drawing.Point(95, 186);
            this.fechanac.Name = "fechanac";
            this.fechanac.Size = new System.Drawing.Size(203, 20);
            this.fechanac.TabIndex = 32;
            this.fechanac.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha Nac";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Sexo";
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Location = new System.Drawing.Point(349, 186);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(158, 21);
            this.sexo.TabIndex = 35;
            // 
            // plan
            // 
            this.plan.FormattingEnabled = true;
            this.plan.Location = new System.Drawing.Point(55, 252);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(315, 21);
            this.plan.TabIndex = 37;
            this.plan.SelectedIndexChanged += new System.EventHandler(this.plan_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Plan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(304, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Familiares a cargo";
            // 
            // familiaresacargo
            // 
            this.familiaresacargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familiaresacargo.Location = new System.Drawing.Point(423, 217);
            this.familiaresacargo.Name = "familiaresacargo";
            this.familiaresacargo.Size = new System.Drawing.Size(85, 22);
            this.familiaresacargo.TabIndex = 38;
            // 
            // estadoCivil
            // 
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "No especificado",
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.estadoCivil.Location = new System.Drawing.Point(95, 217);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(203, 21);
            this.estadoCivil.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Estado Civil";
            // 
            // botonHistorial
            // 
            this.botonHistorial.Location = new System.Drawing.Point(379, 245);
            this.botonHistorial.Name = "botonHistorial";
            this.botonHistorial.Size = new System.Drawing.Size(128, 28);
            this.botonHistorial.TabIndex = 42;
            this.botonHistorial.Text = "Ver historial de cambios";
            this.botonHistorial.UseVisualStyleBackColor = true;
            this.botonHistorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // razont
            // 
            this.razont.AutoSize = true;
            this.razont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razont.Location = new System.Drawing.Point(12, 282);
            this.razont.Name = "razont";
            this.razont.Size = new System.Drawing.Size(124, 16);
            this.razont.TabIndex = 44;
            this.razont.Text = "Razon cambio plan";
            this.razont.Visible = false;
            // 
            // razon
            // 
            this.razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razon.Location = new System.Drawing.Point(142, 279);
            this.razon.Name = "razon";
            this.razon.Size = new System.Drawing.Size(365, 22);
            this.razon.TabIndex = 43;
            this.razon.Visible = false;
            // 
            // AltaModificacionAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 359);
            this.Controls.Add(this.razont);
            this.Controls.Add(this.razon);
            this.Controls.Add(this.botonHistorial);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.familiaresacargo);
            this.Controls.Add(this.plan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fechanac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.numerodocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotonGuardarRol);
            this.Controls.Add(this.BotonLimpiarRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "AltaModificacionAfiliados";
            this.Text = "Alta / Modificacion Afiliado";
            this.Load += new System.EventHandler(this.AltaModificacionAfiliados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox numerodocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BotonGuardarRol;
        private System.Windows.Forms.Button BotonLimpiarRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fechanac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.ComboBox plan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox familiaresacargo;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button botonHistorial;
        private System.Windows.Forms.Label razont;
        private System.Windows.Forms.TextBox razon;
    }
}