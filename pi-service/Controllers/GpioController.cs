using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pi_dotnetcore;

namespace pi_service.Controllers
{
    [Route("api/gpio")]
    public class GpioController : Controller
    {
        private Gpio _gpio;

        public GpioController()
        {
            _gpio = new Gpio();
        }

        [HttpGet("pin/{pin}")]
        public GpioPin GetPin(int pin)
        {
            return _gpio.Get(pin);
        }

        [HttpPost("pin")]
        public GpioPin UpdatePin(int pin, bool output, bool on)
        {
            return _gpio.Set(pin, (output) ? GpioDirection.Out : GpioDirection.In, on);
        }
    }
}
