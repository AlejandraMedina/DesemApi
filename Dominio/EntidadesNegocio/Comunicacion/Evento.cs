namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class Evento : Tarea
    {
        public int CantidadPersonas { get; set; }
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public DateTime Fecha { get; set; }
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva

        public bool Catering { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string Lugar { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public bool Audio { get; set; }

        public bool Pantalla { get; set; }

        public bool CoberturaFoto { get; set; }

        public bool CoberturaVideo { get; set; }


    }
}
