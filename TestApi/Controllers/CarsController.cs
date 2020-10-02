using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Controllers
{
    // now using Repository for realise RESTfull emmiters
    
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        public IRepository<CarModel> contextCars { get; private set; }
        public CarsController(IRepository<CarModel> contextCars)
        {
            this.contextCars = contextCars;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<CarModel>> Get()
        {
            List<CarModel> result = null;
            try
            {
                result = contextCars.All.ToList();
                if (result.Count == 0)
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult<CarModel> Get(int id)
        {
            return contextCars.FindById(id);
        }
        [HttpPost]
        public void Post([FromQuery] CarModel value)
        {
            contextCars.Update(value);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CarModel value)
        {
            contextCars.Add(value);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = contextCars.FindById(id);
            contextCars.Delete(entity);
        }
    }
}
