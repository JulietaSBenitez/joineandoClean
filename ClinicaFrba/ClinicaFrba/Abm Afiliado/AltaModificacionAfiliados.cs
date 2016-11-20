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

        public AltaModificacionAfiliados()
        {
            InitializeComponent();
        }

        public AltaModificacionAfiliados(Accion accion)
        {
            // TODO: Complete member initialization
            this.accion = accion;
        }
    }
}
