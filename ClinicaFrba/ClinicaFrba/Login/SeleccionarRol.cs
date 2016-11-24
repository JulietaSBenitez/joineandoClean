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
        DataTable roles;
        public SeleccionarRol()
        {
            InitializeComponent();
        }

        public SeleccionarRol(int userId)
        {
            InitializeComponent();
            roles = DAO.DAOLogin.roles_x_usuario(userId);

            foreach (DataRow row in roles.Rows)
            {

                comboBox1.Items.Add(row["Nombre"].ToString());
                comboBox1.SelectedIndex = 0;
                    
                 
            }
            if (comboBox1.Items.Count == 1) {
                DataRow[] row = roles.Select("Nombre='" + comboBox1.Text + "'");
                new Acciones(int.Parse(row[0]["Rol_id"].ToString())).ShowDialog();
                this.Hide();
            
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow[] row = roles.Select("Nombre='" + comboBox1.Text + "'");
            new Acciones(int.Parse(row[0]["Rol_id"].ToString())).ShowDialog();
            this.Hide();
        }
    }
}
