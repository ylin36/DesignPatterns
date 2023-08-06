using System;
namespace DesignPatterns.Patterns.Behavioral.ChainOfResponsibility
{
	public abstract class AbstractHandler : IHandler
	{
        private IHandler _nextHandler;
		public AbstractHandler()
		{
		}

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
                return _nextHandler.Handle(request);
            else
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}

