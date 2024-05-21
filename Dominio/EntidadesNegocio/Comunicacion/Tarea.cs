using System.ComponentModel.DataAnnotations;

namespace Dominio.EntidadesNegocio.Comunicacion
{
    public abstract class Tarea
    {
        [Key]
        public int Id { get; set; }

        public DateTime Fecha { set; get; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string Estado { set; get; } /// hacerlo enum 


    }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
}
