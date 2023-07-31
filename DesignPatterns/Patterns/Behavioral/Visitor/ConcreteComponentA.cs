using System;
namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	public class ConcreteComponentA : IComponent
	{
		public ConcreteComponentA()
		{
		}

		public void Accept(IVisitor visitor)
		{
			visitor.VisitConcreteComponentA(this);
		}

		public void ComponentAMethod()
		{
			Console.WriteLine("ComponentAMethod");
		}
	}
}

