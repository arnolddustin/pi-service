using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pi_dotnetcore;

namespace pi_service.Models
{
    public class GpioPinModel
    {
        public int number { get; set; }
        public bool output { get; set; }
        public bool on { get; set; }
    }
}