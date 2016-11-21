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

        public AltaModificacionAfiliados()
        {
            InitializeComponent();
        }

        public AltaModificacionAfiliados(Accion accion)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.accion = accion;
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
            plan.Text = datos.Cells["Plan"].Value.ToString();
            familiaresacargo.Text = datos.Cells["Familiares a cargo"].Value.ToString();
            estadoCivil.Text = datos.Cells["Estado Civil"].Value.ToString();
            numeroAfiliado = datos.Cells["Numero de Afiliado"].Value.ToString();
            nombre.Enabled = false;
            apellido.Enabled = false;
            numerodocumento.Enabled = false;
            tipo.Enabled = false;
            sexo.Enabled = false;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AltaModificacionAfiliados_Load(object sender, EventArgs e)
        {

        }

        private void BotonGuardarRol_Click(object sender, EventArgs e)
        {
            if (accion == Accion.Modificacion) {

            DAO.DAOAfiliados.actualizarAfiliado(direccion.Text,telefono.Text,email.Text,estadoCivil.Text,familiaresacargo.Text,plan.Text, numeroAfiliado);
            }
            this.Close();
        }
    }
}
