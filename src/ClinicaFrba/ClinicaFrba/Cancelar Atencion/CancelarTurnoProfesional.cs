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

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoProfesional : Form
    {

        int IDPersona;


        public CancelarTurnoProfesional(int id_persona)
        {
            InitializeComponent();

            IDPersona = id_persona;
            DiasACancelarCalendar.MinDate = Properties.Settings.Default.fecha;
            DiasACancelarCalendar.TodayDate = Properties.Settings.Default.fecha;
            DiasACancelarCalendar.SelectionStart = DiasACancelarCalendar.TodayDate;
        }

        private void CancelarTurnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cancelarTurnoTipoRazon = new CancelarTurnoTipoRazon(ProfesionalCancelarTurno);
            cancelarTurnoTipoRazon.ShowDialog();
        }

        private void ProfesionalCancelarTurno(int tipoCancelacionID, string razon)
        {
            foreach (DateTime diaSeleccionado in DiasSeleccionados())
            {
                SqlParameter idTipoCancelacion = new SqlParameter("@Tipo_Cancelacion_id", tipoCancelacionID);
                SqlParameter descripcion = new SqlParameter("@Descripcion", razon);
                SqlParameter idProfesional = new SqlParameter("@Medico_id", IDPersona);
                SqlParameter dia = new SqlParameter("@Dia", diaSeleccionado);
                QueryAdapterMaggie.ejecutarSP("CANCELACIONEliminarTurnoProfesional", dia, idTipoCancelacion, descripcion, idProfesional);
            }
        }

        private List<DateTime> DiasSeleccionados()
        {

            DateTime inicio = DiasACancelarCalendar.SelectionRange.Start;
            DateTime fin = DiasACancelarCalendar.SelectionRange.End;
            DateTime fecha = inicio;

            List<DateTime> fechas = new List<DateTime>();

            while (fecha <= fin)
            {

                fechas.Add(fecha);
                fecha = fecha.AddDays(1);

            }

            return fechas;
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VolverButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
