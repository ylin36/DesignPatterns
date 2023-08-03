using System;
namespace DesignPatterns.Patterns.Behavioral.State
{
	public class Context
	{
		private State _state;

		/// <summary>
		/// Create context and give it initial state
		/// </summary>
		/// <param name="state"></param>
		public Context(State state)
		{
			_state = state;
			TransitionTo(state);
		}

		public void TransitionTo(State state)
		{
			_state = state;
			_state.SetContext(this);
		}

		/// <summary>
		/// Input to the state machine
		/// </summary>
		public void Request1()
		{
			// delegate input event to state
			_state.Handle1();
		}

		/// <summary>
		/// Input to the state machine
		/// </summary>
		public void Request2()
		{
			// delegate input event to state
			_state.Handle2();
		}
	}
}

