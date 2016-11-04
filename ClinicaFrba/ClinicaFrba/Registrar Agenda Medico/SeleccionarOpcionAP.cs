using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.RegistrarAgendaMedico
{
    public partial class SeleccionarOpcionAP : Form
    {
        public SeleccionarOpcionAP()
        {
            InitializeComponent();
        }

        private void SeleccionarOpcionAP_Load(object sender, EventArgs e)
        {

        }

        private void AgregarAgendaImagen_Click(object sender, EventArgs e)
        {
            Form altaAgendaProfesional = new AltaAP();
            altaAgendaProfesional.ShowDialog();
        }
    }
}
