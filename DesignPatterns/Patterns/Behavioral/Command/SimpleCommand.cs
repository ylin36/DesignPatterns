using System;
namespace DesignPatterns.Patterns.Behavioral.Command
{
	public class SimpleCommand : ICommand
	{
        private string _payload;
        public SimpleCommand(string payload)
		{
            _payload = payload;
		}

        public void Execute()
        {
            Console.WriteLine(_payload);
        }
    }
}

