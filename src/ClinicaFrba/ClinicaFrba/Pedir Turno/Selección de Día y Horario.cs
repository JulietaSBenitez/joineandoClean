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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Selección_de_Día_y_Horario : Form
    {

        public Medico ModelObjectM { get; set; }
        public Especialidad ModelObjectE { get; set; }
        public int PacienteID;
        public List<TimeSpan> _Turnos = new List<TimeSpan>();
        private List<ValidacionBooleana<Selección_de_Día_y_Horario>> validaciones = new List<ValidacionBooleana<Selección_de_Día_y_Horario>>();

        public Selección_de_Día_y_Horario(Especialidad especialidad, Medico medico, int idPaciente)
        {
            InitializeComponent();

            ModelObjectE = especialidad;
            ModelObjectM = medico;
            PacienteID = idPaciente;

            CalendarioTurnos.MaxSelectionCount = 1;
            CalendarioTurnos.MinDate = Properties.Settings.Default.fecha;
            CalendarioTurnos.TodayDate = Properties.Settings.Default.fecha;
            CalendarioTurnos.SelectionStart = CalendarioTurnos.TodayDate;

            TurnosDisponiblesDGW.AllowUserToAddRows = false;
            TurnosDisponiblesDGW.ReadOnly = true;

            validaciones.Add(new ValidacionBooleana<Selección_de_Día_y_Horario>(
            (controlador => controlador.HayDiaSeleccionado()),
            "No se ha seleccionado ningún día."));

            validaciones.Add(new ValidacionBooleana<Selección_de_Día_y_Horario>(
            (controlador => controlador.DiaSeleccionadoEsMayorQueElDiaActual()),
            "El día seleccionado es menor al actual."));

            validaciones.Add(new ValidacionBooleana<Selección_de_Día_y_Horario>(
            (controlador => controlador.HayHorarioSeleccionado()),
            "No se ha seleccionado ningún horario."));

            validaciones.Add(new ValidacionBooleana<Selección_de_Día_y_Horario>(
            (controlador => controlador.TurnoValido()),
            "El turno seleccionado no está disponible."));

        }

        private void Turnos()
        {            
            TimeSpan inicio;
            TimeSpan fin;

            if (DiaDeLaSemana() == 6)
            {
                inicio = new TimeSpan(10, 0, 0);
                fin = new TimeSpan(15, 0, 0);

            }
            else
            {

                inicio = new TimeSpan(7, 0, 0);
                fin = new TimeSpan(20, 0, 0);

            }

            _Turnos = RangoHorario.Rango(inicio, fin);
            RefrescarDGV(_Turnos);
        }

        private void RefrescarDGV(List<TimeSpan> valoresNuevos)
        {
            TurnosDisponiblesDGW.DataSource = valoresNuevos.Select(timespan => new { Horarios = timespan.ToString() }).ToList();
        }

        private DateTime DiaTurno()
        {
            return CalendarioTurnos.SelectionStart;
        }

        private int DiaDeLaSemana()
        {

            switch (CalendarioTurnos.SelectionStart.DayOfWeek)
            {

                case DayOfWeek.Monday:
                    return 1;

                case DayOfWeek.Tuesday:
                    return 2;

                case DayOfWeek.Wednesday:
                    return 3;

                case DayOfWeek.Thursday:
                    return 4;

                case DayOfWeek.Friday:
                    return 5;

                case DayOfWeek.Saturday:
                    return 6;

                default:
                    return 0;

            }


        }

        private bool EstaOcupado(DataGridViewRow fila)
        {
            dynamic horario = fila.DataBoundItem;
            SqlParameter horarioTurno = new SqlParameter("@Horario", horario.Horarios);
            SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectM.ID);
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", ModelObjectE.ID);
            SqlParameter diaSeleccionado = new SqlParameter("@Dia_seleccionado", CalendarioTurnos.SelectionRange.Start.Date);            
            SqlParameter fecha = new SqlParameter("@Dia_id", DiaDeLaSemana());

            return QueryAdapterMaggie.ejecutarSPBooleano("TURNOEstaOcupado", horarioTurno, idMedico, idEspecialidad, diaSeleccionado, fecha);
        }

        private bool HayDiaSeleccionado()
        {
            return CalendarioTurnos.SelectionRange.Start != null;
        }

        private bool HayHorarioSeleccionado()
        {
            return TurnosDisponiblesDGW.SelectedCells.Count != 0;
        }

        private bool TurnoValido()
        {
            return !EstaOcupado(TurnosDisponiblesDGW.CurrentRow);
        }
        private bool DiaSeleccionadoEsMayorQueElDiaActual()
        {

            return CalendarioTurnos.SelectionRange.Start >= Properties.Settings.Default.fecha;

        }

        private void TurnosDisponiblesDGW_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow fila = TurnosDisponiblesDGW.Rows[e.RowIndex];
            if (EstaOcupado(fila))
            {
                fila.DefaultCellStyle.BackColor = Color.Red;
                fila.ReadOnly.ToString();
            }
            else
            {
                fila.DefaultCellStyle.BackColor = Color.Green;
            }
        }
        private void TurnosDisponiblesDGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TurnosDisponiblesDGW.ClearSelection();
        }
        private void VolverButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Turnos();
        }
        private void ConfirmarTurnoButton_Click(object sender, EventArgs e)
        {
            if (validaciones.All(validacion => validacion.SeCumple(this)))
            {
                SqlParameter idPersona = new SqlParameter("@Paciente_id", PacienteID);
                SqlParameter fechaSeleccionada = new SqlParameter("@Fecha", CalendarioTurnos.SelectionStart);
                SqlParameter horario = new SqlParameter("@Horario", HorarioTurno());
                SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectM.ID);
                SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", ModelObjectE.ID);
                SqlParameter idDia = new SqlParameter("@Dia_id", DiaDeLaSemana());

                QueryAdapterMaggie.ejecutarSP("TURNOInsertarNuevo", idPersona, fechaSeleccionada, horario, idMedico, idEspecialidad, idDia);

                MessageBox.Show("El turno fue creado con éxito");
                TurnosDisponiblesDGW.ClearSelection();

            }
            else
            {
                ValidacionBooleana<Selección_de_Día_y_Horario> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime HorarioTurno()
        {
            dynamic obj = TurnosDisponiblesDGW.CurrentRow.DataBoundItem;
            return DateTime.Parse(obj.Horarios);
        }

    }
}
