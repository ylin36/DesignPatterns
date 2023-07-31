using System;
namespace DesignPatterns.Patterns.Behavioral.Command
{
	/// <summary>
	/// invoker sends requests to command. Invoker could be something like a button that kicked off a command
	/// </summary>
	public class Invoker
	{
		private ICommand _onStart;
		private ICommand _onFinish;

		public void SetOnStart(ICommand command)
		{
			_onStart = command;
		}

		public void SetOnFinish(ICommand command)
		{
			_onFinish = command;
		}

		public Invoker()
		{
		}

		public void DoSomething()
		{
			_onStart?.Execute();

			_onFinish?.Execute();
		}
	}
}

