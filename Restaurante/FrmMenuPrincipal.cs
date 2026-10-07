using System;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            FrmMesas frm = new FrmMesas();
            frm.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados();
            frm.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FrmPago frm = new FrmPago();
            frm.Show();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            FrmReservaciones frm = new FrmReservaciones();
            frm.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedido frm = new FrmPedido();
            frm.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FrmFactura frm = new FrmFactura();
            frm.Show();
        }
    }
}
