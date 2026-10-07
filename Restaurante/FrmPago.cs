using System;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmPago : Form
    {
        private FormaPagoRepository repositorio = new FormaPagoRepository();

        public FrmPago()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la forma de pago.");
                return;
            }

            FormaPago formaPago = new FormaPago();
            formaPago.IdFormPago = "FP" + new Random().Next(100, 999);
            formaPago.Nombre = txtNombre.Text;
            formaPago.Descrip = txtDescripcion.Text;

            try
            {
                repositorio.Guardar(formaPago);
                MessageBox.Show("Forma de pago guardada correctamente.");
                MostrarFormaPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarFormaPago();
        }

        private void MostrarFormaPago()
        {
            dgvFormaPago.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


