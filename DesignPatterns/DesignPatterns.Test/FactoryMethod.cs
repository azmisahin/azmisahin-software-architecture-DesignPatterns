using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DesignPatterns.CreationalPatterns.FactoryMethod;
namespace DesignPatterns.Test
{
    [TestClass]
    public class FactoryMethod
    {
        [TestMethod]
        public void FactoryMethodTest()
        {
            Creator[] creator = new Creator[2];
            creator[0] = new Create();
            creator[1] = new Create();
            
            Assert.IsNotNull(creator);
        }
    }
}
