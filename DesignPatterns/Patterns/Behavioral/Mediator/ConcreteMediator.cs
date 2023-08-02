using System;
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	public class ConcreteMediator : IMediator
	{
        private Component1 _component1;
        private Component2 _component2;

        /// <summary>
        /// mediator may have all concrete components register to it instead of interface
        /// </summary>
        /// <param name="component1"></param>
        /// <param name="component2"></param>
		public ConcreteMediator(Component1 component1, Component2 component2)
		{
            (_component1, _component2) = (component1, component2);
            _component1.SetMediator(this);
            _component2.SetMediator(this);
		}

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Reacting to event A, triggering Event C");
                _component2.DoC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Reacting to event D, triggering Event B and Event Cß");
                _component1.DoB();
                _component2.DoC();
            }
        }
    }
}

