using Entidadez;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Medico> listaMedicos = AdmMedico.Listar();
            List<Paciente> listaPacientes = AdmPaciente.Listar();

            gridMedicos.DataSource = listaMedicos;
            gridPacientes.DataSource = listaPacientes;

            listClinicos.DataSource = AdmMedico.MedicosClinicos();
            listHabitaciones.DataSource = AdmHabitacion.HabitacionesEstado();
        }
    }
}
