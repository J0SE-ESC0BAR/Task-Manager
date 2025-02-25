using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganizadorJAEM.Forms
{
    internal class Tarea
    {
        public int? Id_Tarea { get; set; }
        public int? Id_Estudiante { get; set; }
        public int? Id_Tutor { get; set; }
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public DateTime Asignado { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime? Iniciado { get; set; }
        public DateTime? Finalizado { get; set; }
        public DateTime? Entregado { get; set; }
        public decimal? Horas { get; set; }
        public string Calificacion { get; set; }
        public int? Cancelado { get; set; }
        public bool? EntregarPortal { get; set; }

        public Tarea()
        {
        }

        public static void ActualizarTarea(string cadenaConexion, int idTarea, DateTime? iniciado, DateTime? finalizado, DateTime? entregado, decimal horas)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ActualizarTareaPendiente", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@Id_Tarea", idTarea);
                    if (iniciado.HasValue)
                    {
                        comando.Parameters.AddWithValue("@Iniciado", iniciado);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@Iniciado", DBNull.Value);
                    }

                    if (finalizado.HasValue)
                    {
                        comando.Parameters.AddWithValue("@Finalizado", finalizado);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@Finalizado", DBNull.Value);
                    }
                    if (entregado.HasValue)
                    {
                        comando.Parameters.AddWithValue("@Entregado", entregado);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@Entregado", DBNull.Value);
                    }

                    if (horas == 0)
                    {
                        comando.Parameters.AddWithValue("@Horas", DBNull.Value);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@Horas", horas);
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

        public static List<Tarea> TraerTareasPendientes(string cadenaConexion)
        {
            List<Tarea> tareasPendientes = new List<Tarea>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("ObtenerTareasPendientes", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Tarea tarea = new Tarea
                        {
                            Id_Tarea = Convert.ToInt32(reader["Id_Tarea"]),
                            Id_Estudiante = Convert.ToInt32(reader["Id_Estudiante"]),
                            Id_Tutor = Convert.ToInt32(reader["Id_Tutor"]),
                            Tema = Convert.ToString(reader["Tema"]),
                            Descripcion = Convert.ToString(reader["Descripcion"]),
                            Asignado = Convert.ToDateTime(reader["Asignado"]),
                            Vencimiento = Convert.ToDateTime(reader["Vencimiento"]),
                            Iniciado = reader["Iniciado"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["Iniciado"]),
                            Finalizado = reader["Finalizado"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["Finalizado"]),
                            Entregado = reader["Entregado"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["Entregado"]),
                            EntregarPortal = reader["EntregarPortal"] == DBNull.Value ? false : true
                        };
                        tareasPendientes.Add(tarea);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al obtener tareas pendientes: " + ex.Message);
            }
            return tareasPendientes;
        }

    }
}