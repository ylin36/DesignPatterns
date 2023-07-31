using System;
namespace DesignPatterns.Patterns.Structural.Proxy
{
	/// <summary>
	/// proxy for the real F16
	/// </summary>
	public class F16Controller : IAircraft
	{
		private IAircraft _f16;
		private ILogger _logger;
		public F16Controller(IAircraft f16, ILogger<F16Controller> logger)
		{
			_f16 = f16;
			_logger = logger;
		}

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public int Fly(string destination)
		{
			if (HasPermissionToFly)
			{
				_logger.LogInformation("Flying...");
				return _f16.Fly(destination);

			}
			else
			{
				_logger.LogInformation("Not allowed to fly");
				return 0;
			}
		}

		private bool HasPermissionToFly => true;

	}
}

