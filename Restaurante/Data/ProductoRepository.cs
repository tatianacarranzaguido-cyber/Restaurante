using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class ProductoRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(Producto producto)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Producto (IdProduc, Nombre, Descrip, Precio, Categoria) VALUES (@IdProduc, @Nombre, @Descrip, @Precio, @Categoria)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdProduc", producto.IdProduc);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descrip", producto.Descrip);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM Producto";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
