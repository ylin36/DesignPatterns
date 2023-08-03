using System;
namespace DesignPatterns.Patterns.Behavioral.State
{
	public abstract class State
	{
		/// <summary>
		/// context is accessible by this class and subclasses
		/// </summary>
		protected Context _context;
        // additional notes on protected keyword. Protected Internal = Protected OR Internal, Private Protected = Protected AND Internal 

        /// <summary>
		/// Takes in context. This reference to the context, allows state to use context to transition to another state
		/// his is a method and not a constructor because otherwise creation of Context which needs state will also have the state needing context leading to chicken egg
        /// </summary>
        /// <param name="context"></param>
        public void SetContext(Context context)
		{
			_context = context;
		}

		/// <summary>
		/// deal with what happens when an input takes effect. these can be called Handle or just match the name as the input in context.
		/// </summary>
		public abstract void Handle1();

		public abstract void Handle2();
	}
}

