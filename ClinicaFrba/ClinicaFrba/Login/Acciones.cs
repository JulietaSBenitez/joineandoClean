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
        DataTable funcionabilidades;
        public Acciones()
        {
            InitializeComponent();
        }

        public Acciones(int rol_id )
        {
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
                case "Crear Rol":
                    new AbmRol.AltaModificacionRol(Accion.Alta).ShowDialog();
                    break;


            
            
            
            
            }
        }
    }
}
