using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RombMeselesi
{
    class Romb : Quadrangular
    {

        double height;
        public Romb(double a, double b, double c, double d, double height)
            : base(a, a, a, a)
        {
            this.height = height;
        }

        public override double Area()
        {
            return a * height;
        }

        
    }
}
