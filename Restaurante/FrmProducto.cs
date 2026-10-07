using System;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmProducto : Form
    {
        private ProductoRepository repositorio = new ProductoRepository();

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                return;
            }

            Producto producto = new Producto();
            producto.IdProduc = new Random().Next(1000, 999999);
            producto.Nombre = txtNombre.Text;
            producto.Descrip = txtDescripcion.Text;
            producto.Categoria = txtCategoria.Text;

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }
            producto.Precio = precio;

            try
            {
                repositorio.Guardar(producto);
                MessageBox.Show("Producto guardado correctamente.");
                MostrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            dgvProducto.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


