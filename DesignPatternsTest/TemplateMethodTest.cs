using System;
using DesignPatterns.Patterns.Behavioral.TemplateMethod;
namespace DesignPatternsTest
{
    public class TemplateMethodTest
    {
        [Fact]
        public void Test1()
        {
            var concreteClassA = new ConcreteClassA();
            Assert.Equal("1, 2, a, b, , ", concreteClassA.TemplateMethod());

            var concreteClassB = new ConcreteClassB();
            Assert.Equal("1, 2, c, d, e, ", concreteClassB.TemplateMethod());
        }
    }
}

