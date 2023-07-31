using System.Collections;
namespace DesignPatterns.Patterns.Behavioral.Iterator
{
	public abstract class IteratorAggregate : IEnumerable
	{
		public IteratorAggregate()
		{
		}

		public abstract IEnumerator GetEnumerator();
    }
}

