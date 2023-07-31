using System;
using System.Collections;

namespace DesignPatterns.Patterns.Behavioral.Iterator
{
	public class WordCollection : IteratorAggregate
	{
        List<string> _collection = new List<string>();
		bool _direction = false;

        public WordCollection()
		{
		}

		public void ReverseDirection()
		{
			_direction = !_direction;
		}

		public List<string> Items => _collection;

		public void AddItem(string item)
		{
			_collection.Add(item);
		}

		/// <summary>
		/// returns a new iterator that can act on the current aggregate's state
		/// </summary>
		/// <returns></returns>
        public override IEnumerator GetEnumerator()
        {
			// obviously cannot use DI here for iterator because of circular dependency
			return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}

