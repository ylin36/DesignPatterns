﻿using System;
namespace DesignPatterns.Patterns.Behavioral.Visitor
{
	public class ConcreteVisitor1 : IVisitor
	{
		public ConcreteVisitor1()
		{
		}

        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            // can call methods from the element being visited. doesn't necessarily have to though.
            element.ComponentAMethod();
            Console.WriteLine("Executed ComponentAMethod from Visitor1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            element.ComponentBMethod();
            Console.WriteLine("Executed ComponentBMethod from Visitor1");
        }
    }
}

