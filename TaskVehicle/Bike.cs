using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bik.TaskVehicle
{
    public class Bike: Vehicle
    {
        public string type;
        public Bike(string type, int speed, int capacity):base (speed, capacity)
        {
            this.type = type;
        }
    }
}
