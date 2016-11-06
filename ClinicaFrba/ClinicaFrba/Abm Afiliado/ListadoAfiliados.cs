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
    public partial class ListadoRoles : Form
    {
        DataTable funcionalidades;

        Accion accion;

        public ListadoRoles()
        {
            InitializeComponent();
        }

        public ListadoRoles(Accion accionParametro)
        {
            InitializeComponent();
            CargarTabla();
            CargarFiltros();
            AgregarBoton();
            accion = accionParametro;

        }
        public void CargarFiltros() {


            funcionalidades = DAO.DAORoles.listarFuncionalidades();
            foreach (DataRow row in funcionalidades.Rows)
            {
                comboBox1.Items.Add(row["Nombre"].ToString());
            }
        
        }

        public void CargarTabla()
        {
            tablaRoles.DataSource = DAO.DAORoles.listarRoles();
        }
        private void ListadoRoles_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarBoton()
        {
            DataGridViewButtonColumn btnColum = new DataGridViewButtonColumn();
            btnColum.Name = "Seleccionar";
            btnColum.Text = "Seleccionar";
            btnColum.UseColumnTextForButtonValue = true;
            tablaRoles.Columns.Insert(3, btnColum);
       
        }



        private void tablaRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (Accion.Baja == accion)
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere inhabilitar este rol?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAO.DAORoles.inHabilitarRol(int.Parse(tablaRoles.Rows[e.RowIndex].Cells[1].Value.ToString()));
                }
          
            }
            if (Accion.Modificacion == accion){
                new AltaModificacionRol(Accion.Modificacion,tablaRoles.Rows[e.RowIndex].Cells[1].Value.ToString()).ShowDialog();
           
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            tablaRoles.DataSource = null;
            comboBox1.Text = "";
            comboBox2.Text="";

        
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            DataRow[] row = funcionalidades.Select("Nombre='"+comboBox1.Text+"'");
            tablaRoles.Columns.Clear();
            tablaRoles.DataSource = DAO.DAORoles.filtro(row.Count() > 0 ? int.Parse(row[0]["Funcionabilidad_id"].ToString()) : -1, comboBox2.Text);
            AgregarBoton();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
