using System;
namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	public class ConcreteComponentB : IComponent
	{
		public ConcreteComponentB()
		{
		}

        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public void ComponentBMethod()
        {
            Console.WriteLine("ComponentBMethod");
        }
    }
}

