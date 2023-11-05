using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class circle : Geometri
    {
        public double Radius { get; set; }

        public circle() 
        
        {
            Radius = 1.0;
        
        
        }

        public override double Aera()
        {
            return Math.PI * Math.Pow(Radius, 2);

        }

        

    }
}
