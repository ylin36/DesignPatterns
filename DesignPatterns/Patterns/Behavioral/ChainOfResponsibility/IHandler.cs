using System;
namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	public interface IHandler
	{
		IHandler SetNext(IHandler handler);

		object Handle(object request);
	}
}

