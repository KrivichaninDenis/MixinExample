using System;
using MixinExample.Interface;

namespace MixinExample
{
    class Program
    {
        static void Main()
        {
            var bmw=new Auto(30000);
            bmw.AddNumber(123456);
            bmw.AddModel("BMW");


            var lada=new Auto(5000);
            lada.AddModel("Lada");
            lada.AddNumber(666);

            Console.WriteLine("Car " + bmw.OutModel() + " costs " + bmw.Price + ", Car number: " + bmw.OutNumber());
            Console.WriteLine("Car " + lada.OutModel() + " costs " + lada.Price + ", Car number: " + lada.OutNumber());
        }
    }
}
