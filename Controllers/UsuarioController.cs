using Aplicacion;
using Aplicacion.Clases;
using Aplicacion.Interfaces;
using DesemAPI;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public ILoginUsuario CULogin { get; set; }

        public ILoginUsuario LoginUsuario { get; set; }

        public UsuariosController(ILoginUsuario cuLogin, ILoginUsuario login)
        {
            CULogin = cuLogin;
            LoginUsuario = login;
        }


      

        //api/usuarios/login POST
        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioDTO usuario)
        {
            UsuarioDTO logueado = LoginUsuario.LoginUsuario(usuario.Email, usuario.Password);
            if (logueado == null) return Unauthorized("El usuario o la contraseña no son correctos ");
            return Ok(ManejadorJWT.GenerarToken(logueado));
        }
    }
}


