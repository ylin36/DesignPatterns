using System;
namespace DesignPatterns.Patterns.Behavioral.Observer
{
	public interface IObserver
	{
		/// <summary>
		/// doesn't have to be ISubject type in the update method, can be anything.
		/// same concept goes with interface names, they can be anything that makes sense
		/// </summary>
		/// <param name="subject"></param>
		void Update(ISubject subject);
	}
}

