namespace Dominio.EntidadesNegocio.Comunicacion
{
    public class Pedido : Tarea
    {
        public int Id { get; set; }
        public List<Tarea> Tareas { get; set; }

        public string Estado { get; set; }

        public Programa Programa { get; set; }

        //public Coordinador Coordinador { get; set; }
    }
}
