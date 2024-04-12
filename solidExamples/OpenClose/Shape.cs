using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidExamples.OpenClose
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Rectangle : Shape
    { 
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width*Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
     
        public override double Area()
        {
            return Radius*Radius*3.14;
        }
    }
}

