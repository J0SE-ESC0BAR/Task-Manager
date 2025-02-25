using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    internal class Estudiante : Persona
    {
        public string cadenaConexion = Configuracion.CadenaConexion;
        public string Universidad { get; set; }
        public string Carnet { get; set; }
        public string Carrera { get; set; }

        public Estudiante(string nombre)
            : base(nombre) { }

        public Estudiante(string nombre, string celular)
            : base(nombre, celular) { }

        public void Registrar(string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                string procedure = "dbo.RegistrarEstudiante";

                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Carnet", Carnet);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                command.Parameters.AddWithValue("@Carrera", Carrera);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Correo", Correo);
                command.Parameters.AddWithValue("@Creado", Creado);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@Edad", Edad);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Universidad", Universidad);

                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Estudiante creado con EXITO", "Nuevo Estudiante");
        }

        public void Actualizar()
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                string procedure = "dbo.ActualizarEstudiante";

                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Universidad", Universidad);
                command.Parameters.AddWithValue("@Carnet", Carnet);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.Parameters.AddWithValue("@DeBaja", DeBaja);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Datos del estudiante actualizados correctamente.");
        }

        public void DarDeBaja()
        {
            DeBaja = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                string procedure = "dbo.DarDeBajaEstudiante";

                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@DeBaja", DeBaja);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Estudiante dado de baja correctamente.");
        }
    }
}