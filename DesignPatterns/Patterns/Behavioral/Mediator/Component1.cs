using System;
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	public class Component1 : BaseComponent
	{
		public Component1()
		{
		}

		/// <summary>
		/// I made this method virtual purely to run unit test against it.
		/// Since Moq basically creates proxies, the base method must be virtual to override it.
		/// </summary>
		public virtual void DoA()
		{
			Console.WriteLine("A");
			_mediator.Notify(this, "A");
		}

		public virtual void DoB()
		{
			Console.WriteLine("B");
			_mediator.Notify(this, "B");
		}
	}
}

