using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pi_dotnetcore.Gpio;
using pi_service.Models;

namespace pi_service.Controllers
{
    [Route("api/gpio")]
    public class GpioController : Controller
    {
        private IGpio _gpio;

        public GpioController(IGpio gpio)
        {
            _gpio = gpio;
        }

        [HttpGet("pin/{pin}")]
        public IActionResult GetPin(int pin)
        {
            return Json(_gpio.GetPin(pin));
        }

        [HttpPost("pin")]
        public IActionResult UpdatePin([FromBody]PinModel model)
        {
            return Json(_gpio.SetPin(model.number, model.output, model.on));
        }
    }
}
