using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidExamples.SingleResponsability
{
    public class Rectangle
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class PerimeterOperations
    {
        public static double Sum(IEnumerable<Rectangle> rectangles)
        {
            return 0.0;
        }
    }

    public class AreaOperations
    {
        public static double Sum(IEnumerable<Rectangle> rectangles)
        {
            return 0.0;
        }

    }

}





