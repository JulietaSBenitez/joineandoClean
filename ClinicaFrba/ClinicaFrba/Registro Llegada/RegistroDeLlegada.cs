using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class RegistroDeLlegada : BusquedaTurno
    {
        public RegistroDeLlegada()
        {
            InitializeComponent();
            tablaTurnos.DataSource = DAO.DAOTurnos.filtroAfiliados();
            AgregarBoton();
            this.tablaTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clicktabla);
          
            //ACA PONER FECHA Y HORA DE LA PC


            //ARMAR FILTROS
            
            
          
        }
        private void clicktabla(object sender, DataGridViewCellEventArgs e){
            int cantidadBonos = DAO.DAOTurnos.bonosDisponibles(tablaTurnos.Rows[e.RowIndex].Cells["Numero Afiliado"].Value.ToString());

            if (cantidadBonos == 0)
            {
                DialogResult dialogResult = MessageBox.Show("ERROR: No posee bonos disponibles para efectuar la consulta medica", "Bonos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CREAR CONSULTA MEDICA
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Le quedan un total de: " + (cantidadBonos - 1).ToString() + " bonos disponibles para proximas consultas", "Bonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ((?)) pedirle a batman ayuda
            }
     
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
