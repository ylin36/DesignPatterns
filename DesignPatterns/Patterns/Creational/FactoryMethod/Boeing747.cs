using System;
namespace DesignPatterns.Patterns.Creational.FactoryMethod
{
	public class Boeing747 : Aircraft
	{
		public Boeing747()
		{
		}

        public override IEngine CreateEngine()
        {
            return new Boeing747Engine();
        }
    }
}

