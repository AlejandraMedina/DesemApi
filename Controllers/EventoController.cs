using Microsoft.AspNetCore.Mvc;

namespace DesemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {

        //public IAltaEvento AltaEvento { get; set; }


        //public TiposController(IAltaEvento cuAltaEvento)
        //{
        //    AltaEvento = cuAltaEvento;

        //}


        //// POST api/<TiposController>
        //[HttpPost]
        //[ActionName(nameof(Post))]
        //[Authorize]
        //public IActionResult Post([FromBody] EventoDTO? evento)   //Add
        //{
        //    if (evento == null) return BadRequest("No se envió información de evento");
        //    try
        //    {

        //        AltaEvento.Alta(evento);
        //    }
        //    //catch (NombreEventoInvalidoException ex)
        //    //{
        //    //    return BadRequest(ex.Message);
        //    //}
        //    catch
        //    {
        //        return StatusCode(500, "Ocurrió un error, no se pudo dara el alta de evento");

        //    }

        //    return Ok(evento);
        //   // return CreatedAtRoute("FindById", new { id = evento.Id }, evento);

        //}

    }

}

