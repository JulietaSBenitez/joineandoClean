using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class DAOListado
    {
        public static DataTable planes()
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {

                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.lista_planes", parameters);
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


        public static DataTable especialidades()
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
             
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.lista_especialidades", parameters);
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

        public static DataTable ListadoProfesionalesMasConsultadosPorPlan(int ano, int semestre, int planid)
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
                parameter = new SqlParameter("@anio", SqlDbType.Int);
                parameter.Value = ano;   
                parameters.Add(parameter);
                parameter = new SqlParameter("@semestre", SqlDbType.Int);
                parameter.Value = semestre;
                parameters.Add(parameter);

                parameter = new SqlParameter("@planid", SqlDbType.Int);
                parameter.Value = planid;
                parameters.Add(parameter);


                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoProfesionalesMasConsultadosPorPlan", parameters);
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



        }   public static DataTable ListadoAfiliadosConMayorBonosComprados(int ano, int semestre)
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
                parameter = new SqlParameter("@anio", SqlDbType.Int);
                parameter.Value = ano;   
                parameters.Add(parameter);
                parameter = new SqlParameter("@semestre", SqlDbType.Int);
                parameter.Value = semestre;
                parameters.Add(parameter);
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoAfiliadosConMayorBonosComprados", parameters);
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
        public static DataTable ListadoEspecialidadesConMasBonosUtilizados(int ano, int semestre)
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
                parameter = new SqlParameter("@anio", SqlDbType.Int);
                parameter.Value = ano;   
                parameters.Add(parameter);
                parameter = new SqlParameter("@semestre", SqlDbType.Int);
                parameter.Value = semestre;
                parameters.Add(parameter);
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoEspecialidadesConMasBonosUtilizados", parameters);
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
        public static DataTable ListadoProfesionalesConMenosHorasTrabajadas(int ano, int semestre,int planid, int especialidadid)
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
                parameter = new SqlParameter("@anio", SqlDbType.Int);
                parameter.Value = ano;   
                parameters.Add(parameter);
                parameter = new SqlParameter("@semestre", SqlDbType.Int);
                parameter.Value = semestre;
                parameters.Add(parameter);

                parameter = new SqlParameter("@planid", SqlDbType.Int);
                parameter.Value = planid;
                parameters.Add(parameter);
                parameter = new SqlParameter("@especialidadid", SqlDbType.Int);
                parameter.Value = especialidadid;
                parameters.Add(parameter);

                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoProfesionalesConMenosHorasTrabajadas", parameters);
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
        public static DataTable ListadoEspecialidadesConMasCancelaciones(int ano,int semestre )
        {

            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
                parameter = new SqlParameter("@anio", SqlDbType.Int);
                parameter.Value = ano;   
                parameters.Add(parameter);
                parameter = new SqlParameter("@semestre", SqlDbType.Int);
                parameter.Value = semestre;
                parameters.Add(parameter);
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoEspecialidadesConMasCancelaciones", parameters);
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
