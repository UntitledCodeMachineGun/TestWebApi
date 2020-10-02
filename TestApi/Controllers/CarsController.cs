using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly WebApiCoreContext context;
        public CarsController(WebApiCoreContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<CarModel> Get()
        {
            return context.CarsModel.ToList();
        }
    }
}
