using System;
namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	public class ConcreteVisitor2 : IVisitor
	{
		public ConcreteVisitor2()
		{
		}

        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            element.ComponentAMethod();
            Console.WriteLine("Executed ComponentAMethod from Visitor2");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            element.ComponentBMethod();
            Console.WriteLine("Executed ComponentBMethod from Visitor2");
        }
    }
}

