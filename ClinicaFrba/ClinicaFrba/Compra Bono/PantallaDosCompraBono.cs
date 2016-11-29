using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class PantallaDosCompraBono : Form
    {
        string numeroAfiliado;
        public PantallaDosCompraBono(DataGridViewRow datos)
        {

            InitializeComponent();
            nombret.Text += datos.Cells["Nombre"].Value.ToString() + " " + datos.Cells["Apellido"].Value.ToString();
            numeroAfiliado = datos.Cells["Numero de Afiliado"].Value.ToString();
            numeroafiliadot.Text += numeroAfiliado;

            preciobono.Text = DAO.DAOBonos.precioBono(datos.Cells["Plan"].Value.ToString());
            
        }

        private void PantallaDosCompraBono_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int a;
            if (int.TryParse(cantidad.Text, out a))
            {
    preciofinal.Text = (Convert.ToInt32(preciobono.Text) * a).ToString();

            }

            
          
                  }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO.DAOBonos.compraBono(numeroAfiliado, cantidad.Text, Properties.Settings.Default.fecha);
        }
    }
}
