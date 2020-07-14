using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces.Services;
using Domain.Entities;
using System.Net;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace MonitorarEvento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventoController : ControllerBase
    {
        private IEventoService _service;
        
        public EventoController(IEventoService service)
        {
            _service = service;
        }

        //preparado para futuras implementações
        //[HttpGet]
        //public async Task<ActionResult> GetAll()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        return Ok(await _service.GetAll());
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}

        [HttpGet]
        [Route("relacaoEvento")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RelacaoEvento>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.GetRelacaoEvento());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //preparado para futuras implementações
        //[HttpPut]
        //public async Task<ActionResult> Put([FromBody] Evento evento)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        var result = await _service.Put(evento);
        //        if (result != null)
        //        {
        //            return Ok(result);
        //        }
        //        else
        //        {
        //            return BadRequest();
        //        }
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] Evento evento)
        {
            if (!ModelState.IsValid || evento.Valor == "")
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(evento);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        return Ok(await _service.Delete(id));
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //    }
        //}
    }
}