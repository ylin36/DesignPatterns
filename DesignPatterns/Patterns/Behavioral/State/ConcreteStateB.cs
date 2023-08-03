using System;
namespace DesignPatterns.Patterns.Behavioral.State
{
	public class ConcreteStateB : State
	{
        public override void Handle1()
        {
            Console.WriteLine("StateB handle 1");
        }

        public override void Handle2()
        {
            Console.WriteLine("StateA handle 2");
            _context.TransitionTo(new ConcreteStateA());
        }
    }
}

