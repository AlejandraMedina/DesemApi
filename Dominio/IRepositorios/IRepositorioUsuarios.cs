using Dominio.InterfacesRespositorios;
using Domino.EntidadesNegocio;

namespace Dominio.InterfacesRepositorios
{
    public interface IRepositorioUsuarios : IRepositorio<Usuario>
    {
        Usuario Login(string mail, string password);

    }
}
