using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaModificacionAfiliados : Form
    {
        private Accion accion;
        private DataGridViewRow dataGridViewRow;
        private string numeroAfiliado;
        private int raiz;
        private int sub;
        private string plann;
        public AltaModificacionAfiliados()
        {
            InitializeComponent();
        }

        public AltaModificacionAfiliados(Accion accion)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.accion = accion;
            sexo.DataSource = DAO.DAOAfiliados.tiposDeSexo();
            sexo.DisplayMember = "Descripcion";
            tipo.DataSource = DAO.DAOAfiliados.tiposDeDocumentos();
            tipo.DisplayMember = "Tipo";
            plan.DataSource = DAO.DAOAfiliados.tiposDePlanes();
            plan.DisplayMember = "Nombre"; 
            botonHistorial.Enabled = false;


        }

        public AltaModificacionAfiliados(Accion accion, DataGridViewRow datos)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.accion = accion;
            this.dataGridViewRow = datos;
            sexo.DataSource = DAO.DAOAfiliados.tiposDeSexo();
            sexo.DisplayMember = "Descripcion";
            tipo.DataSource = DAO.DAOAfiliados.tiposDeDocumentos();
            tipo.DisplayMember = "Tipo";
            plan.DataSource = DAO.DAOAfiliados.tiposDePlanes();
            plan.DisplayMember = "Nombre";

            nombre.Text = datos.Cells["Nombre"].Value.ToString();
            apellido.Text = datos.Cells["Apellido"].Value.ToString();
            fechanac.Value = DateTime.ParseExact(datos.Cells["Fecha Nacimiento"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            tipo.Text = datos.Cells["Tipo"].Value.ToString();
            numerodocumento.Text = datos.Cells["Numero_documento"].Value.ToString();
            telefono.Text = datos.Cells["Telefono"].Value.ToString();
            email.Text= datos.Cells["email"].Value.ToString();
            direccion.Text = datos.Cells["Direccion"].Value.ToString();
            sexo.Text = datos.Cells["Sexo"].Value.ToString();
            plann = datos.Cells["Plan"].Value.ToString();
            plan.Text = plann;
            familiaresacargo.Text = datos.Cells["Familiares a cargo"].Value.ToString();
            estadoCivil.Text = datos.Cells["Estado Civil"].Value.ToString();
            numeroAfiliado = datos.Cells["Numero de Afiliado"].Value.ToString();
            nombre.Enabled = false;
            apellido.Enabled = false;
            numerodocumento.Enabled = false;
            tipo.Enabled = false;
            sexo.Enabled = false;
            
        }

        public AltaModificacionAfiliados(Accion accion, int raiz, int sub)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.accion = accion;
            this.raiz = raiz;
            this.sub = sub;
            this.accion = accion;
            sexo.DataSource = DAO.DAOAfiliados.tiposDeSexo();
            sexo.DisplayMember = "Descripcion";
            tipo.DataSource = DAO.DAOAfiliados.tiposDeDocumentos();
            tipo.DisplayMember = "Tipo";
            plan.DataSource = DAO.DAOAfiliados.tiposDePlanes();
            plan.DisplayMember = "Nombre";
            familiaresacargo.Text = "0";
            familiaresacargo.Enabled = false;
            botonHistorial.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AltaModificacionAfiliados_Load(object sender, EventArgs e)
        {

        }

        private void BotonGuardarRol_Click(object sender, EventArgs e)
        {

            if (numerodocumento.Text == "" || !IsNumeric(numerodocumento.Text))
            {
                MessageBox.Show("No puede dejar el campo Nuemero documento en blanco o con caracteres que no sean numericos", "Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (direccion.Text == "")
            {
                MessageBox.Show("No puede dejar el campo direccion en blanco", "Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nombre.Text == "")
            {
                MessageBox.Show("No puede dejar el campo nombre en blanco", "Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (apellido.Text == "")
            {
                MessageBox.Show("No puede dejar el campo apellido en blanco", "Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (accion == Accion.Modificacion) {

                DAO.DAOAfiliados.actualizarAfiliado(Properties.Settings.Default.fecha,direccion.Text, telefono.Text, email.Text, estadoCivil.Text, familiaresacargo.Text, plan.Text, numeroAfiliado, razon.Text);
            }
            if (accion == Accion.Alta)
            {
                int numeroAfiliado = DAO.DAOAfiliados.crearAfiliado(Properties.Settings.Default.fecha,nombre.Text, apellido.Text, tipo.Text, numerodocumento.Text, direccion.Text, sexo.Text, telefono.Text, email.Text, fechanac.Text, estadoCivil.Text, familiaresacargo.Text, plan.Text);


                //Ver que pregunte solo si es casado o bla
                DialogResult dialogResult = MessageBox.Show("Desea asociar a su conyugue?", "Pregunta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new Abm_Afiliado.AltaModificacionAfiliados(Accion.AltaMin,numeroAfiliado-1,2).ShowDialog();
                }

                //Ver que pregunte solo si es casado o bla
                DialogResult dialogResult2 = MessageBox.Show("Desea asociar a sus familiares a cargo?", "Pregunta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {int i;
                   for(i=0;i<int.Parse(familiaresacargo.Text);i++){
                       new Abm_Afiliado.AltaModificacionAfiliados(Accion.AltaMin, numeroAfiliado - 1, 3 + i).ShowDialog();
                   }
                }

            }
            if (accion == Accion.AltaMin)
            {
                int numeroAfiliado = DAO.DAOAfiliados.crearAfiliado(Properties.Settings.Default.fecha,nombre.Text, apellido.Text, tipo.Text, numerodocumento.Text, direccion.Text, sexo.Text, telefono.Text, email.Text, fechanac.Text, estadoCivil.Text, familiaresacargo.Text, plan.Text,raiz,sub);

            }
            this.Close();
        }

        private void BotonLimpiarRoles_Click(object sender, EventArgs e)
        {
            if (accion != Accion.Modificacion) {
                nombre.Text = "";
                apellido.Text = "";
                tipo.SelectedIndex = 0;
                sexo.SelectedIndex = 2;
                numerodocumento.Text = "";
                fechanac.Text = "";      
            }
            direccion.Text = "";
            telefono.Text = "";
            estadoCivil.SelectedIndex = 0;
            familiaresacargo.Text = "";
            plan.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            new HistorialCambiosPlan(numeroAfiliado).ShowDialog();
        }

        private void plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accion == Accion.Modificacion && plan.Text != plann)
            {
                razon.Visible = true; razont.Visible = true;
            }
            else { razon.Visible = false; razont.Visible = false; }
        }

        private void numerodocumento_TextChanged(object sender, EventArgs e)
        {

        }




        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    
    
    }
}
