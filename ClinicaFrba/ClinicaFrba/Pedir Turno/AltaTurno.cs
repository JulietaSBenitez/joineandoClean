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
        public int IDPersona;
        private List<ValidacionBooleana<AltaTurno>> validaciones = new List<ValidacionBooleana<AltaTurno>>();

        public AltaTurno(int persona_id)
        {

            InitializeComponent();

            IDPersona = persona_id;

            Especialidades = Especialidad.All();

            EspecialidadMedicaCB.DataSource = Especialidades;
            EspecialidadMedicaCB.DisplayMember = "Nombre";

            TodosLosMedicos = Medico.All();

            ProfesionalCB.Enabled = false;
            ProfesionalCB.DataSource = MedicosEspecialidadSeleccionada;
            ProfesionalCB.DisplayMember = "Nombre";

            validaciones.Add(new ValidacionBooleana<AltaTurno>(
               (controlador => controlador.ProfesionalSeleccionado()),
               "No se ha seleccionado ningun profesional."));
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {

            if (validaciones.All(validacion => validacion.SeCumple(this)))
            {
                this.Hide();
                Selección_de_Día_y_Horario seleccion = new Selección_de_Día_y_Horario((Especialidad) EspecialidadMedicaCB.SelectedItem,
                                                                                      (Medico) ProfesionalCB.SelectedItem,
                                                                                      IDPersona);
                seleccion.ShowDialog();
                this.Show();

            }
            else
            {
                ValidacionBooleana<AltaTurno> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EspecialidadMedicaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidad especialidadSeleccionada = (Especialidad)EspecialidadMedicaCB.SelectedItem;

            MedicosEspecialidadSeleccionada = TodosLosMedicos
                .Where(medico => medico.EsEspecialistaEn(especialidadSeleccionada)).ToList();

            ProfesionalCB.DataSource = MedicosEspecialidadSeleccionada;
            ProfesionalCB.Enabled = true;
        }

        private bool ProfesionalSeleccionado()
        {
            return ProfesionalCB.SelectedItem != null;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}