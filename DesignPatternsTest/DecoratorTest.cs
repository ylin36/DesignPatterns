using System;
using DesignPatterns.Patterns.Structural.Decorator;
namespace DesignPatternsTest
{
    public class DecoratorTest
    {
        [Fact]
        public void Test1()
        {
            // assigning to the interface to showcase these implement the same interface and can pass for each other
            IAircraft boeing747 = new Boeing747();
            IAircraft luxuryTrim = new LuxuryTrim(boeing747);

            luxuryTrim.Fly("New York");
        }
    }
}

