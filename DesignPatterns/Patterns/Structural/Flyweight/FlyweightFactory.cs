using System;
namespace DesignPatterns.Patterns.Structural.Flyweight
{
	public class FlyweightFactory
	{
		private List<Tuple<Flyweight, string>> _flyweights = new List<Tuple<Flyweight, string>>();
		public FlyweightFactory(params Car[] args)
		{
			foreach (var arg in args)
			{
				_flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(arg), GetKey(arg)));
			}
		}

		public string GetKey(Car key)
		{
			var elements = new List<string>()
			{
				key.Model, key.Color, key.Company
			};

			if (key.Owner is not null && key.Number is not null)
			{
				elements.Add(key.Owner);
				elements.Add(key.Number);
			}
			// sort elements to be preditable
			elements.Sort();
			// use a simple hashing algo to create the key based on contents
			return string.Join("_", elements);
		}

		/// <summary>
		/// return an existing flyweight if it exists or create a new one
		/// </summary>
		/// <param name="sharedState"></param>
		/// <returns></returns>
		public Flyweight GetFlyweight(Car sharedState)
		{
			var key = GetKey(sharedState);
			var result = _flyweights.Where(tuple => tuple.Item2 == key);

            if (result.Count() == 0)
			{
				var flyweight = new Flyweight(sharedState);

                _flyweights.Add(new Tuple<Flyweight, string>(flyweight, GetKey(sharedState)));
				return flyweight;

            }
			return result.First().Item1;
        }

		public void ListFlyWeights()
		{
			_flyweights.ForEach(f => Console.WriteLine(f.Item2));
		}
	}
}

