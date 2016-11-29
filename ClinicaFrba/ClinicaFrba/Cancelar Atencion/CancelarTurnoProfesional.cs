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

            CalendarioProfesional.TodayDate = Properties.Settings.Default.fecha;
        }

        private void CancelarTurnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cancelarTurnoTipoRazon = new CancelarTurnoTipoRazon(ProfesionalCancelarTurno);
            cancelarTurnoTipoRazon.ShowDialog();
        }

        private void ProfesionalCancelarTurno(int tipoCancelacionID, string razon)
        {

            SqlParameter dia;
            SqlParameter idTipoCancelacion = new SqlParameter("@Tipo_Cancelacion_id", tipoCancelacionID);
            SqlParameter descripcion = new SqlParameter("@Descripcion", razon);
            SqlParameter idProfesional = new SqlParameter("@Medico_id", IDPersona);

            foreach (DateTime diaSeleccionado in DiasSeleccionados())
            {

                dia = new SqlParameter("@Dia", diaSeleccionado);
                QueryAdapterMaggie.ejecutarSP("CANCELACIONEliminarTurnoProfesional", dia, idTipoCancelacion, descripcion, idProfesional);
            }
        }

        private List<DateTime> DiasSeleccionados()
        {

            DateTime inicio = CalendarioProfesional.SelectionRange.Start;
            DateTime fin = CalendarioProfesional.SelectionRange.End;
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


    }
}
