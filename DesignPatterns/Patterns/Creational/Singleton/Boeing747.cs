// this is a thread safe singleton creation

// https://csharpindepth.com/Articles/Singleton
// There is a double lock checking one, but doesn't work in languages like java without quirks.

namespace DesignPatterns.Patterns.Creational.Singleton
{
	public sealed class Boeing747
	{
		private Boeing747()
		{
		}

		public static Boeing747 Instance
		{
			get
			{
				return Nested.instance;
			}
		}

		private class Nested
		{
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
			{
                // Static constructor is called at most one time, before any
                // instance constructor is invoked or member is accessed.
            }

            internal static readonly Boeing747 instance = new Boeing747(); 
		}
	}
}

