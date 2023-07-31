using System;
namespace DesignPatterns.Patterns.Structural.Adapter
{
	/// <summary>
	/// 
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

