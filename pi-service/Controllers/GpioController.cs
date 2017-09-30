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

        [HttpGet("pin")]
        public IActionResult GetInitializedPins()
        {
            try
            {
                return Json(_gpio.GetInitializedPins());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("pin/{pin}")]
        public IActionResult GetPin(int pin)
        {
            try
            {
                return Json(_gpio.GetPin(pin));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("pin")]
        public IActionResult UpdatePin([FromBody]PinModel model)
        {
            try
            {
                _gpio.SetPin(model.number, model.on);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("pin/{pin}")]
        public IActionResult DeInitPin(int pin)
        {
            try
            {
                _gpio.DeInitPin(pin);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("pin/{pin}")]
        public IActionResult InitPin(int pin)
        {
            try
            {
                _gpio.InitPin(pin, true);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
