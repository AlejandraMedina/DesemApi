namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class SolicitudPresupuesto : Tarea
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public TipoPresupuesto Tipo { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public DateTime Fecha { get; set; }
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva

        public int CantidadPersonas { get; set; }



    }
}
