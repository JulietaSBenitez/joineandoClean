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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;

            resultado  = DAO.DAOLogin.login(textBox1.Text, textBox2.Text);

            if (resultado > 0)
            {
                this.Hide();
                new SeleccionarRol(resultado).ShowDialog();
            }

            if (resultado == 0)
            {
                MessageBox.Show("Usuario o contrasena invalida", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            }

            if (resultado == -1)
            {
                MessageBox.Show("Usuario Bloqueado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

           
        }
    }
}
