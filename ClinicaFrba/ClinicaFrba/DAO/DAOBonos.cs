using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClinicaFrba.DAO
{
    class DAOBonos
    {
        /*
        JOINEANDO_ANDO.compra_bono
@numeroAfiliado int,
@cantidad int
        */


        public static void compraBono(String numeroAfiliado, String cantidad,DateTime fecha)
        {

            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                parameter = new SqlParameter("@fecha", SqlDbType.DateTime);
                parameter.Value = fecha;
                parameters.Add(parameter);

                parameter = new SqlParameter("@cantidad", SqlDbType.Int);
                parameter.Value = int.Parse(cantidad);
                parameters.Add(parameter);


                parameter = new SqlParameter("@numeroAfiliado", SqlDbType.Int);
                parameter.Value = int.Parse(numeroAfiliado);
                parameters.Add(parameter);


                AdaptadorSQL.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.compra_bono", parameters);


            }
            catch (Exception ex)
            {
                AdaptadorSQL.RollBackTransction();
                throw ex;
            }
            finally
            {
                AdaptadorSQL.CommitTransction();
                AdaptadorSQL.ClearObjects();
            }

        }



        public static string precioBono(String nombre)
        {

            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {


       
                parameter = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                parameter.Value = nombre;
                parameters.Add(parameter);


                return (AdaptadorSQL.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.precio_bono", parameters).ToString());


            }
            catch (Exception ex)
            {
                AdaptadorSQL.RollBackTransction();
                throw ex;
            }
            finally
            {
                AdaptadorSQL.CommitTransction();
                AdaptadorSQL.ClearObjects();
            }

        }






    }
}
