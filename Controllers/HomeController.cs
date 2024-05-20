using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DesemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {


        [HttpGet("GetSaludo/{nombre}")]
        public string Get(string nombre)
        {
            return "Hola" + nombre;
        }


#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        private struct User
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        {
            public string nombre;
            public int id;
            public string mail;
        }


        [HttpGet("GetUsuario/{id}/{nombre}/{mail}")]
        public string Get(int id, string nombre, string mail)
        {
            User usuario = new User();
            usuario.id = id;
            usuario.mail = mail;
            usuario.nombre = nombre;

            string respuesta = JsonConvert.SerializeObject(usuario);

            return respuesta;
        }


        public class UsuarioP
        {
            public int id { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public string name { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        }



        [HttpPost("PostUser")]
        public string Post(UsuarioP usuario)
        {
            return JsonConvert.SerializeObject(usuario);

        }

        [HttpPatch("UpdateUser")]
        public string Patch(UsuarioP usuario)
        {
            return "Se actualizó el usuario correctamente";

        }


        //[HttpDelete("DelUsuario")]
        //public string Delete(int UsuarioId)
        //{
        //    return "Se eliminó el usuario correctamente";
        //}


        //[HttpDelete("{id}")]
        //[Authorize]
        //public IActionResult Delete(int id)  // Delete 
        //{
        //    if (id <= 0) return BadRequest("El id proporcionado no es válido");
        //    try
        //    {
        //       // EliminarTipo.Remove(id);
        //    }
        //    catch (ErrorTipoException ex)
        //    {
        //        return NotFound($"El tipo con id  {id} NotFound se puede borrar porque no existe");
        //    }
        //    catch
        //    {
        //        return StatusCode(500, "Ocurrió un error");
        //    }
        //    return NoContent();
        //}

    }

}
