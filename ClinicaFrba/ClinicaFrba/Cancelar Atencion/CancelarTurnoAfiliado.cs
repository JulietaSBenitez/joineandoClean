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
using ClinicaFrba.DAO;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarTurnoAfiliado : Form
    {

        private List<ValidacionBooleana<CancelarTurnoAfiliado>> validaciones = new List<ValidacionBooleana<CancelarTurnoAfiliado>>();
        private bool ClickearonLimpiar;
        private DataRow FilaSeleccionada;

        int PersonaID;

        public CancelarTurnoAfiliado(int id_persona)
        {
            InitializeComponent();

            CalendarioTurnos.MaxSelectionCount = 1;
            CalendarioTurnos.TodayDate = Properties.Settings.Default.fecha;
            CalendarioTurnos.SelectionStart = CalendarioTurnos.TodayDate;

            List<Especialidad> especialidades = Especialidad.All();
            especialidades.Insert(0, new Especialidad("Todas", null));
            EspecialidadMedicaCB.DataSource = especialidades;
            EspecialidadMedicaCB.DisplayMember = "Nombre";

            PersonaID = id_persona;

            ColumnasDGV();
            AgregarBoton();

            validaciones.Add(new ValidacionBooleana<CancelarTurnoAfiliado>(
            (controlador => controlador.FaltaMasDeUnDiaParaElTurno()),
            "Lo sentimos, no puede cancelar turnos a los que les falten menos de un día."));

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
        private int? IDEspecialidad()
        {
            return ((Especialidad)EspecialidadMedicaCB.SelectedItem).ID;
        }

        private void Buscar()
        {

            SqlParameter nombre = new SqlParameter("@Nombre", NombreProfesional());
            SqlParameter apellido = new SqlParameter("@Apellido", ApellidoProfesional());
            SqlParameter dia = new SqlParameter("@Dia", Dia());
            SqlParameter idEspecialidad = new SqlParameter("@Especialidad_id", IDEspecialidad());
            SqlParameter idPersona = new SqlParameter("@Persona_id", PersonaID);
            List<DataRow> filas = QueryAdapterMaggie.ejecutarSP("PERSONATurnos", nombre, apellido, dia, idEspecialidad, idPersona);

            DataTable dataTable = new DataTable();

            foreach (DataRow fila in filas)
            {
                dataTable.ImportRow(fila);
            }

            ListadoDGV.DataSource = dataTable;


        }
        private void AgregarBoton()
        {
            DataGridViewButtonColumn btnColum = new DataGridViewButtonColumn();
            btnColum.Name = "Eliminar";
            btnColum.Text = "Eliminar";
            btnColum.UseColumnTextForButtonValue = true;
            ListadoDGV.Columns.Insert(5, btnColum);

        }
        private void ColumnasDGV()
        {

            ListadoDGV.AutoGenerateColumns = false;
            ListadoDGV.ColumnCount = 6;

            ListadoDGV.Columns[0].Name = "Nombre";
            ListadoDGV.Columns[0].HeaderText = "Nombre";
            ListadoDGV.Columns[0].DataPropertyName = "Nombre";

            ListadoDGV.Columns[1].Name = "Apellido";
            ListadoDGV.Columns[1].HeaderText = "Apellido";
            ListadoDGV.Columns[1].DataPropertyName = "Apellido";

            ListadoDGV.Columns[2].Name = "Especialidad";
            ListadoDGV.Columns[2].HeaderText = "Especialidad";
            ListadoDGV.Columns[2].DataPropertyName = "Especialidad";

            ListadoDGV.Columns[3].Name = "Dia";
            ListadoDGV.Columns[3].HeaderText = "Dia";
            ListadoDGV.Columns[3].DataPropertyName = "Dia";

            ListadoDGV.Columns[4].Name = "Horario";
            ListadoDGV.Columns[4].HeaderText = "Horario";
            ListadoDGV.Columns[4].DataPropertyName = "Horario";
        }

        private bool FaltaMasDeUnDiaParaElTurno() {

            DateTime dia = (DateTime) FilaSeleccionada["Dia"];
            DateTime horario = (DateTime)FilaSeleccionada["Horario"];

            DateTime turno = dia + new TimeSpan(horario.Hour, horario.Minute, 0);

            return turno.Subtract(Properties.Settings.Default.fecha).TotalHours > 24;
        
        }

        private void LimpiarDiaButton_Click(object sender, EventArgs e)
        {
            ClickearonLimpiar = true;
        }
        private void CalendarioTurnos_DateChanged(object sender, DateRangeEventArgs e)
        {
            ClickearonLimpiar = false;
        }
        private void ListadoDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (validaciones.All(validacion => validacion.SeCumple(this)))
            {

                this.Hide();
                Form cancelarTurno = new CancelarTurnoTipoRazon(PersonaID);
                cancelarTurno.ShowDialog();
            }
            else
            {
                ValidacionBooleana<CancelarTurnoAfiliado> validacionQueNoSeCumple =
                    validaciones.Find(validacion => validacion.NoSeCumple(this));
                MessageBox.Show(validacionQueNoSeCumple.MensajeError(), "¡A wild error appeared!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ListadoDGV_SelectionChanged(object sender, EventArgs e)
        {
            FilaSeleccionada = (DataRow) ListadoDGV.SelectedRows[0].DataBoundItem;
        }
    }
}
