using System;
namespace DesignPatterns.Patterns.Behavioral.Command
{
	public class ComplexCommand : ICommand
	{
        private string _a;
        private string _b;
        private Receiver _receiver;
		public ComplexCommand(Receiver receiver, string a, string b)
		{
            _receiver = receiver;
            _a = a;
            _b = b;
		}

        public void Execute()
        {
            _receiver.Print(_a);
            _receiver.Print(_b);
            Console.WriteLine("complex commands are handled by receiver");
        }
    }
}

