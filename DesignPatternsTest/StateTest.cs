using System;
using DesignPatterns.Patterns.Behavioral.State;
namespace DesignPatternsTest
{
	public class StateTest
	{
        [Fact]
        public void Test1()
        {
            var context = new Context(new ConcreteStateA());

            // input A. State machine does something.. maybe transitions to a different state
            context.Request1();

            // input B
            context.Request2();
        }
    }
}

