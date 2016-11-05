using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class AltaModificacionRol : Form
      
    {
        DataTable funcionalidades;
        DataTable funcionabilidadesHabilitadas;
        DataTable rol;
        Accion accion;
       
        int id;
        private List<Funcionalidad> list;

        public AltaModificacionRol(Accion accionparametro)
        {
            InitializeComponent();
            label4.Text = "Alta Rol";
            volcarFuncionabilidades();
            accion = accionparametro;
        }

        public AltaModificacionRol(Accion accionparametro,String p)
        {

            InitializeComponent();

            accion = accionparametro;
            // TODO: Complete member inialization
            int.TryParse(p, out id);
           // MessageBox.Show(p);
            label4.Text = "Modificacion Rol";
           

            rol = DAO.DAORoles.propiedadesRol(id);
            textBox1.Text = rol.Rows[0]["Nombre"].ToString();


            if (rol.Rows[0]["habilitado"].ToString()=="True")
            {
                habilitado.SelectedIndex = 0;
            }
            else
            {
                habilitado.SelectedIndex = 1;
            }

            volcarFuncionabilidades();

            funcionabilidadesHabilitadas = DAO.DAORoles.funcionabilidadesHabilitadasXRol(id);
            foreach (DataRow row in funcionabilidadesHabilitadas.Rows)
            {
                //ACA FUNCA MAL

                checkedListFuncionalidad.SetItemChecked(checkedListFuncionalidad.FindStringExact(row["Nombre"].ToString()), true);
              //  checkedListFuncionalidad.SetItemChecked(, true);
            }




        }

        private void volcarFuncionabilidades() {

            funcionalidades = DAO.DAORoles.listarFuncionalidades();
            foreach (DataRow row in funcionalidades.Rows)
            {
                checkedListFuncionalidad.Items.Add(row["Nombre"].ToString());
            }
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void ModificarRol_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        
        private void BotonLimpiarRoles_Click(object sender, EventArgs e)
        {
            habilitado.SelectedItem = 0;
            checkedListFuncionalidad.Items.Clear();
            textBox1.Text="";

        }

  

        private void BotonGuardarRol_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || habilitado.Text == "")
            {
                MessageBox.Show("Complete todos los campos");

                return;
            }

            Dictionary<int, Boolean> funciones = new Dictionary<int, bool>();
            foreach (String key in checkedListFuncionalidad.Items)
            {
                DataRow[] row = funcionalidades.Select("Nombre = '" + key + "'");
                funciones.Add(int.Parse(row[0]["Funcionabilidad_id"].ToString()), checkedListFuncionalidad.GetItemChecked(checkedListFuncionalidad.FindStringExact(key)));
            }


            if (accion == Accion.Modificacion)
            {
                DAO.DAORoles.actualizarRol(id, textBox1.Text, habilitado.SelectedItem.ToString() == "Habilitado" ? false : true, funciones);
            }
            if (accion == Accion.Alta)
            {
                DAO.DAORoles.altaRol(textBox1.Text, habilitado.SelectedItem.ToString() == "Habilitado" ? false : true, funciones);
    
            }
            this.Close();
        }


    }

}
