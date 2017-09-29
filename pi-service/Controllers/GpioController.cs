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

        [HttpGet("status/{pin}")]
        public string Status(int pin)
        {
            try
            {
                return _gpio.Get(pin).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // GET api/values/5
        [HttpGet("{pin}/{on}")]
        public string Get(int pin, bool on)
        {
            try
            {
                _gpio.Set(pin, GpioDirection.Out, on);
                return string.Format("Set pin {0} to {1}", pin, on);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
