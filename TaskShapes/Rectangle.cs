using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec.TaskShapes
{
    public class Rectangle : Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea() => Width * Height;
    }

}
