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

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoAfiliado : Form
    {

        String NombreProfesional;
        String ApellidoProfesional2;
        List<Especialidad> Especialidades = new List<Especialidad>();

        public CancelarTurnoAfiliado()
        {
            InitializeComponent();

            Especialidades = Especialidad.All();

            CalendarioTurnos.MaxSelectionCount = 1;
            CalendarioTurnos.TodayDate = Properties.Settings.Default.fecha;
            CalendarioTurnos.SelectionStart = CalendarioTurnos.TodayDate;

            NombreProfesionalTB.SelectedText = NombreProfesional;
            ApellidoProfesionalTB.SelectedText = ApellidoProfesional2;

            EspecialidadMedicaCB.DataSource = Especialidades;
            EspecialidadMedicaCB.DisplayMember = "Nombre";

        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            TurnosDisponibles.Columns.Clear();
        }

        private void EspecialidadCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
