using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inheritence
{
    public class Car: Vehicle
    {
        public string Model { get; set; }
        public Car (Brand brand, string model, Color color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }
        public override string ToString()
        {
            return $"A {Color} {Model} from {Brand}";
        }
    }
}
