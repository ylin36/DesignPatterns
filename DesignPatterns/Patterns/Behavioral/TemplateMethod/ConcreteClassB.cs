using System;
namespace DesignPatterns.Patterns.Behavioral.TemplateMethod
{
	public class ConcreteClassB : AbstractClass
	{
		public ConcreteClassB()
		{
		}

        protected override string RequiredOperation1()
        {
            return "c";
        }

        protected override string RequiredOperation2()
        {
            return "d";
        }

        protected override string Hook1()
        {
            return "e";
        }
    }
}

