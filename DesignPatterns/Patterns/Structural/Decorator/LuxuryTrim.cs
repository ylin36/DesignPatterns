using System;
namespace DesignPatterns.Patterns.Structural.Decorator
{
	public class LuxuryTrim : Boeing747Decorator
	{
		private IAircraft _boeing;

        /// <summary>
        /// Pass in boeing runtime object to decorate / override it
        /// Still use interface segregation even though you're decorating boeing.
        /// </summary>
        /// <param name="boeing"></param>
		public LuxuryTrim(IAircraft boeing) // 
		{
			_boeing = boeing;
        }

        public override int Fly(string destination)
        {
            return _boeing.Fly(destination) * 2;
        }
    }
}

