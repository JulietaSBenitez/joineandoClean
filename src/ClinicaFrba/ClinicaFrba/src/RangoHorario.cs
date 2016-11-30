using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.src
{
    public class RangoHorario
    {

        public static List<TimeSpan> Rango(TimeSpan horaInicio, TimeSpan horaFin)
        {
            List<TimeSpan> horarios = new List<TimeSpan>();
            TimeSpan horario = horaInicio;

            while (horario <= horaFin)
            {
                horarios.Add(horario);
                horario = horario.Add(new TimeSpan(0, 30, 0));
            }

            return horarios;
        }

    }
}
