using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    internal class Tutor : Persona
    {
        private string connectionString = Configuracion.CadenaConexion;

        public Tutor(string nombre)
            : base(nombre) { }
        public Tutor(string nombre, string celular)
            : base(nombre, celular) { }

        public void Registrar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string procedure = "dbo.RegistrarTutor";

                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Correo", Correo);
                command.Parameters.AddWithValue("@Creado", Creado);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@Edad", Edad);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Tutor creado con EXITO", "Nuevo Tutor");
        }

        public void Actualizar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string procedure = "dbo.ActualizarTutor";

                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Descripcion", Descripcion);
                command.Parameters.AddWithValue("@Correo", Correo);
                command.Parameters.AddWithValue("@DeBaja", DeBaja);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Datos del tutor actualizados correctamente.");
        }

        public void DarDeBaja()
        {
            DeBaja = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string procedure = "dbo.DarDeBajaTutor";

                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@DeBaja", DeBaja);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Tutor dado de baja correctamente.");
        }
    }
}