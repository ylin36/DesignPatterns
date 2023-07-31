using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public interface IWings
	{
		public void Deploy();
		public bool IsDeployed { get; }
	}
}

