using System;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmMesas : Form
    {
        private MesaRepository repositorio = new MesaRepository();

        public FrmMesas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Ingrese el número de mesa.");
                return;
            }

            Mesa mesa = new Mesa();
            mesa.IdMesa = new Random().Next(1000, 999999);
            mesa.Numesa = txtNumero.Text;
            mesa.Capacidad = txtCapacidad.Text;
            mesa.Estado = txtEstado.Text;

            try
            {
                repositorio.Guardar(mesa);
                MessageBox.Show("Mesa guardada correctamente.");
                MostrarMesas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarMesas();
        }

        private void MostrarMesas()
        {
            dgvMesas.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtCapacidad.Clear();
            txtEstado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


