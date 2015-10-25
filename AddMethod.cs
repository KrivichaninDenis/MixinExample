using System.Runtime.CompilerServices;
using MixinExample.Interface;

namespace MixinExample
{
    public static class AddMethod
    {
         static readonly ConditionalWeakTable<ISomeInterface, NewElement> Dictionary =
            new ConditionalWeakTable<ISomeInterface, NewElement>();


        public class NewElement
        {
            public int Number;
            public string Model;
        }

        public static void AddNumber(this ISomeInterface someInterface, int someNumber)
        {
            Dictionary.GetOrCreateValue(someInterface).Number  = someNumber;
        }

        public static int OutNumber(this ISomeInterface someInterface)
        {
            return Dictionary.GetOrCreateValue(someInterface).Number;
        }

        public static void AddModel(this ISomeInterface someInterface, string someModel)
        {
            Dictionary.GetOrCreateValue(someInterface).Model = someModel;
        }

        public static string OutModel(this ISomeInterface someInterface)
        {
            return Dictionary.GetOrCreateValue(someInterface).Model;
        }
    }
}

