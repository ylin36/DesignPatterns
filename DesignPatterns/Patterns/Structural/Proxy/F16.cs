using System;
namespace DesignPatterns.Patterns.Structural.Proxy
{
	/// <summary>
	/// real class implement same interface as the proxy
	/// </summary>
	public class F16 : IAircraft
	{
		public F16()
		{
		}

		public int Fly(string destination)
		{
			return destination.Length;
		}
	}
}

