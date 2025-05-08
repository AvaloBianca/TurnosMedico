using System;
using Clases;
using TurnosMedico;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace TurnosMedico
{
    public partial class FormTurnos : Form
    {
        public FormTurnos()
        {
            InitializeComponent();
            LimpiaTxt();
            CargarCombos();
        }

        public void CargarCombos()
        {
            

            cbxdias.Items.Add("LUNES");
            cbxdias.Items.Add("MARTES");
            cbxdias.Items.Add("MIERCOLES");
            cbxdias.Items.Add("JUEVES");
            cbxdias.Items.Add("VIERNES");

            cbxturno.Items.Add("MAÑANA");
            cbxturno.Items.Add("TARDE");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LimpiaTxt()
        {
            txtnombre.Text = " ";
            txtcelular.Text = " ";
            txtapellido.Text = " ";
            txtnombre.Focus();

        }
        private void btagendar_Click(object sender, EventArgs e)
        {
            bool agendar = true;

            string dia = cbxdias.SelectedItem.ToString();
            string turno = cbxturno.SelectedItem.ToString();
            string horario = cbxhorarios.SelectedItem.ToString();

            while (agendar)
            {

                if (dia != null && turno != null && horario != null)
                {
                    string mensaje = "SU TURNO QUEDO AGENDADO";
                    MessageBox.Show(mensaje);
                    agendar = false;

                }

            }

            cbxdias.Text = "";
            cbxhorarios.Text = "";
            cbxturno.Text = "";

            Pacientes nuevoTurno = new Pacientes(txtnombre.Text, dia, horario);
            Listado Listado = new Listado(txtnombre.Text, txtapellido.Text, txtcelular.Text);
            Listados.Insert(Listado);
        }
        private void cbxturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turnoSeleccionado = cbxturno.SelectedItem.ToString();

            if (turnoSeleccionado == "MAÑANA")
            {
                cbxhorarios.Items.Add("08:00 hs");
                cbxhorarios.Items.Add("09:00 hs");
                cbxhorarios.Items.Add("10:00 hs");

            }
            else if (turnoSeleccionado == "TARDE")
            {
                cbxhorarios.Items.Add("17:00 hs");
                cbxhorarios.Items.Add("18:00 hs");
                cbxhorarios.Items.Add("19:00 hs");
                cbxhorarios.Items.Add("20:00 hs");

            }
        }

        private void btverlista_Click(object sender, EventArgs e)
        {
            Pacientes Pacientes = new Pacientes(txtnombre.Text, txtapellido.Text, txtcelular.Text);
            Pacientes.Insert(Pacientes);

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {

            DGV.Rows.Remove(DGV.CurrentRow);

        }
    }
}
