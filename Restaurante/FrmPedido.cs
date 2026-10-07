using System;
using System.Data;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmPedido : Form
    {
        private PedidoRepository repositorio = new PedidoRepository();
        private DataTable dtDetalle;

        public FrmPedido()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarGridDetalle();
        }

        private void CargarCombos()
        {
            var mesas = repositorio.ListarMesas();
            cboMesa.DataSource = mesas;
            cboMesa.DisplayMember = "Numesa";
            cboMesa.ValueMember = "IdMesa";
            cboMesa.SelectedIndex = -1;

            var clientes = repositorio.ListarClientes();
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdClient";
            cboCliente.SelectedIndex = -1;

            var empleados = repositorio.ListarEmpleados();
            cboEmpleado.DataSource = empleados;
            cboEmpleado.DisplayMember = "Nombre";
            cboEmpleado.ValueMember = "IdEmpleado";
            cboEmpleado.SelectedIndex = -1;

            dgvProductosDisponibles.DataSource = repositorio.ListarProductos();
        }

        private void ConfigurarGridDetalle()
        {
            dtDetalle = new DataTable();
            dtDetalle.Columns.Add("IdProduc", typeof(int));
            dtDetalle.Columns.Add("Producto");
            dtDetalle.Columns.Add("Cantidad", typeof(int));
            dtDetalle.Columns.Add("Precio", typeof(decimal));
            dtDetalle.Columns.Add("Subtotal", typeof(decimal));
            dgvDetallePedido.DataSource = dtDetalle;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataRow row in dtDetalle.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotal.Text = "Total: C$ " + total.ToString("0.00");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProductosDisponibles.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            int idProducto = Convert.ToInt32(dgvProductosDisponibles.CurrentRow.Cells["IdProduc"].Value);
            string nombre = dgvProductosDisponibles.CurrentRow.Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(dgvProductosDisponibles.CurrentRow.Cells["Precio"].Value);

            dtDetalle.Rows.Add(idProducto, nombre, 1, precio, precio);
            CalcularTotal();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboMesa.SelectedIndex == -1 || cboCliente.SelectedIndex == -1 || cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione mesa, cliente y empleado.");
                return;
            }

            if (dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al pedido.");
                return;
            }

            decimal total = 0;
            foreach (DataRow row in dtDetalle.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }

            Pedido pedido = new Pedido();
            pedido.IdPedido = new Random().Next(1000, 999999);
            pedido.IdMesa = Convert.ToInt32(cboMesa.SelectedValue);
            pedido.IdClient = Convert.ToInt32(cboCliente.SelectedValue);
            pedido.IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            pedido.Fecha = DateTime.Now;
            pedido.IdFormPago = "FP374";
            pedido.Total = total;

            try
            {
                repositorio.Guardar(pedido, dtDetalle);
                MessageBox.Show("Pedido guardado correctamente.");
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboMesa.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboEmpleado.SelectedIndex = -1;
            dtDetalle.Rows.Clear();
            CalcularTotal();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}