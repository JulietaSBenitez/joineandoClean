using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class DAORoles
    {
        // private List<SqlParameter> parameters = null;
        //private SqlParameter parameter = null;
        private bool result = false;

        public static DataTable listarRoles()
        {


            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);

            try
            {
                data = SQLHelper.SQLHelper_ExecuteReader("listarRoles");
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


            //datosqlconect conecta
            //sqlcoecto execprdatatablwe pr listarRoles
            // return new DataTable();


        }


        public static void actualizarRol(int id, string nombre, bool habilitado, Dictionary<int, Boolean> funciones)
        {


            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                parameter = new SqlParameter("@id", SqlDbType.Int);
                parameter.Value = id;
                parameters.Add(parameter);

                parameter = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                parameter.Value = nombre;
                parameters.Add(parameter);

                parameter = new SqlParameter("@inhabilitado", SqlDbType.Bit);
                parameter.Value = !habilitado;
                parameters.Add(parameter);

                SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.actualizar_Rol", parameters);

                // Como barro un map?
                foreach (KeyValuePair<int, bool> funcionabilidad in funciones)
                {


                    parameters.Clear();

                    parameter = new SqlParameter("@idRol", SqlDbType.Int);
                    parameter.Value = id;
                    parameters.Add(parameter);

                    parameter = new SqlParameter("@idFuncionabilidad", SqlDbType.Int);
                    parameter.Value = funcionabilidad.Key;
                    parameters.Add(parameter);

                    if (funcionabilidad.Value == true) SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.alta_funcionabiliad_x_rol", parameters);
                    else SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.baja_funcionablilida_x_rol", parameters);

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



        public static void altaRol(string nombre, bool habilitado, Dictionary<int, Boolean> funciones)
        {


            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {



                parameter = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                parameter.Value = nombre;
                parameters.Add(parameter);

                parameter = new SqlParameter("@inhabilitado", SqlDbType.Bit);
                parameter.Value = !habilitado;
                parameters.Add(parameter);
                int id;

                id = int.Parse((SQLHelper.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.alta_Rol", parameters)).ToString());

                // Como barro un map?
                foreach (KeyValuePair<int, bool> funcionabilidad in funciones)
                {


                    parameters.Clear();

                    parameter = new SqlParameter("@idRol", SqlDbType.Int);
                    parameter.Value = id;
                    parameters.Add(parameter);

                    parameter = new SqlParameter("@idFuncionabilidad", SqlDbType.Int);
                    parameter.Value = funcionabilidad.Key;
                    parameters.Add(parameter);

                    if (funcionabilidad.Value == true) SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.alta_funcionabiliad_x_rol", parameters);
                    else SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.baja_funcionablilida_x_rol", parameters);

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




        public static DataTable propiedadesRol(int id)
        {

            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            parameter = new SqlParameter("@id", SqlDbType.Int);
            parameter.Value = id;


            parameters.Add(parameter);



            try
            {
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.Seleccionar_Propiedades_Rol", parameters);

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


        public static void inHabilitarRol(int id)
        {


            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            parameter = new SqlParameter("@id", SqlDbType.Int);
            parameter.Value = id;


            parameters.Add(parameter);



            try
            {
                SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.inHabilitar_Rol", parameters);
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


        public static DataTable funcionabilidadesHabilitadasXRol(int id)
        {


            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;
            parameter = new SqlParameter("@id", SqlDbType.Int);
            parameter.Value = id;


            parameters.Add(parameter);



            try
            {
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.Seleccionar_Funcionabilidades_x_Rol", parameters);

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


        public static DataTable listarFuncionalidades()
        {


            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);

            try
            {
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.seleccionar_funcionabilidades");
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







        public static DataTable filtro(int funcionabilidad, string habilitado)
        {

            //Se podria mejorar con un union
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);




            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;



            if (funcionabilidad != -1)
            {
                Console.WriteLine("funcion" + funcionabilidad);
                parameter = new SqlParameter("@idfuncionabilidad", SqlDbType.Int);
                parameter.Value = funcionabilidad;
                parameters.Add(parameter);
            }

            if (habilitado == "Habilitado")
            {
                Console.WriteLine("paso x aca");
                parameter = new SqlParameter("@habilitado", SqlDbType.Bit);
                parameter.Value = 1;
                parameters.Add(parameter);
            }

            if (habilitado == "Inhabilitado")
            {
                parameter = new SqlParameter("@habilitado", SqlDbType.Bit);
                parameter.Value = 0;
                parameters.Add(parameter);
            }






            try
            {
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.filtro_rol", parameters);

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
