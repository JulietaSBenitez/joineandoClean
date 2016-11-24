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
        public List<TimeSpan> _Turnos = new List<TimeSpan>();

        public Selección_de_Día_y_Horario(Especialidad especialidad, Medico medico)
        {
            InitializeComponent();

            ModelObjectE = especialidad;
            ModelObjectM = medico;

            CalendarioTurnos.MaxSelectionCount = 1;

            RefrescarDGV(new List<TimeSpan>() { new TimeSpan(10, 0, 0), 
                                                new TimeSpan(10, 30, 0) });

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Turnos();
        }

        private void Turnos()
        {
            SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectM.ID);
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", ModelObjectE.ID);
            SqlParameter diaSemana = new SqlParameter("@Dia_Semana", DiaDeLaSemana());
            List<DataRow> filas = QueryAdapterMaggie.ejecutarSP("TURNOHorarios", idMedico, idEspecialidad, diaSemana);
            _Turnos.Clear();

            foreach (DataRow fila in filas)
            {

                _Turnos = RangoHorario.Rango(TimeSpan.Parse((string)fila["Inicio_Horario"]), TimeSpan.Parse((string)fila["Fin_Horario"]));

            }

            RefrescarDGV(_Turnos);
        }

        private void RefrescarDGV(List<TimeSpan> valoresNuevos)
        {

            TurnosDisponiblesDGW.DataSource = valoresNuevos.Select(timespan => new { Horarios = timespan.ToString() }).ToList();
            
        }

        private int DiaDeLaSemana()
        {

            switch (CalendarioTurnos.SelectionRange.Start.DayOfWeek)
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

        private bool EstaOcupado(DataGridViewRow fila) {

            dynamic horario = fila.DataBoundItem;
            SqlParameter horarioTurno = new SqlParameter("@Horario", horario.Horarios);
            SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectM.ID);
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", ModelObjectE.ID);
            SqlParameter diaSeleccionado = new SqlParameter("@Dia_seleccionado", CalendarioTurnos.SelectionRange.Start.Date);
            return QueryAdapterMaggie.ejecutarSPBooleano("TURNOEstaDisponible", horarioTurno, idMedico, idEspecialidad, diaSeleccionado);


        }

        private void TurnosDisponiblesDGW_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow fila = TurnosDisponiblesDGW.Rows[e.RowIndex];
            if (EstaOcupado(fila))
            {
                fila.DefaultCellStyle.BackColor = Color.Red;
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





    }
}
