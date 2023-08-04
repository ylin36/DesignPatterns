using System;
namespace DesignPatterns.Patterns.Behavioral.Observer
{
	public class ConcreteObserverB : IObserver
	{
		public ConcreteObserverB()
		{
		}

        public void Update(ISubject subject)
        {
            Console.WriteLine((subject as ConcreteSubject)?.SomeState);
        }
    }
}

