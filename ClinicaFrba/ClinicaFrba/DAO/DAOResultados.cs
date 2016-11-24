using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class DAOResultados
    {



        public static void guardarResultado(String paciente_id, String consulta_id,String enfermedad, String diagnostico, List<String> sintomas,String horario)
        {

            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                parameter = new SqlParameter("@paciente", SqlDbType.Int);
                parameter.Value = int.Parse(paciente_id);
                parameters.Add(parameter);


                parameter = new SqlParameter("@consulta", SqlDbType.Int);
                parameter.Value = int.Parse(consulta_id);
                parameters.Add(parameter);

                parameter = new SqlParameter("@enfermedad", SqlDbType.NChar,255);
                parameter.Value = enfermedad;
                parameters.Add(parameter);

                parameter = new SqlParameter("@horario", SqlDbType.NChar, 255);
                parameter.Value = horario;
                parameters.Add(parameter);

                parameter = new SqlParameter("@diagnostico", SqlDbType.NChar,255);
                parameter.Value = diagnostico;
                parameters.Add(parameter);

           

                int resultado_id = int.Parse(SQLHelper.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.cargar_diagnostico", parameters).ToString());

                foreach(String sintoma in sintomas){
                    parameters.Clear();

                    
                parameter = new SqlParameter("@resultado", SqlDbType.Int);
                parameter.Value = resultado_id;
                parameters.Add(parameter);
                    
                parameter = new SqlParameter("@sintoma", SqlDbType.NChar,255);
                parameter.Value = sintoma;
                parameters.Add(parameter);


                    SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.cargar_sintoma", parameters);
                }

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





        //PONER LOS FILTROS BIEN
        public static DataTable filtroAfiliados(int medico,String numeroAfiliado = "", String hora = "",String turno="")
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

               
                    parameter = new SqlParameter("@medico", SqlDbType.Int);
                    parameter.Value = medico;
                    parameters.Add(parameter);
                

                if (hora != "")
                {
                    parameter = new SqlParameter("@fecha", SqlDbType.NVarChar, 255);
                    parameter.Value = hora;
                    parameters.Add(parameter);
                }
                if (turno != "")
                {
                    parameter = new SqlParameter("@numeroTurno", SqlDbType.Int);
                    parameter.Value = int.Parse(turno);
                    parameters.Add(parameter);
                }




                if (numeroAfiliado != "")
                {
                    parameter = new SqlParameter("@numeroAfiliado", SqlDbType.Int);
                    parameter.Value = int.Parse(numeroAfiliado);
                    parameters.Add(parameter);
                }




                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.busqueda_medico_resultado", parameters);
                return data;
            }
            catch (Exception ex)
            {
                SQLHelper.RollBackTransction();
                throw ex;
            }
            finally
            {
                SQLHelper.ClearObjects();
            }
        }












    }
}
