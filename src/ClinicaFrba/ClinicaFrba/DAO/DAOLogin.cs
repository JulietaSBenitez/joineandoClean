using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class DAOLogin
    {


        public static DataTable roles_x_usuario(int userId) {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                parameter = new SqlParameter("@UserId", SqlDbType.Int);
                parameter.Value = userId;
                parameters.Add(parameter);

              

                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.roles_x_usuario", parameters);

                return data;




            }
            catch (Exception ex)
            {
                AdaptadorSQL.RollBackTransction();
                throw ex;
            }
            finally
            {

                AdaptadorSQL.ClearObjects();
            }


        
        }




        public static int login(string username, string password)
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                parameter = new SqlParameter("@UserId", SqlDbType.NVarChar, 50);
                parameter.Value = username;
                parameters.Add(parameter);

                parameter = new SqlParameter("@Pas", SqlDbType.NVarChar, 50);
                parameter.Value = password;
                parameters.Add(parameter);

                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.validar_usuario", parameters);

                return int.Parse(data.Rows[0][1].ToString());




            }
            catch (Exception ex)
            {
                AdaptadorSQL.RollBackTransction();
                throw ex;
            }
            finally
            {
               
                AdaptadorSQL.ClearObjects();
            }



        }



















    }
}
