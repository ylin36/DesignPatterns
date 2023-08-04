using System;
namespace DesignPatterns.Patterns.Structural.Composite
{
	public class Leaf : Component
	{
        private readonly string _value;
		public Leaf(string value)
		{
            _value = value;
		}

        public override bool IsComposite => false;

        public override string Operation()
        {
            return _value;
        }

        public override void Add(Component component)
        {
            // do nothing
        }

        public override void Remove(Component component)
        {
            // do nothing
        }
    }
}

