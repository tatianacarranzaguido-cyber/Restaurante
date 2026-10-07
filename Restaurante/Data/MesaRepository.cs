using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class MesaRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(Mesa mesa)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Mesas (IdMesa, Numesa, Capacidad, Estado) VALUES (@IdMesa, @Numesa, @Capacidad, @Estado)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdMesa", mesa.IdMesa);
                cmd.Parameters.AddWithValue("@Numesa", mesa.Numesa);
                cmd.Parameters.AddWithValue("@Capacidad", mesa.Capacidad);
                cmd.Parameters.AddWithValue("@Estado", mesa.Estado);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM Mesas";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
