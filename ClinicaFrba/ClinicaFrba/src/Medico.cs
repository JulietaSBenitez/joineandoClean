using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ClinicaFrba.DAO;

namespace ClinicaFrba.src
{
    public class Medico
    {
        public int ID { get; set; }
        public List<Especialidad> Especialidades { get; set; }

        public List<Especialidad> EspecialidadesSinAgenda()
        {
            return Especialidades.FindAll(especialidad => !especialidad.YaTieneAgenda(this));
        }


        public TimeSpan CantidadDeHorasTrabajadas()
        {
            SqlParameter idMedico = new SqlParameter("@Medico_id", ID);
            DataTable table = QueryAdapterMaggie.ejecutarSP("MEDICOHorasSemanales", idMedico);
            return new TimeSpan(Convert.ToInt32(table.Rows[0][0]), Convert.ToInt32(table.Rows[0][1]), 0);

        }

        /*public TimeSpan HorariosDeAgendas() {
            SqlParameter idMedico = new SqlParameter("@Medico_id", ID);
            DataTable table = QueryAdapterMaggie.ejecutarSPBooleano("MEDICONoColicionanSusAgendas", idMedico);
            return */
        }

    }
