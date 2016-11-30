using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinicaFrba.Properties;
using System.Data;
using ClinicaFrba.src;

namespace ClinicaFrba.DAO
{
    class QueryAdapterMaggie
    {

        private static string infoConexion()
        {
            return Properties.Settings.Default.conector;

        }

        private static SqlConnection conexion()
        {
            SqlConnection conexion = new SqlConnection(infoConexion());
            return conexion;
        }

        public static List<DataRow> ejecutarSP(string nombreStoredProcedure, params SqlParameter[] parametros)
        {

            DataTable tabla = new DataTable();
            SqlConnection conexion = QueryAdapterMaggie.conexion();
            SqlCommand storedProcedure = new SqlCommand("JOINEANDO_ANDO." + nombreStoredProcedure, conexion);
            storedProcedure.CommandType = CommandType.StoredProcedure;

            if (parametros != null)
            {
                storedProcedure.Parameters.AddRange(parametros.ToArray());
            }

            SqlDataAdapter adaptador = new SqlDataAdapter(storedProcedure);

            adaptador.Fill(tabla);

            return tabla.AsEnumerable().ToList();


        }

        public static bool ejecutarSPBooleano(string nombreStoredProcedure, params SqlParameter[] parametros)
        {

            List<DataRow> filas = ejecutarSP(nombreStoredProcedure, parametros);
            return Convert.ToBoolean(filas.First()[0]);

        }

        public static int ejecutarSPEntero(string nombreStoredProcedure, params SqlParameter[] parametros)
        {

            List<DataRow> filas = ejecutarSP(nombreStoredProcedure, parametros);
            return Convert.ToInt32(filas.First()[0]);

        }
    }
}
