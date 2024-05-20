using Domino.EntidadesNegocio;
using DTOs;

namespace Aplicacion.Interfaces
{
    public interface ILoginUsuario
    {
        UsuarioDTO LoginUsuario(string Email, string Password);

        public Usuario ExisteUsuario(string Email, string Password);
    }
}
