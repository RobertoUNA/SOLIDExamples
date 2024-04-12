using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidExamples.InterfaceSegregation
{
    public interface IWorkable
    {
        public void Work();
    }
}
public interface IEatable
    {
        public void Eat();
    }

    public interface ISleepable
    {
        public void Sleep();
    }
    public class HumanWorker : IWorkable, IEatable, ISleepable
    {
        public void Work() { }
        public void Eat() { }
        public void Sleep() { }
    }

    public class RobotWorker : IWorkable
    {
        public void Work() { }
    }
}
