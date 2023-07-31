using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
	public class Director
	{
		private readonly AircraftBuilder _aircraftBuilder;
		public Director(AircraftBuilder aircraftBuilder)
		{
			_aircraftBuilder = aircraftBuilder;
		}

		public void Construct(bool isPassenger)
		{
			_aircraftBuilder.BuildCockpit();
			_aircraftBuilder.BuildEngine();
			_aircraftBuilder.BuildWings();
			if (isPassenger)
				_aircraftBuilder.BuildBathroom();
		}
	}
}

