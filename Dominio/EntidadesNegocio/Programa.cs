using Dominio.EntidadesNegocio.Comunicacion;
using Dominio.EntidadesNegocio.Finanzas;
using Dominio.EntidadesNegocio.Usuarios.Finanzas;
using System.ComponentModel.DataAnnotations;

namespace Dominio.EntidadesNegocio
{
    public class Programa
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Logo { get; set; }

        // public List<Coordinador> Coordinador { get; set; }

        public List<Gasto> Gastos { get; set; }

        public List<Pedido> Pedidos { get; set; }

        public List<Adelanto> Adelantos { get; set; }



    }
}
