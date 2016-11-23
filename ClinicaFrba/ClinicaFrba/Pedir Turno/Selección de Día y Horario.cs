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

        public Selección_de_Día_y_Horario(Especialidad especialidad, Medico medico)
        {
            InitializeComponent();
            ModelObjectE = especialidad;
            ModelObjectM = medico;
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaTurno seleccion = new AltaTurno();
            seleccion.ShowDialog();
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (CalendarioTurnos.SelectionEnd != null) {
                SqlParameter idMedico = new SqlParameter("@Medico_id", ModelObjectM.ID);
                SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", ModelObjectE.ID);
                SqlParameter diaSemana = new SqlParameter("@Dia_Semana", CalendarioTurnos.SelectionRange.Start.DayOfWeek);
                List<DataRow> filas = QueryAdapterMaggie.ejecutarSP("TURNODisponibilidadHoraria", idMedico, idEspecialidad, diaSemana);
                //Acá debería devolver una lista de turnos, pero todavía no tengo eso definido.
            

            }
        }

    }
}
