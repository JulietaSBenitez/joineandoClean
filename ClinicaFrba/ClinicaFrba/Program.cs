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

            //Application.Run(new Login.Login());

  //    Application.Run(new Abm_Afiliado.a);
    //       Application.Run(new Abm_Afiliado.ListadoAfiliadosModificacion());
       //     Application.Run(new Compra_Bono.BusquedaAfiliado());
                 Application.Run(new Registro_Llegada.RegistroDeLlegada());
            

          //  Medico jorge = new Medico { Especialidades = new List<Especialidad> { new Especialidad { Nombre = "Cirujano" } } };
        //    Application.Run(new RegistrarAgendaMedico.SeleccionarOpcionAP(jorge));

       
    //        Medico jorge = new Medico { Especialidades = new List<Especialidad> { new Especialidad { Nombre = "Cirujano" } } };
//           Application.Run(new RegistrarAgendaMedico.SeleccionarOpcionAP(jorge));


        }

    }
}
