using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pi_service.Controllers
{
    [Route("api/gpio")]
    public class GpioController : Controller
    {
        private Switcher _switcher;

        public GpioController()
        {
            _switcher = new Switcher();
        }

        // GET api/values/5
        [HttpGet("{pin}/{on}")]
        public string Get(int pin, bool on)
        {
            try
            {
                _switcher.SetPin(pin, on);
                return string.Format("Set pin {0} to {1}", pin, on);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
