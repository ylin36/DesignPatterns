using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public interface IAircraftFactory
	{
		IEngine CreateEngine();

		ICockpit CreateCockpit();

		IWings CreateWings();
	}
}

