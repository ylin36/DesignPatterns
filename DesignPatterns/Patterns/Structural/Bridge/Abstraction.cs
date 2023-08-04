using System;
namespace DesignPatterns.Patterns.Structural.Bridge
{
	public class Abstraction
	{
		protected IImplementation _implementation;

		public Abstraction(IImplementation implementation)
		{
			_implementation = implementation;
		}

		public virtual string Operation()
		{
			// delegate real work to the implementation
			return _implementation.OperationImplementation();
		}


	}
}

