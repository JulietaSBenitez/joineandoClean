using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DAO
{
    class DAOAfiliados
    {

        /*
 @nombre nvarchar(255) = '',
 @tipo nvarchar(255) = 'DNI',
 @numeroDocumento numeric(18,0) = 0,
 @apellido nvarchar(255) = '',
 @direccion nvarchar(255) = '',
 @sexo nvarchar(255) = '',
 @telefono numeric(18,0) = 0,
 @mail nvarchar(50)='',
 @fechaNac datetime = '5/5/5',
 @estadoCivil nvarchar(255) = '',
 @familiares int=0,
 @raiz int=0,
 @sub int=0,
 @plan nvarchar(255) = ''
         * */






        public static void crearAfiliado(String direccion, String telefono, String email, String estadoCivil, String familiaresACargo, String plan, String numeroAfiliado)
        {

            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                parameter = new SqlParameter("@direccion", SqlDbType.NVarChar, 255);
                parameter.Value = direccion;
                parameters.Add(parameter);

                parameter = new SqlParameter("@telefono", SqlDbType.BigInt);
                parameter.Value = long.Parse(telefono);
                parameters.Add(parameter);


                parameter = new SqlParameter("@plan", SqlDbType.NVarChar, 255);
                parameter.Value = plan;
                parameters.Add(parameter);

                parameter = new SqlParameter("@numero_afiliado", SqlDbType.BigInt);
                parameter.Value = int.Parse(numeroAfiliado);
                parameters.Add(parameter);



                parameter = new SqlParameter("@email", SqlDbType.NVarChar, 255);
                parameter.Value = email;
                parameters.Add(parameter);

                parameter = new SqlParameter("@estadoCivil", SqlDbType.NVarChar, 255);
                parameter.Value = estadoCivil;
                parameters.Add(parameter);

                parameter = new SqlParameter("@familiaresACargo", SqlDbType.Int);
                parameter.Value = int.Parse(familiaresACargo);
                parameters.Add(parameter);






                SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.actualizar_paciente", parameters);


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






        public static void actualizarAfiliado(String direccion, String telefono, String email, String estadoCivil, String familiaresACargo, String plan, String numeroAfiliado)
        {

            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                parameter = new SqlParameter("@direccion", SqlDbType.NVarChar, 255);
                parameter.Value = direccion;
                parameters.Add(parameter);

                parameter = new SqlParameter("@telefono", SqlDbType.BigInt);
                parameter.Value = long.Parse(telefono);
                parameters.Add(parameter);


                parameter = new SqlParameter("@plan", SqlDbType.NVarChar, 255);
                parameter.Value = plan;
                parameters.Add(parameter);

                parameter = new SqlParameter("@numero_afiliado", SqlDbType.BigInt);
                parameter.Value = int.Parse(numeroAfiliado);
                parameters.Add(parameter);



                parameter = new SqlParameter("@email", SqlDbType.NVarChar, 255);
                parameter.Value = email;
                parameters.Add(parameter);

                parameter = new SqlParameter("@estadoCivil", SqlDbType.NVarChar, 255);
                parameter.Value = estadoCivil;
                parameters.Add(parameter);

                parameter = new SqlParameter("@familiaresACargo", SqlDbType.Int);
                parameter.Value = int.Parse(familiaresACargo);
                parameters.Add(parameter);






                SQLHelper.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.actualizar_paciente", parameters);
             

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


        public static DataTable tiposDeSexo()
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                // parameter = new SqlParameter("@UserId", SqlDbType.Int);
                //  parameter.Value = userId;
                //  parameters.Add(parameter);
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_sexo", parameters);
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


        public static DataTable tiposDePlanes()
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                // parameter = new SqlParameter("@UserId", SqlDbType.Int);
                //  parameter.Value = userId;
                //  parameters.Add(parameter);
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_planes", parameters);
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



        public static DataTable tiposDeDocumentos()
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                // parameter = new SqlParameter("@UserId", SqlDbType.Int);
                //  parameter.Value = userId;
                //  parameters.Add(parameter);
                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_tipo_documentos", parameters);
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

        public static DataTable filtroAfiliados(string nombre = "", string apellido = "", string tipo = "", string numeroDocumento = "")
        {
            DataTable data = new DataTable();
            SQLHelper.ConnectionValue = Properties.Settings.Default.conector;
            SQLHelper.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {

                if (nombre != "") {
                    parameter = new SqlParameter("@nombre", SqlDbType.NVarChar,255);
                    parameter.Value = nombre;
                    parameters.Add(parameter); 
                }
                if (apellido != "")
                {
                    parameter = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
                    parameter.Value = apellido;
                    parameters.Add(parameter);
                }
                if (tipo != "")
                {
                    parameter = new SqlParameter("@tipo", SqlDbType.NVarChar, 255);
                    parameter.Value = tipo;
                    parameters.Add(parameter);
                }

                if (numeroDocumento != "")
                {
                    parameter = new SqlParameter("@numerodocumento", SqlDbType.NVarChar, 255);
                    parameter.Value = numeroDocumento;
                    parameters.Add(parameter);
                }


                data = SQLHelper.SQLHelper_ExecuteReader("JOINEANDO_ANDO.filtro_paciente", parameters);
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
