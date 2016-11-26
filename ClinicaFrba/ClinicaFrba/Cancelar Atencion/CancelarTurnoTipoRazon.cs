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
using ClinicaFrba.DAO;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoTipoRazon : Form
    {

        Action<int, string> AccionAEjecutar;
        private List<ValidacionBooleana<CancelarTurnoTipoRazon>> validaciones = new List<ValidacionBooleana<CancelarTurnoTipoRazon>>();

        public CancelarTurnoTipoRazon(Action<int, string> accion)
        {
            InitializeComponent();

            TipoCancelacionCB.DataSource = TiposDeCancelacion();
            TipoCancelacionCB.DisplayMember = "Descripcion";

            AccionAEjecutar = accion;

            validaciones.Add(new ValidacionBooleana<CancelarTurnoTipoRazon>(
            (controlador => controlador.TipoDeCancelacionSeleccionada()),
            "Seleccione un tipo de cancelación."));

            validaciones.Add(new ValidacionBooleana<CancelarTurnoTipoRazon>(
            (controlador => controlador.ExisteRazonCancelación()),
            "No se ha especificado una razón para cancelar el turno."));
        }

        private DataTable TiposDeCancelacion()
        {
            return QueryAdapterMaggie.ejecutarSP("TIPOCANCELACIONTodos").CopyToDataTable();
            
        }
        private bool ExisteRazonCancelación() { 
        
            return RazonCancelacionTB.TextLength > 0;
        }
        private bool TipoDeCancelacionSeleccionada() {

            return TipoCancelacionCB.SelectedItem != null;
        }
        private void VolverBoton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
        private void CancelarTurnoBoton_Click(object sender, EventArgs e)
        {
            if (validaciones.All(validacion => validacion.SeCumple(this)))
            {
                AccionAEjecutar(IDTipoDeCancelacion(),MotivoCancelacion());
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ValidacionBooleana<CancelarTurnoTipoRazon> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private int IDTipoDeCancelacion() {

            return (int) ((DataRow) TipoCancelacionCB.SelectedItem)["Tipo_Cancelacion_Id"];
        
        }
        private string MotivoCancelacion()
        {
            return RazonCancelacionTB.Text;
        }

    }
}
