namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class Impresion : Tarea
    {
        public DateTime FechaLimite { get; set; }

        public TipoImpresion Tipo { get; set; }

        public int CantidadCopias { get; set; }
        public string Gramaje { get; set; }

        public string Tamanio { get; set; }

        public bool Plastificado { get; set; }

        public double Presupuesto { get; set; }
    }
}
