namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class SolicitudPresupuesto : Tarea
    {
        public TipoPresupuesto Tipo { get; set; }

        public DateTime Fecha { get; set; }

        public int CantidadPersonas { get; set; }



    }
}
