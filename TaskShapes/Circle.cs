using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cir.TaskShapes
{
    public class Circle: Shape
    {
        private static double P = 3.14;
        private double Diameter {  get; set; }
        public Circle(double diameter)
        {
            Diameter = diameter;
        }
        private double GetRadius(double diameter) => diameter / 2;
        public override double GetArea()=>P*Math.Pow(GetRadius(Diameter),2);
    }
}
