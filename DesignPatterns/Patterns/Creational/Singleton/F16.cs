using System;
namespace DesignPatterns.Patterns.Creational.Singleton
{
    // singleton safe for single threaded apps.
    // for multi threaded singleton instantialization, see the best practice for initializing singleton
	public class F16
	{
        private static F16 _instance;

		private F16()
		{

		}
        public int Fly(string destination)
        {
            return destination.Length * 2;
        }

        public static F16 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new F16();
                return _instance;
            }
        }
    }
}

