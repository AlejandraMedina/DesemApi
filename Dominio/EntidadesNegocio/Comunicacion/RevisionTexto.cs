namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class RevisionTexto : Tarea
    {
        public string Texto { get; set; }
        public DateTime FechaLimite { get; set; }

        public Plataforma Plataforma { get; set; }


    }
}
