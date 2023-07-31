using System;
namespace DesignPatterns.Patterns.Creational.Prototype
{
    // Example using IClonable
	public class F16 : ICloneable
	{
		public F16(Owner owner)
        {
            Owner = owner;
        }

        public int SerialNumber { get; set; }
        public int Name { get; set; }
        public string Company { get; set; }
        private Owner Owner { get; set; }

        public object Clone()
        {
            var clone = (F16) MemberwiseClone();
            clone.Owner = new Owner(Owner.Name, Owner.PhoneNumber);
            return clone;
        }
    }
}

