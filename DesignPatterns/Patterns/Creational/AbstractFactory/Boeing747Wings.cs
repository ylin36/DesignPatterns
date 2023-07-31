using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public class Boeing747Wings : IWings
	{
        private bool _isDeployed;

	    public Boeing747Wings()
		{
		}

        public void Deploy()
        {
            _isDeployed = true;
        }

        public bool IsDeployed => _isDeployed;
    }
}

