using System;
namespace DesignPatterns.Patterns.Structural.Decorator
{
	public class Boeing747 : IAircraft
	{
		public Boeing747()
		{
		}

		public int Fly(string destination)
		{
			return destination.Length;
		}
	}
}

