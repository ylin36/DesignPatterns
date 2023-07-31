using System;
using System.Runtime;

namespace DesignPatterns.Patterns.Creational.Prototype
{
    public class Boeing747
    {
        public Boeing747(Owner owner)
        {
            Owner = owner;
        }

        public int SerialNumber { get; set; }
        public int Name { get; set; }
        public string Company { get; set; }
        private Owner Owner { get; set; }

        public Boeing747 ShallowCopy()
        {
            return (Boeing747)MemberwiseClone();

        }

        public Boeing747 DeepCopy()
        {
            // memberwise clone is a shallow copy
            var clone = (Boeing747)this.MemberwiseClone();

            // deep clone the Owner. notice this is private but object same class means it can access the private field.
            clone.Owner = new Owner(Owner.Name, Owner.PhoneNumber);
            return clone;

        }
    }
}

