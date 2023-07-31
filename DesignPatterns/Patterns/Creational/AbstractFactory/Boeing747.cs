using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class Boeing747 : IAircraft
	{
		private IWings _wings;
		private IEngine _engine;
		private ICockpit _cockpit;

		public Boeing747(IAircraftFactory aircraftFactory)
		{
			_wings = aircraftFactory.CreateWings();
			_engine = aircraftFactory.CreateEngine();
			_cockpit = aircraftFactory.CreateCockpit();
		}

		public int Fly(string destination)
		{
			_engine.Start();
			_cockpit.Close();
			_wings.Deploy();

			if (_engine.IsOn && !_cockpit.IsOpen && _wings.IsDeployed)
				return destination.Length;
			return 0;
		}
	}
}

