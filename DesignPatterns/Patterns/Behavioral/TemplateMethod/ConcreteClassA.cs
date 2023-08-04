using System;
namespace DesignPatterns.Patterns.Behavioral.TemplateMethod
{
	public class ConcreteClassA : AbstractClass
	{   
		public ConcreteClassA()
		{
		}

        protected override string RequiredOperation1()
        {
            return "a";
        }

        protected override string RequiredOperation2()
        {
            return "b";
        }
    }
}

