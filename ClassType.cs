using System;

namespace MixinExample
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    class ClassType:Attribute//для связки функции-примеси с обьектом класса Auto
    {
        public Type TypeClass { get; private set; }

        public ClassType(Type boundClass)
        {
            if (boundClass != typeof(Auto) ) 
                throw new ApplicationException("Class must be subclass of Auto");
            TypeClass = boundClass;
        }
    }
}
