using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vehicleWebApi.Models;
using Newtonsoft.Json;

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
            VehicleModel response;
            if (name == "Civic" && brand == "Honda" && color == "Blue" && year == 2016)
            {
                response = new VehicleModel()
                {
                    Name = "Civic",
                    Brand = "Honda",
                    Color = "Blue",
                    Year = 2016,
                    Pictures = new string[] { "img7.jpeg", "img8.jpeg", "img9.jpeg" }
                };
            }
            else if (name == "Civic" && brand == "Honda" && color == "Red" && year == 2016)
            {
                response = new VehicleModel()
                {
                    Name = "Civic",
                    Brand = "Honda",
                    Color = "Red",
                    Year = 2017,
                    Pictures = new string[] { "img4.jpeg", "img5.jpeg", "img6.jpeg" }
                };
            }
            else if (name == "" && brand == "" && color == "" && year == 2017)
            {
                response = new VehicleModel()
                {
                    Name = "Civic",
                    Brand = "Honda",
                    Color = "Blue",
                    Year = 2017,
                    Pictures = new string[] { "img1.jpeg", "img2.jpeg", "img3.jpeg" }
                };
            }
            else
            {
                response = new VehicleModel()
                {
                    Name = "Civic",
                    Brand = "Honda",
                    Color = "Blue",
                    Year = 2017,
                    Pictures = new string[] { "img1.jpeg", "img2.jpeg", "img3.jpeg" }
                };
            }

            string ans = JsonConvert.SerializeObject(response, Formatting.Indented);

            return ans;
        }

        // POST api/vehicles
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/vehicles/52
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
