using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrabPatient.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrabPatient.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index(string keywords) => View(services.Values.ToArray());
        public IActionResult Get(Guid id) => View(services[id]);

        static IDictionary<Guid, Service> services = Enumerable.Range(0, 5).Select(x => new Service
        {
            Id = Guid.NewGuid(),
            Details = "Details",
            Provider = "Mr. Dentist",
            Summary = "อุดฟัน; ถอนฟัน" ,
         })
        .ToDictionary(x => x.Id);
    }
}
