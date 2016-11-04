using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.DAO;
using System.Data.SqlClient;
using System.Data;

namespace ClinicaFrba.src
{
    class Especialidad
    {

        public int ID { get; set; }

        public Boolean YaTieneAgenda(Medico medico)
        {
            SqlParameter idMedico = new SqlParameter("@Medico_ID", medico.ID);
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_ID", ID);
            DataTable dataTable = QueryAdapterMaggie.ejecutarSP("ESPECIALIDADMedicoPoseeAgenda", idMedico, idEspecialidad);
            return Convert.ToBoolean(dataTable.Rows[0][0]);
        }


    }
}
