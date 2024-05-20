namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class Evento : Tarea
    {
        public int CantidadPersonas { get; set; }
        public DateTime Fecha { get; set; }

        public bool Catering { get; set; }

        public string Lugar { get; set; }
        public bool Audio { get; set; }

        public bool Pantalla { get; set; }

        public bool CoberturaFoto { get; set; }

        public bool CoberturaVideo { get; set; }


    }
}
