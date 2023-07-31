using System;
namespace DesignPatterns.Patterns.Behavioral.Command
{
	public class Receiver
	{
		public Receiver()
		{
		}

        public void Print(string payload)
        {
            Console.Write(payload);
        }

        public void PrintLine(string payload)
        {
            Console.WriteLine(payload);
        }

    }
}

