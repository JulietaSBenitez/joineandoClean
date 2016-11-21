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
    public partial class HistorialCambiosPlan : Form
    {
        public HistorialCambiosPlan()
        {
            InitializeComponent();
        }

        public HistorialCambiosPlan(string numero_afiliado)
        {
            InitializeComponent();
           tablahistorial.DataSource= DAO.DAOAfiliados.listarCambios(numero_afiliado);
        }

        private void HistorialCambiosPlan_Load(object sender, EventArgs e)
        {

        }

        private void tablahistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
