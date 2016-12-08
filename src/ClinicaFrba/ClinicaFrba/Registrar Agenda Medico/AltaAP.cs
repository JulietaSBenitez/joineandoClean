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


            especialidadesAgendaCB.DataSource = medico.Especialidades();
            especialidadesAgendaCB.DisplayMember = "Nombre";

            InicioRangoDP.Value = Properties.Settings.Default.fecha;
            
            FinRangoDP.Value = Properties.Settings.Default.fecha;

            InicializarComboboxes();

            validaciones.Add(new ValidacionBooleana<AltaAP>(
               (controlador => controlador.EspecialidadSeleccionada()),
               "No se ha seleccionado ninguna especialidad."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
               (controlador => controlador.DiaInicioMayorAHoy()),
               "El día de inicio debe ser mayor al día de hoy."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
               (controlador => controlador.DiaDeInicioMenorADiaFin()),
                "El día de inicio debe ser mayor o igual al día de fin"));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => controlador.AlgunDiaSeleccionado()),
                "No se ha seleccionado ningun día."));

            validaciones.Add(new ValidacionBooleana<AltaAP>(
                (controlador => controlador.HoraInicioEsMenorQuehoraFin()),
                "El horario de inicio es mayor o igual al horario de fin."));

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

                bool resultado_exitoso = RegistrarAgenda();
                if (resultado_exitoso)
                {
                    MessageBox.Show("Agenda creada con éxito");
                    WidgetsSeleccionados().ForEach(par => LimpiarWidget(par));
                }
                else
                {
                    MessageBox.Show("No se puede trabajar más de 48 horas por semana.", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ValidacionBooleana<AltaAP> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool RegistrarAgenda()
        {
           
            DataTable dias = new DataTable();

            dias.Columns.Add(new DataColumn("ID",typeof(int)));
            dias.Columns.Add(new DataColumn("INICIO",typeof(TimeSpan)));
            dias.Columns.Add(new DataColumn("FIN",typeof(TimeSpan)));

            foreach (Tuple<int, TimeSpan, TimeSpan> dia in DiasAtencionSeleccionados())
            {
                DataRow row = dias.NewRow();
                row["ID"] = dia.Item1;
                row["INICIO"] = dia.Item2;
                row["FIN"] = dia.Item3;
                dias.Rows.Add(row);
            }

            SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectMedico.ID);
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", Especialidad().ID);
            SqlParameter diaInicio = new SqlParameter("@Dia_inicio", InicioRangoDP.Value);
            SqlParameter diaFin = new SqlParameter("@Dia_Fin", FinRangoDP.Value);
            SqlParameter diasAtencion = new SqlParameter("@Dias_Atencion", dias);

            
            return QueryAdapterMaggie.ejecutarSPBooleano("Agendainsertarnueva",idMedico,idEspecialidad,diaInicio,diaFin,diasAtencion);
        }

        private void LimpiarWidget(KeyValuePair<CheckBox, Tuple<ComboBox, ComboBox>> par)
        {
            especialidadesAgendaCB.Text = "";
            especialidadesAgendaCB.DataSource = ModelObjectMedico.Especialidades();

            par.Key.Checked = false;
            par.Value.Item1.SelectedIndex = 0;
            par.Value.Item2.SelectedIndex = 0;

            InicioRangoDP.Value = Properties.Settings.Default.fecha;
            FinRangoDP.Value = Properties.Settings.Default.fecha;
        }

        private List<KeyValuePair<CheckBox, Tuple<ComboBox, ComboBox>>> WidgetsSeleccionados()
        {
            return widgets.Where(widget => widget.Key.Checked).ToList();
        }

        private List<Tuple<int, TimeSpan, TimeSpan>> DiasAtencionSeleccionados()
        {
            return WidgetsSeleccionados()
                .Select(par =>
                    new Tuple<int, TimeSpan, TimeSpan>(IDDiaPara(par.Key),
                        Horario(par.Value.Item1),
                        Horario(par.Value.Item2))).ToList();
        }
        private TimeSpan Horario(ComboBox comboHorario) 
        {
            return (TimeSpan)comboHorario.SelectedItem;
        }       
        private int IDDiaPara(CheckBox checkBox)
        {
            return widgets.Keys.ToList().IndexOf(checkBox) + 1;
        }
        private bool DiaDeInicioMenorADiaFin()
        {
            return InicioRangoDP.Value < FinRangoDP.Value;
        }
        private bool DiaInicioMayorAHoy()
        {
            return InicioRangoDP.Value > Properties.Settings.Default.fecha;
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
            SqlParameter idDia = new SqlParameter("@Dia_id", IDDiaPara(par.Key));
            SqlParameter horarioInicio = new SqlParameter("@Inicio_Horario", _horarioInicio);
            SqlParameter horarioFin = new SqlParameter("@Fin_Horario", _horarioFin);
            SqlParameter diaInicio = new SqlParameter("@Inicio_Dia", InicioRangoDP.Value);
            SqlParameter diaFin = new SqlParameter("@Fin_Dia", FinRangoDP.Value);

            return !QueryAdapterMaggie.ejecutarSPBooleano("AGENDARangoColisionaConAgendaExistente", idDia, idMedico, horarioInicio, horarioFin, diaInicio, diaFin);
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
        private Especialidad Especialidad()
        {

            return (Especialidad)especialidadesAgendaCB.SelectedItem;
        }
        private void AltaAP_Load(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}