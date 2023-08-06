using System;
namespace DesignPatterns.Patterns.Behavioral.Strategy
{
	public interface IStrategy
	{
		List<string> PerformSortAlgorithm(List<string> values);
    }
}

