using System;
namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	public class VegetableProcessor : AbstractHandler
	{
		public VegetableProcessor()
		{
		}

        public override object Handle(object request)
        {
            if (request.ToString() == "Vegetable")
                return "Diced vegetable";
            return base.Handle(request);
        }
    }
}

