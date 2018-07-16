using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vehicleWebApi.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        // GET: api/vehicles
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "vehicles" };
        }

        // GET api/vehicles/civic/honda/black/2017
        [HttpGet("{name}/{brand}/{color}/{year}")]
        public string Get(string name, string brand, string color, int year)
        {
            return $"vehicle: {name}, {brand}, {color}, {year}.";
        }

        // POST api/vehicles
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/vehicles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/vehicles/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
