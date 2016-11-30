using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using ClinicaFrba.DAO;

namespace ClinicaFrba.src
{
    public class Especialidad
    {

        public int? ID { get; set; }
        public String Nombre { get; set; }

        public Especialidad(string nombre, int? id)
        {
            Nombre = nombre;
            ID = id;
        }   

        public static List<Especialidad> EspecialidadesPara(int id)
        {
            SqlParameter idMedico = new SqlParameter("@Medico_id", id);
            List<DataRow> filas =  QueryAdapterMaggie.ejecutarSP("ESPECIALIDADEspecialidadesMedico", idMedico);
            return Especialidad.Parse(filas);
        }
        public static List<Especialidad> All()
        {
            List<DataRow> filas = QueryAdapterMaggie.ejecutarSP("ESPECIALIDADTodas");
            return Especialidad.Parse(filas).OrderBy(especialidad => especialidad.Nombre).ToList();
        
        }
        private static List<Especialidad> Parse(List<DataRow> filas)
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            foreach (DataRow fila in filas)
            {           
                especialidades.Add(new Especialidad(
                    Convert.ToString(fila["Nombre_Especialidad"]),
                    Convert.ToInt32(fila["Especialidad_id"])));
            }

            return especialidades;
        }

        public Boolean YaTieneAgenda(Medico medico)
        {
            SqlParameter idMedico = new SqlParameter("@Medico_ID", medico.ID);
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_ID", ID);
            return QueryAdapterMaggie.ejecutarSPBooleano("ESPECIALIDADMedicoPoseeAgenda", idMedico, idEspecialidad);
            
        }


    }
}
