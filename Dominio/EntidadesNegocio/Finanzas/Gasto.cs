namespace Dominio.EntidadesNegocio.Finanzas
{
    public class Gasto
    {

        public int Id { set; get; }

        public Rubro Rubro { set; get; }

        public string Moneda { set; get; }  // enum  pesos dolares

        public string Comprobante { set; get; }

        public string Proveedor { set; get; }

        public string Descripcion { set; get; }

        public string TipoGasto { set; get; }  // enum caja chica credito 

        public double Importe { set; get; }

        public DateTime Fecha { set; get; }

        public string CentroCosto { set; get; }

        public Programa Programa { set; get; }

        // public Coordinador Coordinador { set; get; }


    }
}
