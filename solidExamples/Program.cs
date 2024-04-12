// See https://aka.ms/new-console-template for more information
using solidExamples.DependencyInversionPrinciple;
using solidExamples.SingleResponsability;
using solidExamples.OpenClose;
using solidExamples.LiskovSubstitution;
using solidExamples.InterfaceSegregation;


static void MakeItAccelerate(Vehicle vehicle)
{
    vehicle.Accelerate();
}

Vehicle car = new Car();
Vehicle bicycle = new Bicycle();

MakeItAccelerate(car);
MakeItAccelerate(bicycle);

PayPal payPal = new PayPal();
Store store = new Store(payPal);
store.Buy();

Console.WriteLine("Hello, World!");
