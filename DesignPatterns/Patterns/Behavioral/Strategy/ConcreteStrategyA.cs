using System;
namespace DesignPatterns.Patterns.Behavioral.Strategy
{
	public class ConcreteStrategyA : IStrategy
	{
		public ConcreteStrategyA()
		{
		}

        public List<string> PerformSortAlgorithm(List<string> values)
        {
            return values.Order().ToList();
        }
    }
}

