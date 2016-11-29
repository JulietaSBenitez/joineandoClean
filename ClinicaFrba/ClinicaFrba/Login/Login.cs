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

            resultado  = DAO.DAOLogin.login(usuario.Text, pass.Text);
            MessageBox.Show(resultado.ToString(), "Registro de resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (resultado > 0)
            {
               // this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario.Text = "admin";
            pass.Text = "w23e";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //paciente 10028 PAMPA(nombre) Garrido
            //v[Medico_Nombre]+'.'+[Medico_Apellido]
            //123456
            usuario.Text = "AARON.Sánchez";
            pass.Text = "123456";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuario.Text = "ABDO.Ortega";
            pass.Text = "123456";
        }
    }
}
