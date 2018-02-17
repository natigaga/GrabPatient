using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrabPatient.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Provider { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
    }
}
