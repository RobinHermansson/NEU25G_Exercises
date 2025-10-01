using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Circle: Shape
    {
        public double Radius { get; }
        public override double Area => Math.PI * Radius * Radius;
        public override double Circumference => Math.PI * (Radius * 2);

        public Circle (double radius)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius {Radius}";
        }
    }
}
