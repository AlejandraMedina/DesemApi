namespace Dominio.EntidadesNegocio.Usuarios.Finanzas
{
    public class Adelanto
    {
        public int Id { get; set; }

        public string Motivo { get; set; }

        public DateTime Fecha { set; get; }

        public double Importe { set; get; }

        public string Moneda { set; get; }

        public string CentroCosto { set; get; }

        public Programa Programa { set; get; }

        //public Coordinador Coordinador { set; get; }

        public string Estado { set; get; } /// hacerlo enum 



    }
}
