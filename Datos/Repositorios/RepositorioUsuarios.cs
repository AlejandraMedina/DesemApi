
using DesemApi;
using Dominio.InterfacesRepositorios;
using Domino.EntidadesNegocio;


namespace Datos.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {

        public DesemContext Contexto { get; set; }

        public RepositorioUsuarios(DesemContext ctx)
        {
            Contexto = ctx;
        }

        public void Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string mail, string password)
        {
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return Contexto.Usuarios
                    .Where(u => u.Email == mail && u.Contrasena == password)
                    .SingleOrDefault();
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }

}
