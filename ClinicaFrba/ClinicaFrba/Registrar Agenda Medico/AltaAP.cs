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

namespace ClinicaFrba.RegistrarAgendaMedico
{
    public partial class AltaAP : Form
    {

        public AltaAP(Medico medico)
        {
            InitializeComponent();
            comboBox1.DataSource = medico.EspecialidadesSinAgenda();
            comboBox1.DisplayMember = "Nombre";
            List<ComboBox> comboBoxListInicio = new List<ComboBox>();
            List<ComboBox> comboBoxListFin = new List<ComboBox>();
            comboBoxListInicio.Add(comboBoxInicioLunes);
            comboBoxListInicio.Add(comboBoxInicioMartes);
            comboBoxListInicio.Add(comboBoxInicioMiercoles);
            comboBoxListInicio.Add(comboBoxInicioJueves);
            comboBoxListInicio.Add(comboBoxInicioViernes);
            comboBoxListFin.Add(comboBoxFinLunes);
            comboBoxListFin.Add(comboBoxFinMartes);
            comboBoxListFin.Add(comboBoxFinMiercoles);
            comboBoxListFin.Add(comboBoxFinJueves);
            comboBoxListFin.Add(comboBoxFinViernes);

        }


        private void CargarComboBoxRangoInicio(ComboBox comboBox, int horaInicio, int horaFin)
        {
            DateTime time;
            for ( int i = horaInicio; i <= horaFin; i++ )
            {
                time = new DateTime(1, 1, 1, i, 0, 0, 0);
                comboBox.Items.Add(time.ToString("HH:mm"));
                time = new DateTime(1, 1, 1, i, 30, 0, 0);
                comboBox.Items.Add(time.ToString("HH:mm"));
   
            }
        }

        private void CargarComboBoxRangoFin(ComboBox comboBox, int horaInicio, int horaFin)
        {
            DateTime time;
            for (int i = horaInicio; i <= horaFin; i++)
            {
                time = new DateTime(1, 1, 1, i, 30, 0, 0);
                comboBox.Items.Add(time.ToString("HH:mm"));
                time = new DateTime(1, 1, 1, i + 1, 0, 0, 0);
                comboBox.Items.Add(time.ToString("HH:mm"));

            }
        }

        private void CargarTodosLosComboBoxInicio( ) {

            // Acá quiero hacer algo asi: 
            //comboBoxListInicio.forEach[unComboBox | CargarComboBoxRangoInicio(unComboBox, 7, 20)]

            CargarComboBoxRangoFin(comboBoxInicioSabado, 10, 15);

            comboBoxInicioLunes.Enabled = false;
            comboBoxInicioMartes.Enabled = false;
            comboBoxInicioMiercoles.Enabled = false;
            comboBoxInicioJueves.Enabled = false;
            comboBoxInicioViernes.Enabled = false;
            comboBoxInicioSabado.Enabled = false;
        }

        private void CargarTodosLosComboBoxFin(){

            // Acá quiero hacer algo asi: 
            //comboBoxListFin.forEach[unComboBox | unComboBox.CargarComboBoxRangoFin(unComboBox, 7, 20)]

            CargarComboBoxRangoFin(comboBoxFinSabado, 10, 15);
            
            comboBoxFinLunes.Enabled = false;
            comboBoxFinMartes.Enabled = false;
            comboBoxFinMiercoles.Enabled = false;
            comboBoxFinJueves.Enabled = false;
            comboBoxFinViernes.Enabled = false;
            comboBoxFinSabado.Enabled = false;
        }

        private void botonVolverAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LunesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LunesAgendaCB.Checked == true)
            {
                comboBoxInicioLunes.Enabled = true;
                comboBoxFinLunes.Enabled = true;
            }
        }

        private void MartesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {

            if (MartesAgendaCB.Checked == true)
            {
                comboBoxInicioMartes.Enabled = true;
                comboBoxFinMartes.Enabled = true;
            }

        }

        private void MiercolesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (MiercolesAgendaCB.Checked == true)
            {
                comboBoxInicioMiercoles.Enabled = true;
                comboBoxFinMiercoles.Enabled = true;
            }
        }

        private void JuevesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (JuevesAgendaCB.Checked == true)
            {
                comboBoxInicioJueves.Enabled = true;
                comboBoxFinJueves.Enabled = true;
            }
        }

        private void ViernesAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ViernesAgendaCB.Checked == true)
            {
                comboBoxInicioViernes.Enabled = true;
                comboBoxFinViernes.Enabled = true;
            }
        }

        private void SabadoAgendaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SabadoAgendaCB.Checked == true)
            {
                comboBoxInicioSabado.Enabled = true;
                comboBoxFinSabado.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validarQueNoExistanOtrasAgendasEnEseHorario.
            //ValidarQueNoSeTrabajeMasDe48HorasSemanales.
        }



        }

        }
