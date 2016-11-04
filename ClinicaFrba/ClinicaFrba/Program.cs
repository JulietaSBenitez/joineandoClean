using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DAO;
using System.Data.SqlClient;
using ClinicaFrba.src;

namespace ClinicaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new AbmRol.AltaModificacionRol(Accion.Alta));
            //Application.Run(new RegistrarAgendaMedico.SeleccionarOpcionAP());

            Especialidad especialidad = new Especialidad();
            especialidad.ID = 0;
            Medico medico = new Medico();
            medico.ID = 0;
            System.Console.WriteLine(especialidad.YaTieneAgenda(medico));



        }

    }
}
