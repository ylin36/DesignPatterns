using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
	public interface IAircraft
	{
		/// <summary>
		/// Flies the aircraft to the destination
		/// </summary>
		/// <returns>Number of km flew</returns>
		int Fly(string destination);
	}
}

