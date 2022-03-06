using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RombMeselesi
{
    abstract class Quadrangular
    {
        public double a;
        public double b;
        public double c;
        public double d;


        public Quadrangular(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double Perimeter()
        {
            return a + b + c + d;
        }

        public abstract double Area();
        
    }

}
