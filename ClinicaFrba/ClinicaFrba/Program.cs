using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DAO;
using System.Data.SqlClient;

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
           SqlParameter parametro = new SqlParameter("@Numero", 1);
           var resultado = QueryAdapterMaggie.ejecutarSP("TEST.Hola123", parametro);
           System.Console.WriteLine(resultado.Rows[0][0]);
        }
        
    }
}
