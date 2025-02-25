using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganizadorJAEM.Forms
{
    internal class PagoTarea
    {
        public int Id_PagoTarea { get; set; }
        public int Id_Estudiante { get; set; }
        public int Id_Tarea { get; set; }
        public string MetodoPago { get; set; }
        public DateTime? Pagado { get; set; }
        public Decimal Precio { get; set; }
        public PagoTarea()
        {
        }
        public static void ActualizarPagoTarea(string cadenaConexion, int idPagoTarea, DateTime? pagado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ActualizarPagoTarea", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    // Parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@Id_PagoTarea", idPagoTarea);
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
        public static List<PagoTarea> ObtenerPagosTarea(string cadenaConexion)
        {
            List<PagoTarea> pagosTarea = new List<PagoTarea>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ObtenerPagoTarea", conexion);

                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        PagoTarea pagoTarea = new PagoTarea
                        {
                            Id_PagoTarea = Convert.ToInt32(reader["Id_PagoTarea"]),
                            Id_Estudiante = Convert.ToInt32(reader["Id_Estudiante"]),
                            Id_Tarea = Convert.ToInt32(reader["Id_Tarea"]),
                            MetodoPago = Convert.ToString(reader["MetodoPago"]),
                            Pagado = reader["Pagado"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["Pagado"]),
                            Precio = reader["Precio"] == DBNull.Value ? 0 : (decimal)reader["Precio"]
                        };
                        pagosTarea.Add(pagoTarea);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al obtener pagos de tareas: " + ex.Message);
            }
            return pagosTarea;
        }
    }
}

