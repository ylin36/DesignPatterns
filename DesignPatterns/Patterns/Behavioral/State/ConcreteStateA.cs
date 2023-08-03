using System;
namespace DesignPatterns.Patterns.Behavioral.State
{
	public class ConcreteStateA : State
	{
        public override void Handle1()
        {
            Console.WriteLine("StateA Handle 1");
            // Output can happen here or during constructor of the State depending if its mealy or moore
            _context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("StateA Handle 2");
            // basically can do nothing if it doesn't take this input
        }
    }
}

