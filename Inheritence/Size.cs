using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public struct Size
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Length { get; set; }

        public Size (int length, int width, int height)
        {

            Length = length;
            Width = width;
            Height = height;

        }
    }
}
