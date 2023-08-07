using System;
using DesignPatterns.Patterns.Structural.Bridge;
namespace DesignPatternsTest
{
    public class BridgeTest
    {
        [Fact]
        public void Test1()
        {
            var abstraction = new Abstraction(new ConcreteImplementationA());
            Assert.Equal("Concrete Implementation A", abstraction.Operation());
        }

        [Fact]
        public void Test2()
        {
            var abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            Assert.Equal("Concrete Implementation B", abstraction.Operation());
        }
    }
}

