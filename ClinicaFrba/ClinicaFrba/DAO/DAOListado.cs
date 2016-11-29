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
        public static DataTable especialidades()
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            try
            {
             
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.lista_especialidades", parameters);
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

        public static DataTable ListadoProfesionalesMasConsultadosPorPlan(int ano, int semestre)
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoProfesionalesMasConsultadosPorPlan", parameters);
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



        }   public static DataTable ListadoAfiliadosConMayorBonosComprados(int ano, int semestre)
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoAfiliadosConMayorBonosComprados", parameters);
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
        public static DataTable ListadoEspecialidadesConMasBonosUtilizados(int ano, int semestre)
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoEspecialidadesConMasBonosUtilizados", parameters);
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
        public static DataTable ListadoProfesionalesConMenosHorasTrabajadas(int ano, int semestre)
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoProfesionalesConMenosHorasTrabajadas", parameters);
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
        public static DataTable ListadoEspecialidadesConMasCancelaciones(int ano,int semestre )
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
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
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.ListadoEspecialidadesConMasCancelaciones", parameters);
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
