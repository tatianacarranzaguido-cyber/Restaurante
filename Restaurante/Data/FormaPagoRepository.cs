using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class FormaPagoRepository
    {
        private string cadena = "Server=DESKTOP-SB3GDA7;Database=Restaurante;Trusted_Connection=True;TrustServerCertificate=True;";

        public void Guardar(FormaPago formaPago)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "INSERT INTO FormaPago (IdFormPago, Nombre, Descrip) VALUES (@IdFormPago, @Nombre, @Descrip)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdFormPago", formaPago.IdFormPago);
                cmd.Parameters.AddWithValue("@Nombre", formaPago.Nombre);
                cmd.Parameters.AddWithValue("@Descrip", formaPago.Descrip);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM FormaPago";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
