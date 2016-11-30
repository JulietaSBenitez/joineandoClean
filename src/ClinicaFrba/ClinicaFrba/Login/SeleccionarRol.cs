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
    public partial class SeleccionarRol : Form
    {
        int user_id;
        DataTable roles;
        public SeleccionarRol()
        {
            InitializeComponent();
        }

        public SeleccionarRol(int userId)
        {
            user_id = userId;
            InitializeComponent();
            roles = DAO.DAOLogin.roles_x_usuario(userId);

            foreach (DataRow row in roles.Rows)
            {

                comboBox1.Items.Add(row["Nombre"].ToString());
                comboBox1.SelectedIndex = 0;
                    
                 
            }
     

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarRol_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 1)
            {
                DataRow[] row = roles.Select("Nombre='" + comboBox1.Text + "'");
                //  this.Hide();
               var a = new Acciones(int.Parse(row[0]["Rol_id"].ToString()), user_id).ShowDialog();


                      this.Close();

            }
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Usted no posee un rol asignado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
       

                this.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow[] row = roles.Select("Nombre='" + comboBox1.Text + "'");
            new Acciones(int.Parse(row[0]["Rol_id"].ToString()),user_id).ShowDialog();
         //   this.Hide();
        //    this.Close();
        }
    }
}
