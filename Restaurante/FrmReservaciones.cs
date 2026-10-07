using System;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmReservaciones : Form
    {
        private ReservacionRepository repositorio = new ReservacionRepository();

        public FrmReservaciones()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            var clientes = repositorio.ListarClientes();
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdClient";
            cboCliente.SelectedIndex = -1;

            var mesas = repositorio.ListarMesas();
            cboMesa.DataSource = mesas;
            cboMesa.DisplayMember = "Numesa";
            cboMesa.ValueMember = "IdMesa";
            cboMesa.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex == -1 || cboMesa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente y una mesa.");
                return;
            }

            Reservacion reservacion = new Reservacion();
            reservacion.IdReserv = new Random().Next(1000, 999999);
            reservacion.IdClient = Convert.ToInt32(cboCliente.SelectedValue);
            reservacion.IdMesa = Convert.ToInt32(cboMesa.SelectedValue);
            reservacion.Fecha = dtpFecha.Value;
            reservacion.Hora = dtpHora.Value.TimeOfDay;
            reservacion.CantPers = (int)numCantPersonas.Value;

            try
            {
                repositorio.Guardar(reservacion);
                MessageBox.Show("Reservación guardada correctamente.");
                MostrarReservaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarReservaciones();
        }

        private void MostrarReservaciones()
        {
            dgvReservaciones.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboCliente.SelectedIndex = -1;
            cboMesa.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            numCantPersonas.Value = 1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

