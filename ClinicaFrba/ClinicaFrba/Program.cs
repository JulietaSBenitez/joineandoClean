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
         //   Application.Run(new Registro_Llegada.RegistroDeLlegada());

            //Application.Run(new Login.Login());
            //Application.Run(new Abm_Afiliado.a);
            //Application.Run(new Abm_Afiliado.ListadoAfiliadosModificacion());
            //Application.Run(new Compra_Bono.BusquedaAfiliado());
           Application.Run(new Registro_Resultado.BusquedaResultado(10011));
        //    Medico medico = Medico.All().First();
     //       Application.Run(new Pedir_Turno.AltaTurno(medico));




        }

    }
}
