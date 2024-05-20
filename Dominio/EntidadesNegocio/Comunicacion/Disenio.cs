namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class Disenio : Tarea
    {

        public string Descripcion { get; set; }
        public DateTime FechaLimite { get; set; }

        public string Multimedia { get; set; }   //imagen o video  

        public string Logo { get; set; }
        public string Formato { get; set; }   // enum
    }
}
