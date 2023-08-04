using System;
namespace DesignPatterns.Patterns.Structural.Composite
{
	public class Composite : Component
	{
        // : base() is automatically called in this case because it is default constructor, so we don't need to explcitly do : base()
        public Composite()  
		{
		}

        public override bool IsComposite => true;

        public override string Operation()
        {
            return string.Join(" ", _components.Select(s => s.Operation()));
        }
    }
}

