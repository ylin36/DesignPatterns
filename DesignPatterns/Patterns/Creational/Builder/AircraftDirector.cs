using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
	public class AirCraftDirector
	{
		private readonly AircraftBuilder _aircraftBuilder;
		public AirCraftDirector(AircraftBuilder aircraftBuilder)
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

