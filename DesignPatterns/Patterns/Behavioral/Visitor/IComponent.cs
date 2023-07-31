using System;
namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	public interface IComponent
	{
		void Accept(IVisitor visitor);

	}
}

