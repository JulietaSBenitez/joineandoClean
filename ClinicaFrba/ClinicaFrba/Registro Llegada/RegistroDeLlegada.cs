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
            tablaTurnos.DataSource = DAO.DAOTurnos.filtroAfiliados(horario.Value);
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
                horario.CustomFormat = "MM/dd/yyyy hh:mm";
              //  medico.Text = horario.Text;
                DAO.DAOTurnos.confirmarPresencia(tablaTurnos.Rows[e.RowIndex].Cells["Numero de Turno"].Value.ToString(), tablaTurnos.Rows[e.RowIndex].Cells["Numero Afiliado"].Value.ToString(), horario.Value);
                horario.CustomFormat = "dd/MM/yyyy hh:mm";
                tablaTurnos.DataSource = DAO.DAOTurnos.filtroAfiliados(horario.Value, medico.Text, especialidad.Text, numeroTurno.Text, numeroAfiliado.Text);
       

            }
     
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btnfiltrar_Click_1(object sender, EventArgs e)
        {
            tablaTurnos.DataSource = DAO.DAOTurnos.filtroAfiliados(horario.Value,medico.Text,especialidad.Text,numeroTurno.Text,numeroAfiliado.Text);
        }
    }
}
