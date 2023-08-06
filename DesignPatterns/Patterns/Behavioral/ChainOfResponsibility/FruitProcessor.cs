using System;
namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	public class FruitProcessor : AbstractHandler
	{
		public FruitProcessor()
		{
		}

        /// <summary>
        /// override the handle to provide its implementation. if it can't handle it then call base to let next handler handle it
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override object Handle(object request)
        {
            if (request.ToString() == "Fruit")
                return "Sliced fruit";
            return base.Handle(request);
        }
    }
}

