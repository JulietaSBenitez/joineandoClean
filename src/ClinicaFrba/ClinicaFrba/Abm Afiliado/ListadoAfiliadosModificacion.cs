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
    public partial class ListadoAfiliadosModificacion : ListadoAfiliados
    {
        public ListadoAfiliadosModificacion()
        {
            InitializeComponent();
            this.tablaAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAfiliados_CellContentClick_1);
          
        }

        private void ListadoAfiliadosModificacion_Load(object sender, EventArgs e)
        {

        }
        private void tablaAfiliados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        
                new AltaModificacionAfiliados(Accion.Modificacion, tablaAfiliados.Rows[e.RowIndex]).ShowDialog();

            
            this.Close();
        }
    }
}
