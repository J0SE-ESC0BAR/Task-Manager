using System;

namespace OrganizadorJAEM
{
    internal class Persona
    {
        public string Celular { get; set; }
        public string Correo { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? DeBaja { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public int? Edad { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {
        }
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public Persona(string nombre, string celular)
        {
            Nombre = nombre;
            Celular = celular;
        }
    }
}
