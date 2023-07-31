using System;
namespace DesignPatterns.Patterns.Creational.Prototype
{
	public class Owner
	{
		public Owner(string name, string phoneNumber)
		{
			Name = name;
			PhoneNumber = phoneNumber;
		}

		public string Name { get; }
		public string PhoneNumber { get; }
	}
}

