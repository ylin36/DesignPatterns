using System;
namespace DesignPatterns.Patterns.Behavioral.Observer
{
	public class ConcreteObserverA : IObserver
	{
		public ConcreteObserverA()
		{
		}

        public void Update(ISubject subject)
        {
            Console.WriteLine((subject as ConcreteSubject)?.SomeState);
        }
    }
}

