using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Controllers
{
    // now using Repository for realise RESTfull emmiters
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        public IRepository<CarModel> contextCars { get; private set; }
        public CarsController(IRepository<CarModel> contextCars)
        {
            this.contextCars = contextCars;
        }
        [HttpGet]
        public IEnumerable<CarModel> Get()
        {
            return contextCars.All;
        }
        [HttpGet("{id}")]
        public ActionResult<CarModel> Get(int id)
        {
            return contextCars.FindById(id);
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
