using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Login
{
    public partial class Acciones : Form
    {
        int user_id;
        int rol_id;
        DataTable funcionabilidades;
        public Acciones()
        {
            InitializeComponent();
        }

        public Acciones(int rol,int user )
        {   rol_id = rol;
            user_id = user;
            InitializeComponent();
            funcionabilidades= DAO.DAORoles.funcionabilidadesHabilitadasXRol(rol_id);

                foreach (DataRow row in funcionabilidades.Rows)
            {

                comboBox1.Items.Add(row["Nombre"].ToString());
                comboBox1.SelectedIndex = 0;
                    
                 
            }

        }


        private void Acciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text) { 

         /*           Select 'Alta Rol
Select 'Modificacion Rol'
Select 'Baja Rol'
Select 'Alta Afiliado'
Select 'Modificacion Afiliado'
Select 'Baja Afiliado'
Select 'Alta Agenda Profesional'
Select 'Compra bonos'
Select 'Pedido turnos'
Select 'Cancerlar turnos'
Select 'Registo de llegada'
Select 'Registo de resultados'
Select 'Listado Estadistico'
    */

                case "Alta Rol":
                    new AbmRol.AltaModificacionRol(Accion.Alta).ShowDialog();
                    break;
                case "Baja Rol":
                    new AbmRol.ListadoRoles(Accion.Baja).ShowDialog();
                    break;
                case "Modificacion Rol":
                    new AbmRol.ListadoRoles(Accion.Modificacion).ShowDialog();
                    break;
                
                case "Alta Afiliado":
                    new Abm_Afiliado.AltaModificacionAfiliados(Accion.Alta).ShowDialog();
                    break;

                case "Modificacion Afiliado":
                    new Abm_Afiliado.ListadoAfiliadosModificacion().ShowDialog();
                    break;


                case "Baja Afiliado":
                    new Abm_Afiliado.ListadoAfiliadosBaja().ShowDialog();
                    break;


                case "Alta Agenda Profesional":
                  //?
                    break;


                case "Compra bonos":
                    new Compra_Bono.BusquedaAfiliado().ShowDialog();
                    break;


                case "Pedido turnos":
                  //?
                    //new Pedir_Turno.AltaTurno(
                    
                    new Pedir_Turno.AltaTurno(user_id).ShowDialog();
                   // GZC9D6
                    break;

                case "Cancerlar turnos":
                  //?
                    break;

                case "Registo de llegada":
                    new Registro_Llegada.RegistroDeLlegada().ShowDialog();
                    break;

                case "Registo de resultados":

                    //new Registro_Resultado.BusquedaResultado(user_id).ShowDialog();
                    new Registro_Resultado.BusquedaResultado(user_id).ShowDialog();
                    break;
                case "Listado Estadistico":
                    new Listados.ListadoEstadistico().ShowDialog();
                    break;
            
            
            
            
            }
        }
    }
}
