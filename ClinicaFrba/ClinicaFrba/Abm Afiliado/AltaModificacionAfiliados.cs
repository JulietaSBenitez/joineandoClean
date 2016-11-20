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
            fechanac.Value = DateTime.Parse( datos.Cells["Fecha Nacimiento"].Value.ToString());
            tipo.Text = datos.Cells["Tipo"].Value.ToString();
            numerodocumento.Text = datos.Cells["Numero_documento"].Value.ToString();
            telefono.Text = datos.Cells["Telefono"].Value.ToString();
            email.Text= datos.Cells["email"].Value.ToString();
            direccion.Text = datos.Cells["Direccion"].Value.ToString();
            sexo.Text = datos.Cells["Sexo"].Value.ToString();
            plan.Text = datos.Cells["Plan"].Value.ToString();
            familiaresacargo.Text = datos.Cells["Familiares a cargo"].Value.ToString();
            estadoCivil.Text = datos.Cells["Estado Civil"].Value.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AltaModificacionAfiliados_Load(object sender, EventArgs e)
        {

        }
    }
}
