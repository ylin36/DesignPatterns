using System;
namespace DesignPatterns.Patterns.Behavioral.Observer
{
	public class ConcreteSubject : ISubject
	{
        private readonly List<IObserver> _observers;

        public int SomeState = -1;

		public ConcreteSubject()
		{
            _observers = new List<IObserver>();
		}

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            // notify state changed, so observers can go check the state
            _observers.ForEach(o => o.Update(this));
        }

        public void GoToNextState()
        {
            SomeState = (SomeState + 1) % 10;

            // trigger state changed from this method
            Notify();
        }
    }
}

