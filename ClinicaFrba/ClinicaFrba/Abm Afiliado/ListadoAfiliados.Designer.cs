namespace ClinicaFrba.Abm_Afiliado
{
    partial class ListadoAfiliados
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
            this.label4 = new System.Windows.Forms.Label();
            this.numerodocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.tiposDeDocumentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaAfiliados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Numero";
            // 
            // numerodocumento
            // 
            this.numerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodocumento.Location = new System.Drawing.Point(394, 78);
            this.numerodocumento.Name = "numerodocumento";
            this.numerodocumento.Size = new System.Drawing.Size(171, 22);
            this.numerodocumento.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(311, 50);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(254, 22);
            this.apellido.TabIndex = 18;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(76, 49);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(153, 22);
            this.nombre.TabIndex = 17;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(12, 110);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(454, 110);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(111, 35);
            this.btnfiltrar.TabIndex = 15;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // tiposDeDocumentos
            // 
            this.tiposDeDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiposDeDocumentos.FormattingEnabled = true;
            this.tiposDeDocumentos.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.tiposDeDocumentos.Location = new System.Drawing.Point(129, 76);
            this.tiposDeDocumentos.Name = "tiposDeDocumentos";
            this.tiposDeDocumentos.Size = new System.Drawing.Size(155, 21);
            this.tiposDeDocumentos.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // tablaAfiliados
            // 
            this.tablaAfiliados.AllowUserToAddRows = false;
            this.tablaAfiliados.AllowUserToDeleteRows = false;
            this.tablaAfiliados.AllowUserToResizeColumns = false;
            this.tablaAfiliados.AllowUserToResizeRows = false;
            this.tablaAfiliados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaAfiliados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tablaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAfiliados.Location = new System.Drawing.Point(12, 151);
            this.tablaAfiliados.Name = "tablaAfiliados";
            this.tablaAfiliados.ReadOnly = true;
            this.tablaAfiliados.Size = new System.Drawing.Size(553, 195);
            this.tablaAfiliados.TabIndex = 12;
            // 
            // ListadoAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numerodocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.tiposDeDocumentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaAfiliados);
            this.Name = "ListadoAfiliados";
            this.Text = "Listado Afiliados";
            this.Load += new System.EventHandler(this.ListadoAfiliados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox numerodocumento;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox apellido;
        public System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.Button btnfiltrar;
        public System.Windows.Forms.ComboBox tiposDeDocumentos;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tablaAfiliados;
    }
}