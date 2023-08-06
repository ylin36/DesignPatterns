using System;
namespace DesignPatterns.Patterns.Behavioral.Strategy
{
	public class Context
	{
		private IStrategy _strategy;

		public Context(IStrategy strategy)
		{
			_strategy = strategy;
		}

		/// <summary>
		/// Allow hot swapping strategy at runtime
		/// </summary>
		/// <param name="strategy"></param>
		public void SetStrategy(IStrategy strategy)
		{
			_strategy = strategy;
		}

		/// <summary>
		/// Delegate some work to strategy instead of implementing own
		/// </summary>
		public List<string> BusinessSortOperation(List<string> values)
		{
			if (values != null && values.Count > 1)
				return _strategy.PerformSortAlgorithm(values);
			return values;
		}
	}
}

