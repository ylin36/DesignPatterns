using System;
using DesignPatterns.Patterns.Structural.Facade;

namespace DesignPatternsTest
{
	public class FacadeTest
    {
        [Fact]
        public void Test1()
        {
            var facade = new Facade(new Subsystem1(), new Subsystem2());
            Assert.Equal("1234", facade.Operation());
        }
    }
}

