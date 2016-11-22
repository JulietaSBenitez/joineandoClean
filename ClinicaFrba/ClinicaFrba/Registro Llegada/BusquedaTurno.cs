using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class BusquedaTurno : Form
    {
        public BusquedaTurno()
        {
            InitializeComponent();
            horario.Format = DateTimePickerFormat.Custom;
            horario.CustomFormat = "dd/MM/yyyy hh:mm";  
        }

        private void BusquedaTurno_Load(object sender, EventArgs e)
        {

        }

        public void AgregarBoton()
        {
            DataGridViewButtonColumn btnColum = new DataGridViewButtonColumn();
            btnColum.Name = "Seleccionar";
            btnColum.Text = "Seleccionar";
            btnColum.UseColumnTextForButtonValue = true;
            tablaTurnos.Columns.Insert(0, btnColum);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  horario.Value = DateTime.Now; 
        }

        private void numeroAfiliado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
