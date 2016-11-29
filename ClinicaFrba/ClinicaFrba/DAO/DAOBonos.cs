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


        public static void compraBono(String numeroAfiliado, String cantidad)
        {

            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {



                parameter = new SqlParameter("@cantidad", SqlDbType.Int);
                parameter.Value = int.Parse(cantidad);
                parameters.Add(parameter);


                parameter = new SqlParameter("@numeroAfiliado", SqlDbType.Int);
                parameter.Value = int.Parse(numeroAfiliado);
                parameters.Add(parameter);


                SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.compra_bono", parameters);


            }
            catch (Exception ex)
            {
                SQLHelper.RollBackTransction();
                throw ex;
            }
            finally
            {
                SQLHelper.CommitTransction();
                SQLHelper.ClearObjects();
            }

        }



        public static string precioBono(String nombre)
        {

            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {


       
                parameter = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                parameter.Value = nombre;
                parameters.Add(parameter);


                return (SQLHelper.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.precio_bono", parameters).ToString());


            }
            catch (Exception ex)
            {
                SQLHelper.RollBackTransction();
                throw ex;
            }
            finally
            {
                SQLHelper.CommitTransction();
                SQLHelper.ClearObjects();
            }

        }






    }
}
