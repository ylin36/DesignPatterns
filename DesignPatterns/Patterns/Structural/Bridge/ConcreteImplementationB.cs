using System;
namespace DesignPatterns.Patterns.Structural.Bridge
{
	public class ConcreteImplementationB : IImplementation
	{
		public ConcreteImplementationB()
		{
		}

        public string OperationImplementation()
        {
            return "Concrete Implementation B";
        }
    }
}

