using System;
using DesignPatterns.Patterns.Structural.Proxy;
using Microsoft.Extensions.Logging;
using Moq;
namespace DesignPatternsTest
{
    public class ProxyTest
    {
        [Fact]
        public void Test1()
        {
            var logger = new Mock<ILogger<F16Controller>>();
            // assigning to the interface to showcase these implement the same interface and can pass for each other
            IAircraft realF16 = new F16();
            IAircraft f16Controller = new F16Controller(realF16, logger.Object);
            f16Controller.Fly("New York");
        }
    }
}

