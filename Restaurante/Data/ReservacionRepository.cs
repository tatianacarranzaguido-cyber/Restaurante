using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class ReservacionRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(Reservacion reservacion)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Reservaciones (IdReserv, IdClient, IdMesa, Fecha, Hora, CantPers) VALUES (@IdReserv, @IdClient, @IdMesa, @Fecha, @Hora, @CantPers)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdReserv", reservacion.IdReserv);
                cmd.Parameters.AddWithValue("@IdClient", reservacion.IdClient);
                cmd.Parameters.AddWithValue("@IdMesa", reservacion.IdMesa);
                cmd.Parameters.AddWithValue("@Fecha", reservacion.Fecha);
                cmd.Parameters.AddWithValue("@Hora", reservacion.Hora);
                cmd.Parameters.AddWithValue("@CantPers", reservacion.CantPers);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM Reservaciones";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT IdClient, Nombre FROM Clientes";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ListarMesas()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT IdMesa, Numesa FROM Mesas";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
