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

        List<ComboBox> ComboBoxSemana = new List<ComboBox>();
        List<ComboBox> ComboBoxSabado = new List<ComboBox>();
        List<CheckBox> CheckBoxDias = new List<CheckBox>();
        List<ValidacionBooleana<AltaAP>> validaciones = new List<ValidacionBooleana<AltaAP>>();


        public AltaAP(Medico medico)
        {
            InitializeComponent();

            especialidadesAgendaCB.DataSource = medico.EspecialidadesSinAgenda();
            especialidadesAgendaCB.DisplayMember = "Nombre";

            ComboBoxSemana.Add(comboBoxInicioLunes);
            ComboBoxSemana.Add(comboBoxInicioMartes);
            ComboBoxSemana.Add(comboBoxInicioMiercoles);
            ComboBoxSemana.Add(comboBoxInicioJueves);
            ComboBoxSemana.Add(comboBoxInicioViernes);

            ComboBoxSemana.Add(comboBoxFinLunes);
            ComboBoxSemana.Add(comboBoxFinMartes);
            ComboBoxSemana.Add(comboBoxFinMiercoles);
            ComboBoxSemana.Add(comboBoxFinJueves);
            ComboBoxSemana.Add(comboBoxFinViernes);

            CheckBoxDias.Add(lunesAgendaCB);
            CheckBoxDias.Add(martesAgendaCB);
            CheckBoxDias.Add(miercolesAgendaCB);
            CheckBoxDias.Add(juevesAgendaCB);
            CheckBoxDias.Add(viernesAgendaCB);
            CheckBoxDias.Add(sabadoAgendaCB);

            validaciones.Add(new ValidacionBooleana<AltaAP>(
               (controlador => controlador.EspecialidadSeleccionada()),
               "No se ha seleccionado ninguna especialidad."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => controlador.AlgunDiaSeleccionado()),
                "No se ha seleccionado ningun día."));

        }


        private List<TimeSpan> RangoHorario(TimeSpan horaInicio, TimeSpan horaFin)
        {
            List<TimeSpan> horarios = new List<TimeSpan>();
            TimeSpan horario = horaInicio;

            while (horario <= horaFin)
            {
                horarios.Add(horario);
                horario = horario.Add(new TimeSpan(0, 30, 0));
            }

            return horarios;
        }

        private void InicializarComboboxes()
        {

            ComboBoxSemana.ForEach(comboBox => comboBox.DataSource = RangoHorario(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0)));
            ComboBoxSabado.ForEach(comboBox => comboBox.DataSource = RangoHorario(new TimeSpan(10, 0, 0), new TimeSpan(15, 0, 0)));
            ComboBoxSemana.ForEach(comboBox => comboBox.Enabled = false);
            ComboBoxSabado.ForEach(comboBox => comboBox.Enabled = false);
        }

        private void botonVolverAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LunesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (lunesAgendaCB.Checked)
            {
                comboBoxInicioLunes.Enabled = true;
                comboBoxFinLunes.Enabled = true;
            }
        }

        private void MartesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {

            if (martesAgendaCB.Checked)
            {
                comboBoxInicioMartes.Enabled = true;
                comboBoxFinMartes.Enabled = true;
            }

        }

        private void MiercolesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (miercolesAgendaCB.Checked)
            {
                comboBoxInicioMiercoles.Enabled = true;
                comboBoxFinMiercoles.Enabled = true;
            }
        }

        private void JuevesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (juevesAgendaCB.Checked)
            {
                comboBoxInicioJueves.Enabled = true;
                comboBoxFinJueves.Enabled = true;
            }
        }

        private void ViernesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (viernesAgendaCB.Checked)
            {
                comboBoxInicioViernes.Enabled = true;
                comboBoxFinViernes.Enabled = true;
            }
        }

        private void SabadoAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sabadoAgendaCB.Checked)
            {
                comboBoxInicioSabado.Enabled = true;
                comboBoxFinSabado.Enabled = true;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (validaciones.All(validacion => validacion.SeCumple(this)))
            {
                //Está todo ok
            }
            else
            {
                ValidacionBooleana<AltaAP> validacionQueNoSeCumple = 
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

                 //validarQueNoExistanOtrasAgendasEnEseHorario.
                 //ValidarQueNoSeTrabajeMasDe48HorasSemanales.
                 //Validar que no deje ningun checkbox sin llenar

        }

        public bool EspecialidadSeleccionada()
        {
            return especialidadesAgendaCB.SelectedItem != null;
        }

        public bool AlgunDiaSeleccionado() {
            return CheckBoxDias.Any(checkBox => checkBox.Checked);
        }

        public bool HoraInicioEsMenorQuehoraFin() { 
         return true}
    }
}