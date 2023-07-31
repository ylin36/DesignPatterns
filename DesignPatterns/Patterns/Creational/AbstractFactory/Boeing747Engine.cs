using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class Boeing747Engine : IEngine
	{
		private bool _started;
		public Boeing747Engine()
		{

		}

		public void Start()
		{
			_started = true;
		}

		public bool IsOn => _started;
	}
}

