using System;
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	public interface IMediator
	{
		void Notify(object sender, string ev);
	}
}

