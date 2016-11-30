using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class DAOTurnos
    {


        public static void confirmarPresencia(string turno, string numeroAfiliado, DateTime horario)
        {


            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;


            parameter = new SqlParameter("@turno", SqlDbType.Int);
            parameter.Value = int.Parse(turno);
            parameters.Add(parameter);

            parameter = new SqlParameter("@numeroAfiliado", SqlDbType.Int);
            parameter.Value = int.Parse(numeroAfiliado);
            parameters.Add(parameter);


            parameter = new SqlParameter("@horario", SqlDbType.DateTime);
            parameter.Value = horario;
            parameters.Add(parameter);



            try
            {
                AdaptadorSQL.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.confirmar_presencia", parameters);
                AdaptadorSQL.CommitTransction();

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



        public static int bonosDisponibles(String numeroAfiliado)
        {

            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {


                parameter = new SqlParameter("@numeroAfiliado", SqlDbType.BigInt);
                parameter.Value = numeroAfiliado;
                parameters.Add(parameter);

           

                return int.Parse(AdaptadorSQL.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.bonos_disponibles", parameters).ToString());


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






        //PONER LOS FILTROS BIEN
             public static DataTable filtroAfiliados(DateTime hora,String medico="",String especialidad="",String numeroTurno="",String numeroAfiliado = "")
        {
            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                parameter = new SqlParameter("@fecha", SqlDbType.DateTime);
                parameter.Value = hora;
                parameters.Add(parameter); 

                if (medico != "") {
                    parameter = new SqlParameter("@medico", SqlDbType.NVarChar,255);
                    parameter.Value = medico;
                    parameters.Add(parameter); 
                }

                if (especialidad != "")
                {
                    parameter = new SqlParameter("@especialidad", SqlDbType.NVarChar, 255);
                    parameter.Value = especialidad;
                    parameters.Add(parameter);
                }
           

                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_registro_atencion", parameters);
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





             //PONER LOS FILTROS BIEN
             public static DataTable listadoEspecialidades()
             {
                 DataTable data = new DataTable();
                 AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
                 AdaptadorSQL.CreateObjects(true);
                 List<SqlParameter> parameters = new List<SqlParameter>();
                 parameters.Clear();
                 SqlParameter parameter;

                 try
                 {

                    

                     data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_especialidades", parameters);
                    data.Rows.Add(data.NewRow());
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








    }
}
