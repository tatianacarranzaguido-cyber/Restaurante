using System;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmClientes : Form
    {
        private ClienteRepository repositorio = new ClienteRepository();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return;
            }

            Cliente cliente = new Cliente();
            cliente.IdClient = new Random().Next(1000, 999999);
            cliente.Nombre = txtNombre.Text;
            cliente.Telf = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;

            try
            {
                repositorio.Guardar(cliente);
                MessageBox.Show("Cliente guardado correctamente.");
                MostrarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dgvClientes.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}