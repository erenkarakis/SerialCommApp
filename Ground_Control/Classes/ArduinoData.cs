using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ground_Control.Classes
{
    public class ArduinoData
    {
        public double Battery { get; set; }
        public int Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }

    }
}
