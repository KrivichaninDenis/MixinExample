using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MixinExample
{
    public static class AddMethod
    {
        private static readonly Dictionary<Type, Func<Storage>> Dictionary;
          
        private static Exception _initException;

       

        static AddMethod()
        {
            try
            {
                var pFacts = Assembly.GetExecutingAssembly()
                                     .GetTypes()
                                     .Select(t => new { Type = t, Attribute = (ClassType)t.GetCustomAttributes(typeof(ClassType), false).SingleOrDefault() })
                                     .Where(obj => obj.Attribute != null).ToArray();

                foreach (var type in pFacts.Select(obj => obj.Attribute.TypeClass).Distinct())
                   

                    Dictionary = pFacts.ToDictionary(obj => obj.Attribute.TypeClass, obj => new Func<Storage>(() => (Storage)Activator.CreateInstance(obj.Type)));
            }
            catch (Exception ex)
            {
                _initException = ex;
            }

        }
        public static void OutPrice(this Auto a)
        {
            Get(a.GetType()).OutPrice(a);
        }

        private static Storage Get(Type autoType)
        {           
            return Dictionary[autoType]();
        }
    }
}

