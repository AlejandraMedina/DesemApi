namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class PublicacionRedes : Tarea
    {
        public string DescripcionPosteo { get; set; }
        public DateTime FechaLimite { get; set; }

        public bool Campania { get; set; }

        public bool Pauta { get; set; }

    }
}
