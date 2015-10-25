using MixinExample.Interface;

namespace MixinExample
{
    class Auto:AutoPrice, ISomeInterface
    {              
        public Auto( int p)
        {        
            Price = p;
        }            
    }
}
