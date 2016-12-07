using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ClinicaFrba.DAO;

namespace ClinicaFrba.src
{
    public class Medico : Persona
    {
        public int ID { get; set; }
        public String Nombre { get; set; }


        public Medico(string nombre, int id)
        {
            Nombre = nombre;
            ID = id;
        }

        /*public List<Especialidad> EspecialidadesSinAgenda()
        {
            return Especialidades().FindAll(especialidad => !especialidad.YaTieneAgenda(this));
        }*/

        public static List<Medico> All()
        {
            List<DataRow> filas = QueryAdapterMaggie.ejecutarSP("MEDICOTodos");
            return Medico.Parse(filas);
        }

        private static List<Medico> Parse(List<DataRow> filas)
        {
            List<Medico> medicos = new List<Medico>();

            foreach (DataRow fila in filas)
            {
                medicos.Add(new Medico(
                    Convert.ToString(fila["Nombre"]) + " " + Convert.ToString(fila["Apellido"]),
                    Convert.ToInt32(fila["Medico_id"])));
            }

            return medicos;
        }

        public bool EsEspecialistaEn(Especialidad especialidad)
        {
            return Especialidades().Any(especialidadMedico => especialidadMedico.ID == especialidad.ID);
        }

        public TimeSpan CantidadDeHorasTrabajadas()
        {
            SqlParameter idMedico = new SqlParameter("@Medico_id", ID);
            DataRow fila = QueryAdapterMaggie.ejecutarSP("MEDICOHorasSemanales", idMedico).First();
            return new TimeSpan(Convert.ToInt32(fila["Horas"]), Convert.ToInt32(fila["Minutos"]), 0);

        }

        public List<Especialidad> Especialidades()
        {
            return Especialidad.EspecialidadesPara(ID);
        }

    }

}
