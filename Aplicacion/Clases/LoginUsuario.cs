using Aplicacion.Interfaces;
using Dominio.InterfacesRepositorios;
using Domino.EntidadesNegocio;
using DTOs;

namespace Aplicacion.Clases
{
    public class LoginUsuario : ILoginUsuario
    {
        public IEnumerable<Usuario> usuarios;

        public IRepositorioUsuarios RepoUsuario { get; set; }


        public LoginUsuario(IRepositorioUsuarios repoUsuario)
        {

            RepoUsuario = repoUsuario;
        }



        UsuarioDTO ILoginUsuario.LoginUsuario(string mail, string Password)
        {

            UsuarioDTO dto = null;
            Usuario usu = RepoUsuario.Login(mail, Password);


            if (usu != null)
            {
                dto = new UsuarioDTO()
                {
                    Id = usu.Id,
                    Email = usu.Email,
                    Password = usu.Contrasena,
                    Rol = usu.Rol
                };
            }
            return dto;

        }


        public Usuario ExisteUsuario(string Email, string Password)
        {



            foreach (Usuario item in RepoUsuario.FindAll())
            {
                if (item.Email.Equals(Email.Trim()) && item.Contrasena.Equals(Password.Trim()))
                {
                    return item;
                }
            }
            return null;

        }


    }
}
