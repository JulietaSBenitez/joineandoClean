using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClinicaFrba.src;
using ClinicaFrba;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoTipoRazon : Form
    {

        int PersonaID;
        private List<ValidacionBooleana<CancelarTurnoTipoRazon>> validaciones = new List<ValidacionBooleana<CancelarTurnoTipoRazon>>();

        public CancelarTurnoTipoRazon(int id_persona)
        {
            InitializeComponent();

            PersonaID = id_persona;

            validaciones.Add(new ValidacionBooleana<CancelarTurnoTipoRazon>(
            (controlador => controlador.TipoDeCancelacionSeleccionada()),
            "Seleccione un tipo de cancelación."));

            validaciones.Add(new ValidacionBooleana<CancelarTurnoTipoRazon>(
            (controlador => controlador.ExisteRazonCancelación()),
            "No se ha especificado una razón para cancelar el turno."));
        }

        private bool ExisteRazonCancelación() { 
        
            return RazonCancelacionTB.TextLength > 0;
        }
        private bool TipoDeCancelacionSeleccionada() {

            return TipoCancelacionCB.SelectedItem != null;
        }

        private void VolverBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CancelarTurnoBoton_Click(object sender, EventArgs e)
        {
            if (validaciones.All(validacion => validacion.SeCumple(this)))
            {
                //Está todo ok. Acá tengo que cargar una nueva agenda.
            }
            else
            {
                ValidacionBooleana<CancelarTurnoTipoRazon> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
