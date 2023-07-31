namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class Boeing747Factory : IAircraftFactory
	{
		public Boeing747Factory()
		{
			
		}

		public IWings CreateWings()
		{
			return new Boeing747Wings();
		}

		public IEngine CreateEngine()
		{
			return new Boeing747Engine();
		}

		public ICockpit CreateCockpit()
		{
			return new Boeing747Cockpit();
		}
		 
	}
}

