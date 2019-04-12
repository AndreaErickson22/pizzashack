using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaShack.Mock;

namespace PizzaShack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase

  {
    // public List<String> MyValues = new List<string>() { "value1", "value2", "value3", "value4" };


    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return FakeDb.MyValues;

    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      if (id < FakeDb.MyValues.Count)
      {
        return FakeDb.MyValues[id];
      }
      return BadRequest("Index Out of Range");
    }

    // POST api/values
    [HttpPost]
    public ActionResult<IEnumerable<string>> Post([FromBody] string value)
    {
      FakeDb.MyValues.Add(value);

      return FakeDb.MyValues;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
