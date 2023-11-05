using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }
        

        public Rectangle()
        {
            Width = 6;
            Height = 3;

        }

        public override double Aera()
        {
            return Width * Height;
        }

    }
}
