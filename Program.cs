using System;
using System.Windows.Forms;

namespace OrganizadorJAEM
{
    public static class Configuracion
    {
        // Aquí se puede utilizar el archivo de configuración para obtener la cadena de conexión
        public static string CadenaConexion = "Server=JOSE;Database=TaskControlCenter;Trusted_Connection=True;";
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Inicio());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar la aplicación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}