using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class BusquedaAfiliado : Abm_Afiliado.ListadoAfiliados
    {
        public BusquedaAfiliado()
        {
            InitializeComponent();
            this.tablaAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAfiliados_CellContentClick_1);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tablaAfiliados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            new PantallaDosCompraBono(tablaAfiliados.Rows[e.RowIndex]).ShowDialog();

            //DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este afiliado?", MessageBoxButtons.YesNo);
            
        }
    }
}
