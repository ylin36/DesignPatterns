using System;
namespace DesignPatterns.Patterns.Behavioral.Observer
{
	/// <summary>
	/// Also known as Observable in Java
	/// </summary>
	public interface ISubject
	{
		/// <summary>
		/// Subscribe
		/// </summary>
		/// <param name="observer"></param>
		void Attach(IObserver observer);

		/// <summary>
		/// Unsubscribe
		/// </summary>
		/// <param name="observer"></param>
		void Detach(IObserver observer);

		/// <summary>
		/// Notify all attached / subscribed observers
		/// </summary>
		void Notify();
	}
}

