using System.ComponentModel.DataAnnotations;

namespace Domino.EntidadesNegocio
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Contrasena { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaInicio { get; set; }

        public string Telefono { get; set; }

        public string Foto { get; set; }

        public string Rol { get; set; }


    }
}
