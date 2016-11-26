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
        }

        private void CancelarTurnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cancelarTurnoTipoRazon = new CancelarTurnoTipoRazon(ProfesionalCancelarTurno);
            cancelarTurnoTipoRazon.ShowDialog();
        }

        private void ProfesionalCancelarTurno(int cancelacionID, string razon)
        {

            SqlParameter dia;
            SqlParameter idCancelacion = new SqlParameter("@Cancelacion_id", cancelacionID);
            SqlParameter descripcion = new SqlParameter("@Descripcion", razon);
            SqlParameter idProfesional = new SqlParameter("@Medico_id", IDPersona);

            foreach (DateTime diaSeleccionado in DiasSeleccionados())
            {

                dia = new SqlParameter("@Dia", diaSeleccionado);
                QueryAdapterMaggie.ejecutarSP("CANCELACIONEliminarTurnoProfesional", dia, idCancelacion, descripcion, idProfesional);
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


    }
}
