using System;

namespace DesignPatterns.SOLID.I_InterfaceSegregation
{
    internal class BaseClassWithInterface : IBaseClassWithInterface
    {
        public virtual void NonVirtualMethod()
        {
            Console.WriteLine("VirtualMethod() from class BaseClassWithInterface");
        }
    }
}
