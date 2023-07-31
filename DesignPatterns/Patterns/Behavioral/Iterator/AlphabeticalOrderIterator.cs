using System;
namespace DesignPatterns.Patterns.Behavioral.Iterator
{
	public class AlphabeticalOrderIterator : Iterator
	{
		private WordCollection _wordCollection;
		private bool _reverse;
        private int _position;

		/// <summary>
		/// cannot take an interface here. this needs the actual wordcollection to iterate through it
		/// </summary>
		/// <param name="wordCollection"></param>
		public AlphabeticalOrderIterator(WordCollection wordCollection, bool reverse = false)
		{
			_wordCollection = wordCollection;
			_reverse = reverse;
            Reset();
		}

        public override object Current => _wordCollection.Items[_position];

        public override int Key()
        {
			return _position;
        }

        public override bool MoveNext()
        {
			var newPosition = _reverse ? _position - 1 : _position + 1;
			if (newPosition >= 0 && newPosition < _wordCollection.Items.Count)
			{
				_position = newPosition;
				return true;
			}
			else
			{
				return false;
			}
        }

        /// <summary>
        /// Enumerators are positioned before the first element
        /// until the first MoveNext() call.
        /// </summary>
        public override void Reset()
        {
            _position = _reverse ? _wordCollection.Items.Count : -1;
        }
    }
}

