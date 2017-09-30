using System;
using pi_dotnetcore.Gpio;

namespace pi_service.Models
{
    public class PinModel : IPin
    {
        public int number { get; set; }
        public bool output { get; set; }
        public bool on { get; set; }
    }
}