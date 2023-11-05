using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class square :Geometri
    {
        public double SideLenght { get; set; }
    
        public square()
        {
            SideLenght = 7;

        }


        public override double Aera()
        {
            return SideLenght + SideLenght;
        }

    }

    
}


