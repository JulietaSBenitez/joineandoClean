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

using ClinicaFrba.src;
using ClinicaFrba.DAO;

namespace ClinicaFrba.RegistrarAgendaMedico
{
    public partial class AltaAP : Form
    {

        private List<ValidacionBooleana<AltaAP>> validaciones = new List<ValidacionBooleana<AltaAP>>();
        private Dictionary<CheckBox, Tuple<ComboBox, ComboBox>> widgets = new Dictionary<CheckBox, Tuple<ComboBox, ComboBox>>();
        public Medico ModelObjectMedico { get; set; }

        public AltaAP(Medico medico)
        {
            InitializeComponent();

            ModelObjectMedico = medico;

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
                (controlador => medico.CantidadDeHorasTrabajadas().Add(controlador.TiempoDeLaAgenda()) <= new TimeSpan(48, 0, 0)),
                "Lo lamentamos, pero con estas horas usted ya estaría trabajando 48hs. ¡Vaya a descansar! Sus pacientes se lo agradecerán."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => controlador.NoColisiona()),
                "Alguna de las combinaciones seleccionadas ya esta presente total o parcialmente en otra agenda"));
        }


        private void InicializarComboboxes()
        {

            ComboboxesSemana().ForEach(comboBox => comboBox.DataSource = RangoHorario.Rango(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0)));
            ComboboxesSabado().ForEach(comboBox => comboBox.DataSource = RangoHorario.Rango(new TimeSpan(10, 0, 0), new TimeSpan(15, 0, 0)));
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
                WidgetsSeleccionados().ForEach(par => RegistrarHorario(par));
                MessageBox.Show("Agenda creada con éxito");

                WidgetsSeleccionados().ForEach(par => LimpiarWidget(par));
                
            }
            else
            {
                ValidacionBooleana<AltaAP> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LimpiarWidget(KeyValuePair<CheckBox, Tuple<ComboBox, ComboBox>> par)
        {
            especialidadesAgendaCB.Text = "";
            especialidadesAgendaCB.DataSource = ModelObjectMedico.EspecialidadesSinAgenda();

            par.Key.Checked = false;
            par.Value.Item1.SelectedIndex = 0;
            par.Value.Item2.SelectedIndex = 0;
        }

      

        private List<KeyValuePair<CheckBox, Tuple<ComboBox, ComboBox>>> WidgetsSeleccionados()
        {
            return widgets.Where(widget => widget.Key.Checked).ToList();
        }

        private void RegistrarHorario(KeyValuePair<CheckBox, Tuple<ComboBox, ComboBox>> par)
        {
            DateTime horarioInicio = DateTime.Parse(((TimeSpan)par.Value.Item1.SelectedItem).ToString());
            DateTime horarioFin = DateTime.Parse(((TimeSpan)par.Value.Item2.SelectedItem).ToString());

            int diaID = IDDiaPara(par.Key);

            SqlParameter IDMedico = new SqlParameter("@Medico_id", ModelObjectMedico.ID);
            SqlParameter IDEspecialidad = new SqlParameter("@Especialidad_id", Especialidad().ID);
            SqlParameter DiaID = new SqlParameter("@Dia_id", diaID);
            SqlParameter HorarioInicio = new SqlParameter("@Inicio_Horario", horarioInicio);
            SqlParameter HorarioFin = new SqlParameter("@Fin_Horario", horarioFin);

            QueryAdapterMaggie.ejecutarSP("AGENDAInsertarNueva", IDMedico, IDEspecialidad, DiaID, HorarioInicio, HorarioFin);

        }

        private int IDDiaPara(CheckBox checkBox)
        {
            return widgets.Keys.ToList().IndexOf(checkBox) + 1;
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
        public bool NoColisiona()
        {
            return WidgetsSeleccionados().All(par => NoColisiona(par));
        }

        private bool NoColisiona(KeyValuePair<CheckBox, Tuple<ComboBox, ComboBox>> par)
        {
            DateTime _horarioInicio = DateTime.Parse(((TimeSpan)par.Value.Item1.SelectedItem).ToString());
            DateTime _horarioFin = DateTime.Parse(((TimeSpan)par.Value.Item2.SelectedItem).ToString());

            SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectMedico.ID);
            SqlParameter idDia = new SqlParameter("@Dia_id",IDDiaPara(par.Key));
            SqlParameter horarioInicio = new SqlParameter("@Inicio_Horario", _horarioInicio);
            SqlParameter horarioFin = new SqlParameter("@Fin_Horario", _horarioFin);

            return !QueryAdapterMaggie.ejecutarSPBooleano("AGENDARangoColisionaConAgendaExistente", idDia, idMedico, horarioInicio, horarioFin);
        }



        private List<Tuple<TimeSpan, TimeSpan>> HorasDeCheckboxSeleccionados()
        {
            return WidgetsSeleccionados()
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

        private TimeSpan TiempoDeLaAgenda()
        {
            return
                HorasDeCheckboxSeleccionados()
                .Select(tupla => tupla.Item2 - tupla.Item1)
                .Aggregate((time, otherTime) => time + otherTime);
        }

        private Especialidad Especialidad()
        {

            return (Especialidad)especialidadesAgendaCB.SelectedItem;
        }

        private void AltaAP_Load(object sender, EventArgs e)
        {

        }



    }
}