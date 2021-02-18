using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using winter20_burgershack.Models;
using winter20_burgershack.Services;

namespace burgershack_winter20.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class SidesController : ControllerBase
  {

    private readonly SidesService _service;

    public SidesController(SidesService service)
    {
      _service = service;
    }

    [HttpGet]

    public ActionResult<IEnumerable<Side>> Get()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Side> Get(int id)
    {
      try
      {
        return Ok(_service.Get(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Side> Create([FromBody] Side newSide)
    {
      try
      {
        return Ok(_service.Create(newSide));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Side> Edit(
      [FromBody] Side editSide, int id)
    {
      try
      {
        editSide.Id = id;
        return Ok(_service.Edit(editSide));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Side> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}