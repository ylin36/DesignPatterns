using System.Collections;

namespace DesignPatterns.Patterns.Behavioral.Iterator
{
	public abstract class Iterator : IEnumerator 
	{
		public Iterator()
		{
		}

		/// <summary>
		/// return the current element
		/// </summary>
		/// <returns></returns>
		public abstract object Current();

		/// <summary>
		/// move iterator to next element
		/// </summary>
		/// <returns></returns>
        public abstract bool MoveNext();

		/// <summary>
		/// rewind iterator to first element
		/// </summary>
		public abstract void Reset();

        /// <summary>
		/// NOT PART OF IEnumerator
        /// return key of the current element
        /// </summary>
        /// <returns></returns>
        public abstract int Key();
    }
}

