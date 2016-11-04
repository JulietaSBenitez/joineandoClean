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

namespace ClinicaFrba.RegistrarAgendaMedico
{
    public partial class AltaAP : Form
    {

        List<Especialidad> especialidades;

        public AltaAP()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
