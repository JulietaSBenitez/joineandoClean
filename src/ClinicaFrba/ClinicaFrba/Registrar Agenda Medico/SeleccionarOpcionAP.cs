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
    public partial class SeleccionarOpcionAP : Form
    {

        public Medico ModelObject { get; set; }

        public SeleccionarOpcionAP(int medico_id)
        {
            InitializeComponent();
            ModelObject = Medico.All().Where(medico => medico.ID.Equals(medico_id)).First();
        }

        private void SeleccionarOpcionAP_Load(object sender, EventArgs e)
        {
        }

        public void AgregarAgendaImagen_Click(object sender, EventArgs e)
        {
           Hide();
           Form altaAgendaProfesional = new AltaAP(ModelObject);
           altaAgendaProfesional.ShowDialog();
           Show();
        }

        private void VolverAgendaBoton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
