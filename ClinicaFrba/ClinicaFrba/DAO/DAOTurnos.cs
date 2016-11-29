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
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
                SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.confirmar_presencia", parameters);
                SQLHelper.CommitTransction();

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



        public static int bonosDisponibles(String numeroAfiliado)
        {

            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {


                parameter = new SqlParameter("@numeroAfiliado", SqlDbType.BigInt);
                parameter.Value = numeroAfiliado;
                parameters.Add(parameter);

           

                return int.Parse(SQLHelper.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.bonos_disponibles", parameters).ToString());


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
             public static DataTable filtroAfiliados(DateTime hora,String medico="",String especialidad="",String numeroTurno="",String numeroAfiliado = "")
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
           

                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_registro_atencion", parameters);
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





             //PONER LOS FILTROS BIEN
             public static DataTable listadoEspecialidades()
             {
                 DataTable data = new DataTable();
                 SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
                 SQLHelper.CreateObjects(true);
                 List<SqlParameter> parameters = new List<SqlParameter>();
                 parameters.Clear();
                 SqlParameter parameter;

                 try
                 {

                    

                     data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_especialidades", parameters);
                    data.Rows.Add(data.NewRow());
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
