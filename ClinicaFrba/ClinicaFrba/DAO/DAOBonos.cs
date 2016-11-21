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
