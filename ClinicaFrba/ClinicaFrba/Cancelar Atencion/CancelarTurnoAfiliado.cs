using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using ClinicaFrba.src;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoAfiliado : Form
    {

        private bool ClickearonLimpiar = true;

        public CancelarTurnoAfiliado()
        {
            InitializeComponent();

            CalendarioTurnos.MaxSelectionCount = 1;
            CalendarioTurnos.TodayDate = Properties.Settings.Default.fecha;
            CalendarioTurnos.SelectionStart = CalendarioTurnos.TodayDate;

            List<Especialidad> especialidades = Especialidad.All();
            especialidades.Insert(0, new Especialidad("Todas", null));
            EspecialidadMedicaCB.DataSource = especialidades;
            EspecialidadMedicaCB.DisplayMember = "Nombre";

        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            Buscar();

        }
        private void EspecialidadCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string NombreProfesional()
        {

            return NombreProfesionalTB.SelectedText.NullIfEmpty();
        }
        private string ApellidoProfesional()
        {

            return ApellidoProfesionalTB.SelectedText.NullIfEmpty();
        }
        private DateTime? Dia()
        {

            if (ClickearonLimpiar)
            {

                return null;

            }
            else
            {

                return CalendarioTurnos.SelectionStart;
            }

        }

        private void LimpiarDiaButton_Click(object sender, EventArgs e)
        {
            ClickearonLimpiar = true;
        }

        private void CalendarioTurnos_DateChanged(object sender, DateRangeEventArgs e)
        {
            ClickearonLimpiar = false;
        }

        private void Buscar() { 
        }


    }
}
