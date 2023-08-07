using System;
namespace DesignPatterns.Patterns.Structural.Facade
{
	public class Facade
	{
		protected Subsystem1 _subsystem1;
		protected Subsystem2 _subsystem2;
		public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
		{
			(_subsystem1, _subsystem2) = (subsystem1, subsystem2);
		}

        /// <summary>
        /// The Facade's methods are convenient shortcuts to the sophisticated
        /// functionality of the subsystems. However, clients get only to afraction of a subsystem's capabilities.
        /// </summary>
        /// <returns></returns>
        public string Operation()
		{
			return _subsystem1.Operation1() + _subsystem1.Operation2() + _subsystem2.Operation1() + _subsystem2.Operation2();
		}
	}
}

