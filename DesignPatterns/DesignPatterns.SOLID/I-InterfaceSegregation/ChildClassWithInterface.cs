using System;

namespace DesignPatterns.SOLID.I_InterfaceSegregation
{
    internal class ChildClassWithInterface : BaseClassWithInterface, IBaseClassWithInterface
    {
        public override void NonVirtualMethod()
        {
            Console.WriteLine("VirtualMethod() from class ChildClassWithInterface");
        }
    }
}
