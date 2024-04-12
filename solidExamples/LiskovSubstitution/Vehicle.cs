using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidExamples.LiskovSubstitution
{
    
    public class Vehicle
    {
        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating...");
        }
    }

    public class Car : Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating the car...");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating the bicycle...");
        }
    }
}
