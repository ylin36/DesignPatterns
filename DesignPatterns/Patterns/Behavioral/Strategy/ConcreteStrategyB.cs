using System;
namespace DesignPatterns.Patterns.Behavioral.Strategy
{
	public class ConcreteStrategyB : IStrategy
	{
		public ConcreteStrategyB()
		{
		}

        public List<string> PerformSortAlgorithm(List<string> values)
        {
            return values.OrderDescending().ToList();
        }
    }
}

