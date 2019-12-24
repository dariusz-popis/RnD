using DesignPatterns.SOLID.I_InterfaceSegregation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.SOLID.Tests.I_InterfaceSegregation
{
    [TestClass]
    public class InterfaceAdventagesTests
    {
        #region Base and Child without interface
        [TestMethod]
        public void BaseClass_VirtualMethod_Invoking()
        {
            var bc = new BaseClass();
            bc.VirtualMethod();
        }

        [TestMethod]
        public void BaseClassVariableObjectIsChildClass_VirtualMethod_Invoking()
        {
            BaseClass bc = new ChildClass();
            bc.VirtualMethod();
        }

        [TestMethod]
        public void ChildClass_VirtualMethod_Invoking()
        {
            var bc = new ChildClass();
            bc.VirtualMethod();
        }
        #endregion

        #region Base and Child with interface
        [TestMethod]
        public void BaseClassWithInterface_VirtualMethod_Invoking()
        {
            IBaseClassWithInterface bc = new BaseClassWithInterface();
            bc.NonVirtualMethod();
        }

        [TestMethod]
        public void ChildClassWithInterface_VirtualMethod_Invoking()
        {
            IBaseClassWithInterface bc = new ChildClassWithInterface();
            bc.NonVirtualMethod();
        }
        #endregion
    }
}
