using System;
namespace DesignPatterns.Patterns.Behavioral.Visitor
{
    /// <summary>
    /// must provide implementation of Visit for every Component that allows it to visit that exact class
    /// </summary>
	public interface IVisitor
	{
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}

