using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    class Funcionalidad
    {

        public Form formDeFuncionalidad;
        public String descripcion;
        public int id;

        public override String ToString()
        {
            return descripcion;
        }

        public Funcionalidad(Form form, String desc, int id)
        {
            this.formDeFuncionalidad = form;
            this.descripcion = desc;
            this.id = id;
        }

        internal void Show()
        {
            formDeFuncionalidad.ShowDialog();
        }
    }
}
