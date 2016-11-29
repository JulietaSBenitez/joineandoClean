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
    public partial class ListadoAfiliadosBaja : ListadoAfiliados
    {
        public ListadoAfiliadosBaja()
        {
            InitializeComponent();
            this.tablaAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAfiliados_CellContentClick_1);
          
        }

        private void ListadoAfiliadosBaja_Load(object sender, EventArgs e)
        {

        }


        private void tablaAfiliados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


                DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este afiliado?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAO.DAOAfiliados.bajaAfiliado(tablaAfiliados.Rows[e.RowIndex].Cells["Numero de Afiliado"].Value.ToString(),Properties.Settings.Default.fecha);
                }

     
            this.Close();
        }

        private void tiposDeDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
