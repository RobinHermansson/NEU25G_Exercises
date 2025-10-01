using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Circumference { get; }

        public void Print()
        {
            // Use ToString() which is overridden in each derived class
            // to get the specific description (like "A Circle with radius 4.5")
            string description = ToString();
            
            // Format the area and circumference with 2 decimal places
            Console.WriteLine($"{description} has an area of {Area:F2} and a circumference of {Circumference:F2}.");
        }
    }   
}
