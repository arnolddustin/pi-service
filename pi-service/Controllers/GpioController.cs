using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pi_dotnetcore;
using pi_service.Models;

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
        public GpioPin UpdatePin([FromBody]GpioPinModel model)
        {
            return _gpio.Set(model.number, (model.output) ? GpioDirection.Out : GpioDirection.In, model.on);
        }
    }
}
