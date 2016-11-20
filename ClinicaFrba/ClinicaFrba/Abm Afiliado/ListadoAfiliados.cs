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
    public partial class ListadoAfiliados : Form
    {
        DataTable datosAfiliados;
        private Accion accion;

        public ListadoAfiliados()
        {
            InitializeComponent();
        }

        public ListadoAfiliados(Accion accion)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.accion = accion;
            //tiposDeDocumentos

            tablaAfiliados.DataSource = DAO.DAOAfiliados.filtroAfiliados();
            tiposDeDocumentos.DataSource = DAO.DAOAfiliados.tiposDeDocumentos();
            tiposDeDocumentos.DisplayMember = "Tipo";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            tablaAfiliados.DataSource = DAO.DAOAfiliados.filtroAfiliados(nombre.Text,apellido.Text,tiposDeDocumentos.Text,numerodocumento.Text);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            numerodocumento.Text = "";
            apellido.Text = "";
            nombre.Text = "";
            tiposDeDocumentos.SelectedIndex = 0;
        }
    }
}
