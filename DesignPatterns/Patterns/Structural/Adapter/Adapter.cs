using System;
namespace DesignPatterns.Patterns.Structural.Adapter
{
	/// <summary>
	/// The adapter will implement the interface that the adaptee does not implement, to help it 'adapt'
	/// </summary>
	public class Adapter : ITarget
	{
		private readonly Adaptee _adaptee;
		public Adapter(Adaptee adaptee)
		{
			_adaptee = adaptee;
		}

		public string GetRequest()
		{
			return "executed " + _adaptee.GetSpecificRequest();
		}
	}
}

