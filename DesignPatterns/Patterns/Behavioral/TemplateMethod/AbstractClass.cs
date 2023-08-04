using System;
namespace DesignPatterns.Patterns.Behavioral.TemplateMethod
{
	public abstract class AbstractClass
	{
		public AbstractClass()
		{
		}

		public string TemplateMethod()
		{
			return string.Join(", ", BaseOperation1(), BaseOperation2(), RequiredOperation1(), RequiredOperation2(), Hook1(), Hook2());
		}


		protected string BaseOperation1()
		{
			return "1";
		}

		protected string BaseOperation2()
		{
			return "2";
		}

		/// <summary>
		/// must implement
		/// </summary>
		/// <returns></returns>
		protected abstract string RequiredOperation1();

		/// <summary>
		/// must implement
		/// </summary>
		/// <returns></returns>
		protected abstract string RequiredOperation2();

		/// <summary>
		/// hooks are optional
		/// </summary>
		/// <returns></returns>
		protected virtual string Hook1()
		{
			return "";
		}

		/// <summary>
		/// hooks are operational
		/// </summary>
		/// <returns></returns>
		protected virtual string Hook2()
		{
			return "";
		}

    }
}

