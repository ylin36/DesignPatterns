using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class F16Cockpit : ICockpit
	{
        private bool _isOpen;
		public F16Cockpit()
		{
		}

        public bool IsOpen => IsOpen;

        public void Close()
        {
            _isOpen = false;
        }

        public void Open()
        {
            _isOpen = true;
        }
    }
}

