using System;
namespace DesignPatterns.Patterns.Creational.FactoryMethod
{
	public abstract class Aircraft
	{
		public Aircraft()
		{
		}

		/// <summary>
		/// override this to provide different engine
		/// </summary>
		/// <returns></returns>
		public abstract IEngine CreateEngine();

		public int Fly(string destination)
		{
			var engine = CreateEngine();

			if (engine.Start())
				return destination.Length;
			return 0;
		}

	}
}

