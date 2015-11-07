using System;

namespace MixinExample
{
    [ClassType((typeof(Auto)))]
    class Storage//обработчик
    {
        public void OutPrice(Auto a)
        {
            Console.WriteLine("Auto Price: "+a.Price);
        }
    }
}
