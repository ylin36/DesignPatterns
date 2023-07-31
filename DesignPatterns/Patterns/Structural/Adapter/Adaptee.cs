using System;
namespace DesignPatterns.Patterns.Structural.Adapter
{
	/// <summary>
	/// Existing code that contains methods, but its not compatible with the interface ITarget.
	/// </summary>
	public class Adaptee
	{
		public Adaptee()
		{
		}

		public string GetSpecificRequest()
		{
			return "specific request";
		}
	}
}

