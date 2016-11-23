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
             public static DataTable filtroAfiliados(String medico="",String especialidad="",String numeroTurno="",String numeroAfiliado = "",String hora="")
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

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
