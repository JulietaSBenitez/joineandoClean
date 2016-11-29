using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            semestre.SelectedIndex = 0;
            especialidad.DataSource = DAO.DAOListado.especialidades();
            especialidad.ValueMember = "Nombre_Especialidad";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            /*
             * 
             * 
             *




             * 
            */
            if (IsNumeric(ano.Text) == false)
            {
                MessageBox.Show("Ingrese un ano valido", "Listado Estadistico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int anio = int.Parse(ano.Text);
            int ssemestre=2;
            if(semestre.Text=="Primero") ssemestre=1;

            switch (Acciones.Text) { 
         
                case "":
                    MessageBox.Show("Seleccione un listado estadistico","Listado Estadistico",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
     
                    break;
                case "Top 5 de las especialidades con mas cancelaciones":
                  TablaListado.DataSource=  DAO.DAOListado.ListadoEspecialidadesConMasCancelaciones( anio, ssemestre );
                break;

                case "Top 5 de los profesionales más consultados por Plan":

                TablaListado.DataSource = DAO.DAOListado.ListadoProfesionalesMasConsultadosPorPlan(anio, ssemestre);
                   
                break;

                case "Top 5 de los profesionales con menos horas trabajadas":
                     TablaListado.DataSource=  DAO.DAOListado.ListadoProfesionalesConMenosHorasTrabajadas( anio, ssemestre );
                    
                break;

                case "Top 5 de los afiliados con mayor cantidad de bonos comprados":

                TablaListado.DataSource = DAO.DAOListado.ListadoAfiliadosConMayorBonosComprados(anio, ssemestre);
                   
                break;

                case "Top 5 de las especialidades con más bonos utilizados":
                TablaListado.DataSource = DAO.DAOListado.ListadoEspecialidadesConMasBonosUtilizados(anio, ssemestre);
                   
                    
                break;

            }
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void ListadoEstadistico_Load_1(object sender, EventArgs e)
        {

        }
    }
}
