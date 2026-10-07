using System;
using System.Windows.Forms;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante
{
    public partial class FrmEmpleados : Form
    {
        private EmpleadoRepository repositorio = new EmpleadoRepository();

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado.");
                return;
            }

            if (!decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                MessageBox.Show("Ingrese un salario válido.");
                return;
            }

            Empleado empleado = new Empleado();
            empleado.IdEmpleado = new Random().Next(1000, 999999);
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Cargo = txtCargo.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.Salario = salario;
            empleado.FechContratacion = dtpFechaContratacion.Value;

            try
            {
                repositorio.Guardar(empleado);
                MessageBox.Show("Empleado guardado correctamente.");
                MostrarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            dgvEmpleados.DataSource = repositorio.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
            txtTelefono.Clear();
            txtSalario.Clear();
            dtpFechaContratacion.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

