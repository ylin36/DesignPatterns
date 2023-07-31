using System;
namespace DesignPatterns.Patterns.Structural.Decorator
{

    /// <summary>
    /// Q: why even have a base decorator class instead of having decorators implement IAircraft Directly?
    /// A:The base Decorator makes it easier to create additional decorators.
	/// Imagine that Beverage has dozens of abstract methods, or is an interface, say stir(), getTemperature(), drink(), pour() and the like.
	/// Then your decorators all have to implement these methods for no other reason than to delegate them to the wrapped beverage,
	/// and your MilkyBeverage and SpicyBeverage each have all those methods.
	/// 
	/// https://stackoverflow.com/questions/2016765/decorator-pattern-why-do-we-need-an-abstract-decorator#:~:text=Using%20the%20abstract%20decorator%20implementation,decorator%20class%20implementation%20per%20decoration.&text=The%20base%20Decorator%20makes%20it%20easier%20to%20create%20additional%20decorators.
    /// </summary>
    public abstract class Boeing747Decorator : IAircraft
	{
		public Boeing747Decorator()
		{
		}

		public abstract int Fly(string destination);
	}
}

