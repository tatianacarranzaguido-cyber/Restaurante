using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class ClienteRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(Cliente cliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Clientes (IdClient, Nombre, Telf, Correo) VALUES (@IdClient, @Nombre, @Telf, @Correo)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdClient", cliente.IdClient);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telf", cliente.Telf);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM Clientes";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}