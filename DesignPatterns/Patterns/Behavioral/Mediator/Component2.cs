using System;
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	public class Component2 : BaseComponent
	{
		public Component2()
		{
		}

		public virtual void DoC()
		{
			Console.WriteLine("C");
			_mediator.Notify(this, "C");
		}

		public virtual void DoD()
		{
			Console.WriteLine("D");
			_mediator.Notify(this, "D");
		}
	}
}

