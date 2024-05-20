using System.ComponentModel.DataAnnotations;

namespace Dominio.EntidadesNegocio.Comunicacion
{
    public abstract class Tarea
    {
        [Key]
        public int Id { get; set; }

        public DateTime Fecha { set; get; }

        public string Estado { set; get; } /// hacerlo enum 


    }
}
