using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class BusquedaResultado : Form
    {
        private int medicoId;

        public BusquedaResultado()
        {
            InitializeComponent();
        }

        public BusquedaResultado(int medicoId)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.medicoId = medicoId;
            horario.Format = DateTimePickerFormat.Custom;
            horario.CustomFormat = "dd/MM/yyyy";
            tablaTurnos.DataSource = DAO.DAOResultados.filtroAfiliados(medicoId);

            tablaTurnos.Columns["Id Paciente"].Visible = false; 
            tablaTurnos.Columns["Consulta_Medica_id"].Visible = false;
            AgregarBoton();
            this.tablaTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clicktabla);
         
        }

        private void BusquedaResultado_Load(object sender, EventArgs e)
        {

        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            horario.CustomFormat = "MM/dd/yyyy";
            tablaTurnos.DataSource = DAO.DAOResultados.filtroAfiliados(medicoId,numeroAfiliado.Text,horario.Text,numeroTurno.Text);
            horario.CustomFormat = "dd/MM/yyyy";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            numeroTurno.Text = "";
            numeroAfiliado.Text = "";
            horario.Value = DateTime.Now;

                
        }



        private void clicktabla(object sender, DataGridViewCellEventArgs e)
        {
        
           // int paciente = DAO.DAOTurnos.bonosDisponibles();

            new Registro_Resultado.RegistroDeResultado(tablaTurnos.Rows[e.RowIndex].Cells["Nombre Paciente"].Value.ToString(), tablaTurnos.Rows[e.RowIndex].Cells["Id Paciente"].Value.ToString(), tablaTurnos.Rows[e.RowIndex].Cells["Consulta_Medica_id"].Value.ToString()).ShowDialog();
            horario.CustomFormat = "MM/dd/yyyy";
            tablaTurnos.DataSource = DAO.DAOResultados.filtroAfiliados(medicoId, numeroAfiliado.Text, horario.Text, numeroTurno.Text);
            horario.CustomFormat = "dd/MM/yyyy";
        }




        public void AgregarBoton()
        {
            DataGridViewButtonColumn btnColum = new DataGridViewButtonColumn();
            btnColum.Name = "Seleccionar";
            btnColum.Text = "Seleccionar";
            btnColum.UseColumnTextForButtonValue = true;
            tablaTurnos.Columns.Insert(0, btnColum);

        }



    }
} 
