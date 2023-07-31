using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
	public abstract class AircraftBuilder
	{
		public AircraftBuilder()
		{
		}

		public virtual void BuildEngine()
		{
			// Method is virtual so that it does not force
			// implementors to implement it when they dont need it
		}

		public virtual void BuildWings()
		{

		}
		
		public virtual void BuildCockpit()
		{

		}

		public virtual void BuildBathroom()
		{

		}

		abstract public IAircraft GetResult();
	}
}

