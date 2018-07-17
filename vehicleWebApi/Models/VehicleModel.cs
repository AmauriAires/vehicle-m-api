using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace vehicleWebApi.Models
{
    public class VehicleModel
    {
        // Gets or sets Name.
        public string Name { get; set; }

        // Gets or sets Brand.
        public string Brand { get; set; }

        // Gets or sets Color.
        public string Color { get; set; }

        // Gets or sets Year.
        public int Year { get; set; }

        // Gets or sets Pictures.
        public string[] Pictures { get; set; }
    }
}
