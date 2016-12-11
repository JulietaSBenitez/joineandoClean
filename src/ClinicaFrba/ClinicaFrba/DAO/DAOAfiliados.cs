using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.DAO
{
    class DAOAfiliados
    {

        

        public static int crearAfiliado(DateTime fecha,String nombre, String apellido, String tipo, String numeroDocumento, String direccion, String sexo, String telefono, String email, String fechanac, String estadoCivil, String familiaresACargo,String plan,int raiz = 0, int sub = 0)
        {

            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {


                parameter = new SqlParameter("@fechanac", SqlDbType.DateTime, 255);
                parameter.Value = fechanac;
                parameters.Add(parameter);

                parameter = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                parameter.Value = nombre;
                parameters.Add(parameter);

                parameter = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
                parameter.Value = apellido;
                parameters.Add(parameter);

                parameter = new SqlParameter("@tipo", SqlDbType.NVarChar, 255);
                parameter.Value = tipo;
                parameters.Add(parameter);

                parameter = new SqlParameter("@sexo", SqlDbType.NVarChar, 255);
                parameter.Value = sexo;
                parameters.Add(parameter);

                parameter = new SqlParameter("@numeroDocumento", SqlDbType.BigInt);
                parameter.Value = long.Parse(numeroDocumento);
                parameters.Add(parameter);

                parameter = new SqlParameter("@direccion", SqlDbType.NVarChar, 255);
                parameter.Value = direccion;
                parameters.Add(parameter);

                parameter = new SqlParameter("@telefono", SqlDbType.BigInt);
                parameter.Value = long.Parse(telefono);
                parameters.Add(parameter);


                parameter = new SqlParameter("@plan", SqlDbType.NVarChar, 255);
                parameter.Value = plan;
                parameters.Add(parameter);

                if (raiz != 0)
                {
                    parameter = new SqlParameter("@raiz", SqlDbType.BigInt);
                    parameter.Value = raiz;
                    parameters.Add(parameter);
                }
                if (sub != 0)
                {
                    parameter = new SqlParameter("@sub", SqlDbType.BigInt);
                    parameter.Value = sub;
                    parameters.Add(parameter);
                }
                parameter = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
                parameter.Value = email;
                parameters.Add(parameter);

                parameter = new SqlParameter("@estadoCivil", SqlDbType.NVarChar, 255);
                parameter.Value = estadoCivil;
                parameters.Add(parameter);

                parameter = new SqlParameter("@familiares", SqlDbType.Int);
                parameter.Value = int.Parse(familiaresACargo);
                parameters.Add(parameter);

                parameter = new SqlParameter("@fecha", SqlDbType.DateTime);
                parameter.Value = fecha;
                parameters.Add(parameter);

                return int.Parse(AdaptadorSQL.SQLHelper_ExecuteScalar("JOINEANDO_ANDO.crear_paciente", parameters).ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: El paciente que usted intenta insertar ya ha sido insertado", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdaptadorSQL.RollBackTransction();
                throw ex;
            }
            finally
            {
                AdaptadorSQL.CommitTransction();
                AdaptadorSQL.ClearObjects();
            }

        }






        public static void actualizarAfiliado(DateTime fecha,String direccion, String telefono, String email, String estadoCivil, String familiaresACargo, String plan, String numeroAfiliado, String razon="")
        {

            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                parameter = new SqlParameter("@fecha", SqlDbType.DateTime);
                parameter.Value = fecha;
                parameters.Add(parameter);

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


                if (razon != "") {
                    parameter = new SqlParameter("@razon", SqlDbType.NVarChar, 255);
                    parameter.Value = razon;
                    parameters.Add(parameter);
                
                }

                parameter = new SqlParameter("@familiaresACargo", SqlDbType.Int);
                parameter.Value = int.Parse(familiaresACargo);
                parameters.Add(parameter);






                AdaptadorSQL.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.actualizar_paciente", parameters);
             

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




        public static void bajaAfiliado(String numeroAfiliado,DateTime fecha)
        {

            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                parameter = new SqlParameter("@fecha", SqlDbType.DateTime);
                parameter.Value = fecha;
                parameters.Add(parameter);


                parameter = new SqlParameter("@numeroAfiliado", SqlDbType.BigInt);
                parameter.Value = long.Parse(numeroAfiliado);
                parameters.Add(parameter);


                AdaptadorSQL.SQLHelper_ExecuteNonQuery("JOINEANDO_ANDO.baja_paciente", parameters);


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




        public static DataTable tiposDeSexo()
        {
            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                // parameter = new SqlParameter("@UserId", SqlDbType.Int);
                //  parameter.Value = userId;
                //  parameters.Add(parameter);
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_sexo", parameters);
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

        public static DataTable listarCambios(string numero_afiliado)
        {
            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                 parameter = new SqlParameter("@numero_afiliado", SqlDbType.BigInt);
                  parameter.Value = long.Parse(numero_afiliado);
                  parameters.Add(parameter);
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listar_cambios", parameters);
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



        public static DataTable tiposDePlanes()
        {
            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
                // parameter = new SqlParameter("@UserId", SqlDbType.Int);
                //  parameter.Value = userId;
                //  parameters.Add(parameter);
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_planes", parameters);
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



        public static DataTable tiposDeDocumentos()
        {
            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Clear();
            SqlParameter parameter;

            try
            {
     
                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.listado_tipo_documentos", parameters);
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

        public static DataTable filtroAfiliados(string nombre = "", string apellido = "", string tipo = "", string numeroDocumento = "")
        {
            DataTable data = new DataTable();
            AdaptadorSQL.ConnectionValue = Properties.Settings.Default.conector;
            AdaptadorSQL.CreateObjects(true);
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


                data = AdaptadorSQL.SQLHelper_ExecuteReader("JOINEANDO_ANDO.filtro_paciente", parameters);
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
