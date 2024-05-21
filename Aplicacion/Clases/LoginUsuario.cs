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


#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public LoginUsuario(IRepositorioUsuarios repoUsuario)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {

            RepoUsuario = repoUsuario;
        }



        UsuarioDTO ILoginUsuario.LoginUsuario(string mail, string Password)
        {

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            UsuarioDTO dto = null;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
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
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return dto;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo

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
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return null;
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo

        }


    }
}
