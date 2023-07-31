using System;
namespace DesignPatterns.Patterns.Structural.Adapter
{
	/// <summary>
	/// Domain specific interface used by clients
	/// </summary>
	public interface ITarget
	{
		string GetRequest();
	}
}

