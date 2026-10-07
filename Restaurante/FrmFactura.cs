using Restaurante.Data;
using Restaurante.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class FrmFactura : Form
    {
        private FacturaRepository repositorio = new FacturaRepository();
        private decimal totalPedidoSeleccionado = 0;

        public FrmFactura()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            var pedidos = repositorio.ListarPedidos();
            cboPedido.DataSource = pedidos;
            cboPedido.DisplayMember = "IdPedido";
            cboPedido.ValueMember = "IdPedido";
            cboPedido.SelectedIndex = -1;

            var formasPago = repositorio.ListarFormaPago();
            cboFormaPago.DataSource = formasPago;
            cboFormaPago.DisplayMember = "Nombre";
            cboFormaPago.ValueMember = "IdFormPago";
            cboFormaPago.SelectedIndex = -1;

            var empleados = repositorio.ListarEmpleados();
            cboEmpleado.DataSource = empleados;
            cboEmpleado.DisplayMember = "Nombre";
            cboEmpleado.ValueMember = "IdEmpleado";
            cboEmpleado.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboPedido.SelectedIndex == -1 || cboFormaPago.SelectedIndex == -1 || cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione pedido, forma de pago y empleado.");
                return;
            }

            if (!decimal.TryParse(txtIVA.Text, out decimal iva))
            {
                MessageBox.Show("Ingrese un porcentaje de IVA válido.");
                return;
            }

            DataRowView filaPedido = (DataRowView)cboPedido.SelectedItem;
            decimal totalPedido = Convert.ToDecimal(filaPedido["Total"]);
            decimal totalPagar = totalPedido + (totalPedido * iva / 100);

            Factura factura = new Factura();
            factura.IdFactura = new Random().Next(1000, 999999);
            factura.IdPedido = Convert.ToInt32(cboPedido.SelectedValue);
            factura.FechaFactura = dtpFecha.Value;
            factura.IVA = iva;
            factura.Totalpagar = totalPagar;
            factura.IdFormPago = cboFormaPago.SelectedValue.ToString();
            factura.IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

            try
            {
                repositorio.Guardar(factura);
                MessageBox.Show("Factura guardada correctamente. Total a pagar: C$ " + totalPagar.ToString("0.00"));
                lblTotalPagar.Text = "C$ " + totalPagar.ToString("0.00");
                MostrarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarFacturas();
        }

        private void MostrarFacturas()
        {
            dgvFactura.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboPedido.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            cboEmpleado.SelectedIndex = -1;
            txtIVA.Clear();
            dtpFecha.Value = DateTime.Now;
            lblTotalPagar.Text = "C$ 0.00";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxDatosFactura_Enter(object sender, EventArgs e)
        {

        }
    }
}


