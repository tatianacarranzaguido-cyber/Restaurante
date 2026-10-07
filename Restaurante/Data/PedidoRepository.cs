using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class PedidoRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(Pedido pedido, DataTable detalle)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO Pedidos (IdPedido, IdClient, IdMesa, Fecha, IdformPago, Total, IdEmpleado) VALUES (@IdPedido, @IdClient, @IdMesa, @Fecha, @IdformPago, @Total, @IdEmpleado)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);
                cmd.Parameters.AddWithValue("@IdClient", pedido.IdClient);
                cmd.Parameters.AddWithValue("@IdMesa", pedido.IdMesa);
                cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                cmd.Parameters.AddWithValue("@IdformPago", pedido.IdFormPago);
                cmd.Parameters.AddWithValue("@Total", pedido.Total);
                cmd.Parameters.AddWithValue("@IdEmpleado", pedido.IdEmpleado);
                cmd.ExecuteNonQuery();

                foreach (DataRow fila in detalle.Rows)
                {
                    string queryDetalle = "INSERT INTO Detallepedid (IdProduc, Idpedido, Cantidad, Precio) VALUES (@IdProduc, @Idpedido, @Cantidad, @Precio)";
                    SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion);
                    cmdDetalle.Parameters.AddWithValue("@IdProduc", fila["IdProduc"]);
                    cmdDetalle.Parameters.AddWithValue("@Idpedido", pedido.IdPedido);
                    cmdDetalle.Parameters.AddWithValue("@Cantidad", fila["Cantidad"]);
                    cmdDetalle.Parameters.AddWithValue("@Precio", fila["Precio"]);
                    cmdDetalle.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarMesas()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT IdMesa, Numesa FROM Mesas", conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT IdClient, Nombre FROM Clientes", conexion);
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

        public DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT IdProduc, Nombre, Precio FROM Producto", conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
