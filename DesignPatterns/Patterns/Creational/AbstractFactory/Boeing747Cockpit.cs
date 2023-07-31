using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class Boeing747Cockpit : ICockpit
	{

        private bool _isOpen;
		public Boeing747Cockpit()
		{
		}

        public void Close()
        {
            _isOpen = false;
        }

        public bool IsOpen => _isOpen;

        public void Open()
        {
            _isOpen = true;
        }
    }
}

