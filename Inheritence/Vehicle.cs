using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Vehicle
    {
        public Brand Brand { get; set; }
        public Color Color { get; set; }

        public Vehicle (Brand brand, Color color)
        {
            Brand = brand;
            Color = color;
        }

        public Vehicle (Brand brand)
        {
            Brand = brand;
            Color = Color.Gold;
        }

        public override string ToString()
        {
            return $"This vehicle is a {Color} {Brand}";
        }
    }
}
