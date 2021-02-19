using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using winter20_burgershack.Models;

namespace winter20_burgershack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DrinksController : ControllerBase
  {

    private readonly DrinksService _service;

    public DrinksController(DrinksService service)
    {
      _service = service;
    }

    [HttpGet]
    public
    ActionResult<IEnumerable<Drink>> GetAction()
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
    public ActionResult<Drink> Get(int id)
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
    public ActionResult<Drink> Create([FromBody] Drink newDrink)
    {
      try
      {
        return Ok(_service.Create(newDrink));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Drink> Edit([FromBody] Drink editDrink, int id)
    {
      try
      {
        editDrink.Id = id;
        return Ok(_service.Edit(editDrink));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Drink> Delete(int id)
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