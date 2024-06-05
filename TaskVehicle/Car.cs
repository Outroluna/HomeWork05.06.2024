using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.TaskVehicle
{
    public class Car: Vehicle
    {
        protected string model;
        public Car(string model, int speed, int capacity): base(speed, capacity)
        { 
            this.model = model;
        }
    }
}
