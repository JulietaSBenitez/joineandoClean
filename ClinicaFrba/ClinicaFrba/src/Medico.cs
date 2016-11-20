﻿using System;
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
        public List<Agenda> Agendas { get; set; }

        public List<Especialidad> EspecialidadesSinAgenda()
        {
            return Especialidades.FindAll(especialidad => !especialidad.YaTieneAgenda(this));
        }

        public bool TrabajaMasDe48Horas()
        {
            return CantidadDeHorasTrabajadas() > 48;
        }

        public int CantidadDeHorasTrabajadas() { 
            return Agendas.Sum(agenda => agenda.CantidadDeHorasTrabajadas())}
    }
}
