using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class F16 : IAircraft
	{
		private IWings _wings;
		private IEngine _engine;
		private ICockpit _cockpit;
		public F16(IAircraftFactory aircraftFactory)
		{
			(_wings, _engine, _cockpit) =
				(aircraftFactory.CreateWings(), aircraftFactory.CreateEngine(), aircraftFactory.CreateCockpit());
			
		}

		public int Fly(string destination)
		{
			_engine.Start();
			_cockpit.Close();
			_wings.Deploy();
			if (_engine.IsOn && !_cockpit.IsOpen && _wings.IsDeployed)
				return destination.Length * 2;
			return 0;
		}
	}
}

