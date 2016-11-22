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

        private List<ValidacionBooleana<AltaAP>> validaciones = new List<ValidacionBooleana<AltaAP>>();
        private Dictionary<CheckBox, Tuple<ComboBox, ComboBox>> widgets = new Dictionary<CheckBox, Tuple<ComboBox, ComboBox>>();

        public AltaAP(Medico medico)
        {
            InitializeComponent();

            widgets.Add(lunesAgendaCB, new Tuple<ComboBox, ComboBox>(comboBoxInicioLunes, comboBoxFinLunes));
            widgets.Add(martesAgendaCB, new Tuple<ComboBox, ComboBox>(comboBoxInicioMartes, comboBoxFinMartes));
            widgets.Add(miercolesAgendaCB, new Tuple<ComboBox, ComboBox>(comboBoxInicioMiercoles, comboBoxFinMiercoles));
            widgets.Add(juevesAgendaCB, new Tuple<ComboBox, ComboBox>(comboBoxInicioJueves, comboBoxFinJueves));
            widgets.Add(viernesAgendaCB, new Tuple<ComboBox, ComboBox>(comboBoxInicioViernes, comboBoxFinViernes));
            widgets.Add(sabadoAgendaCB, new Tuple<ComboBox, ComboBox>(comboBoxInicioSabado, comboBoxFinSabado));


            especialidadesAgendaCB.DataSource = medico.EspecialidadesSinAgenda();
            especialidadesAgendaCB.DisplayMember = "Nombre";

            InicializarComboboxes();

            validaciones.Add(new ValidacionBooleana<AltaAP>(
               (controlador => controlador.EspecialidadSeleccionada()),
               "No se ha seleccionado ninguna especialidad."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => controlador.AlgunDiaSeleccionado()),
                "No se ha seleccionado ningun día."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => controlador.HoraInicioEsMenorQuehoraFin()),
                "El horario de inicio es mayor o igual al horario de fin."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => medico.CantidadDeHorasTrabajadas().Add(controlador.TiempoDeLaAgenda()) <= new TimeSpan(48,0,0)),
                "Lo lamentamos, pero con estas horas usted ya estaría trabajando 48hs. ¡Vaya a descansar! Sus pacientes se lo agradecerán."));

            

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

            ComboboxesSemana().ForEach(comboBox => comboBox.DataSource = RangoHorario(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0)));
            ComboboxesSabado().ForEach(comboBox => comboBox.DataSource = RangoHorario(new TimeSpan(10, 0, 0), new TimeSpan(15, 0, 0)));
            Comboboxes().ForEach(comboBox => comboBox.Enabled = false);
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
            else
            {

                comboBoxInicioLunes.Enabled = false;
                comboBoxFinLunes.Enabled = false;
            }
        }

        private void MartesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {

            if (martesAgendaCB.Checked)
            {
                comboBoxInicioMartes.Enabled = true;
                comboBoxFinMartes.Enabled = true;
            }
            else
            {

                comboBoxInicioMartes.Enabled = false;
                comboBoxFinMartes.Enabled = false;
            }

        }

        private void MiercolesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (miercolesAgendaCB.Checked)
            {
                comboBoxInicioMiercoles.Enabled = true;
                comboBoxFinMiercoles.Enabled = true;
            }
            else
            {

                comboBoxInicioMiercoles.Enabled = false;
                comboBoxFinMiercoles.Enabled = false;
            }
        }

        private void JuevesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (juevesAgendaCB.Checked)
            {
                comboBoxInicioJueves.Enabled = true;
                comboBoxFinJueves.Enabled = true;
            }
            else
            {

                comboBoxInicioJueves.Enabled = false;
                comboBoxFinJueves.Enabled = false;
            }
        }

        private void ViernesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (viernesAgendaCB.Checked)
            {
                comboBoxInicioViernes.Enabled = true;
                comboBoxFinViernes.Enabled = true;
            }
            else
            {

                comboBoxInicioViernes.Enabled = false;
                comboBoxFinViernes.Enabled = false;
            }
        }

        private void SabadoAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sabadoAgendaCB.Checked)
            {
                comboBoxInicioSabado.Enabled = true;
                comboBoxFinSabado.Enabled = true;
            }
            else
            {

                comboBoxInicioSabado.Enabled = false;
                comboBoxFinSabado.Enabled = false;
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

        }

        public bool EspecialidadSeleccionada()
        {
            return especialidadesAgendaCB.SelectedItem != null;
        }

        public bool AlgunDiaSeleccionado()
        {
            return widgets.Keys.Any(checkBox => checkBox.Checked);
        }

        public bool HoraInicioEsMenorQuehoraFin()
        {

            return HorasDeCheckboxSeleccionados().All(tupla => tupla.Item1 < tupla.Item2);
        }

        private List<Tuple<TimeSpan, TimeSpan>> HorasDeCheckboxSeleccionados()
        {
            return widgets
                .Where(par => par.Key.Checked)
                .Select(par => par.Value)
                .Select(tupla => new Tuple<TimeSpan, TimeSpan>((TimeSpan)tupla.Item1.SelectedItem, (TimeSpan)tupla.Item2.SelectedItem))
                .ToList();
        }

        private List<ComboBox> Comboboxes()
        {
            return widgets
                  .Select(par => par.Value)
                  .Select(tupla => new List<ComboBox>() { tupla.Item1, tupla.Item2 })
                  .SelectMany(lista => lista)
                  .ToList();
        }

        private List<ComboBox> ComboboxesSemana()
        {
            return widgets
                  .Select(par => par.Value)
                  .Select(tupla => new List<ComboBox>() { tupla.Item1, tupla.Item2 })
                  .Take(5)
                  .SelectMany(lista => lista)
                  .ToList();
        }

        private List<ComboBox> ComboboxesSabado()
        {
            return widgets
                  .Select(par => par.Value)
                  .Select(tupla => new List<ComboBox>() { tupla.Item1, tupla.Item2 })
                  .Last();
        }

        private TimeSpan TiempoDeLaAgenda(){
            return
                HorasDeCheckboxSeleccionados()
                .Select(tupla => tupla.Item2 - tupla.Item1)
                .Aggregate((time, otherTime) => time + otherTime);
        }


    }
}