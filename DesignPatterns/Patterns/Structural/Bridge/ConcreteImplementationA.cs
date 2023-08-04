using System;
namespace DesignPatterns.Patterns.Structural.Bridge
{
	public class ConcreteImplementationA : IImplementation
	{
		public ConcreteImplementationA()
		{
		}

        public string OperationImplementation()
        {
            return "Concrete Implementation A";
        }
    }
}

