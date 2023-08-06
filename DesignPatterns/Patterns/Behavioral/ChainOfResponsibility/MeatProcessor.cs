using System;
namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	public class MeatProcessor : AbstractHandler
	{
		public MeatProcessor()
		{
		}

        public override object Handle(object request)
        {
            if (request.ToString() == "Meat")
                return "Diced meat";
            return base.Handle(request);
        }
    }
}

