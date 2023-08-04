using System;
namespace DesignPatterns.Patterns.Structural.Bridge
{
    /// <summary>
    /// (Optional)
    /// abstraction can also be extended without changing the IImplementation class
    /// </summary>
	public class ExtendedAbstraction : Abstraction
	{
		public ExtendedAbstraction(IImplementation implementation) : base(implementation)
		{
		}

        public override string Operation()
        {
            // delegate real work to the implementation
            return base.Operation();
        }
    }
}

