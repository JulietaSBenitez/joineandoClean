using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using ClinicaFrba.DAO;
using ClinicaFrba.src;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class AltaTurno : Form
    {
        List<Especialidad> Especialidades = new List<Especialidad>();
        List<Medico> TodosLosMedicos = new List<Medico>();
        List<Medico> MedicosEspecialidadSeleccionada = new List<Medico>();

        public AltaTurno()
        {

            InitializeComponent();
            Especialidades = Especialidad.All();

            EspecialidadMedicaCB.DataSource = Especialidades;
            EspecialidadMedicaCB.DisplayMember = "Nombre";

            TodosLosMedicos = Medico.All();           

            ProfesionalCB.Enabled = false;
            ProfesionalCB.DataSource = MedicosEspecialidadSeleccionada;
            ProfesionalCB.DisplayMember = "Nombre";


        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {

        }

        private void EspecialidadMedicaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidad especialidadSeleccionada = (Especialidad) EspecialidadMedicaCB.SelectedItem;

            MedicosEspecialidadSeleccionada = TodosLosMedicos
                .Where(medico => medico.EsEspecialistaEn(especialidadSeleccionada)).ToList();

            ProfesionalCB.DataSource = MedicosEspecialidadSeleccionada;

            ProfesionalCB.Enabled = true;
        }

    }
}