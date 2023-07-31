using System;
namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	public interface ICockpit
	{

        void Open();
        void Close();
        bool IsOpen { get; }
    }
}

