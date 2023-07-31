using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
	public class F16 : IAircraft
	{
		public string Engine { get; set; } = string.Empty;
		public string Cockpit { get; set; } = string.Empty;
		public string Wings { get; set; } = string.Empty;

		public int Fly(string destination)
		{
			return destination.Length * 2;
		}

	}
}

