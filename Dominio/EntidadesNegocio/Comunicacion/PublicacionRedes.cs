namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class PublicacionRedes : Tarea
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string DescripcionPosteo { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public DateTime FechaLimite { get; set; }

        public bool Campania { get; set; }

        public bool Pauta { get; set; }

    }
}
