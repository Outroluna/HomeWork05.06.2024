using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri.TaskShapes
{
    public class Triangle : Shape
    {
        private double Side { get; set; }
        private double Height { get; set; }
        public Triangle(double side, double height) 
        {
            Side = side;
            Height = height;
        }
        public override double GetArea() => (Side * Height)/2;
    }
}
