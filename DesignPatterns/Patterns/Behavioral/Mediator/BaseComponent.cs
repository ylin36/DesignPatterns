﻿using System;
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
	public class BaseComponent
	{
		protected IMediator _mediator;

		public BaseComponent(IMediator mediator = null)
		{
			_mediator = mediator;
		}

		public void SetMediator(IMediator mediator)
		{
			_mediator = mediator;
		}
	}
}

