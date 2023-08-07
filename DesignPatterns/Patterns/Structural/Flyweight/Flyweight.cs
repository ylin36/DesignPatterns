using System;
using System.Text;
using System.Text.Json;

namespace DesignPatterns.Patterns.Structural.Flyweight
{
	public class Flyweight
	{
		private Car _sharedState;

		public Flyweight(Car car)
		{
			_sharedState = car;
		}

		public void Operation(Car uniqueState)
		{
			string s = JsonSerializer.Serialize(_sharedState);
			string u = JsonSerializer.Serialize(uniqueState);
			Console.WriteLine($"Serialized shared state {s} and unique state {u}");
        }

	}
}

