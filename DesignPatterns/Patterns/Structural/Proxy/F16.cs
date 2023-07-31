using System;
namespace DesignPatterns.Patterns.Structural.Proxy
{
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

