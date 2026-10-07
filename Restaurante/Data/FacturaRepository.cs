using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class FacturaRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(Factura factura)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Factura (IdFactura, IdPedido, FechaFactura, IVA, Totalpagar, IdFormPago, IdEmpleado) VALUES (@IdFactura, @IdPedido, @FechaFactura, @IVA, @Totalpagar, @IdFormPago, @IdEmpleado)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@IdPedido", factura.IdPedido);
                cmd.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                cmd.Parameters.AddWithValue("@IVA", factura.IVA);
                cmd.Parameters.AddWithValue("@Totalpagar", factura.Totalpagar);
                cmd.Parameters.AddWithValue("@IdFormPago", factura.IdFormPago);
                cmd.Parameters.AddWithValue("@IdEmpleado", factura.IdEmpleado);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Factura", conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarPedidos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT IdPedido, Total FROM Pedidos", conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarFormaPago()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT IdFormPago, Nombre FROM FormaPago", conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarEmpleados()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT IdEmpleado, Nombre FROM Empleados", conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
