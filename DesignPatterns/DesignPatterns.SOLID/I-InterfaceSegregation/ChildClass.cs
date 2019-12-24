using System;

namespace DesignPatterns.SOLID.I_InterfaceSegregation
{
    internal class ChildClass : BaseClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("VirtualMethod() from class ChildClass");
        }
    }
}
