using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClinicaFrba.src;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Selección_de_Día_y_Horario : Form
    {

        public Medico ModelObjectM { get; set; }
        public Especialidad ModelObjectE { get; set; }

        public Selección_de_Día_y_Horario(Especialidad especialidad, Medico medico)
        {
            InitializeComponent();
            ModelObjectE = especialidad;
            ModelObjectM = medico;
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaTurno seleccion = new AltaTurno();
            seleccion.ShowDialog();
            Close();
        }

    }
}
