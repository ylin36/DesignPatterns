using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public interface IEngine
	{
		void Start();
		bool IsOn { get; }
	}
}

