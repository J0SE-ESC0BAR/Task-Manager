using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganizadorJAEM.Forms
{
    internal class PagoTutor
    {
        public int Id_PagoTutor { get; set; }
        public int Id_Tutor { get; set; }
        public int Id_Tarea { get; set; }
        public string MetodoPago { get; set; }
        public DateTime? Pagado { get; set; }
        public decimal Precio { get; set; }

        public PagoTutor()
        {
        }
        public static void ActualizarPagoTutor(string cadenaConexion, int idPagoTutor, DateTime? pagado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ActualizarPagoTutor", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@Id_PagoTutor", idPagoTutor);
                    if (pagado.HasValue)
                    {
                        comando.Parameters.AddWithValue("@Pagado", pagado);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@Pagado", DBNull.Value);
                    }
                    // Ejecutar el procedimiento almacenado para actualizar los datos
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al actualizar tarea: " + ex.Message);
            }
        }
        public static List<PagoTutor> ObtenerPagosTutor(string cadenaConexion)
        {
            List<PagoTutor> pagosTutor = new List<PagoTutor>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ObtenerPagoTutor", conexion);

                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        PagoTutor pagoTutor = new PagoTutor
                        {
                            Id_PagoTutor = Convert.ToInt32(reader["Id_PagoTutor"]),
                            Id_Tutor = Convert.ToInt32(reader["Id_Tutor"]),
                            Id_Tarea = Convert.ToInt32(reader["Id_Tarea"]),
                            MetodoPago = Convert.ToString(reader["MetodoPago"]),
                            Pagado = reader["Pagado"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["Pagado"]),
                            Precio = reader["Precio"] == DBNull.Value ? 0 : (decimal)reader["Precio"]
                        };
                        pagosTutor.Add(pagoTutor);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al obtener pagos de tutores: " + ex.Message);
            }
            return pagosTutor;
        }
    }
}
