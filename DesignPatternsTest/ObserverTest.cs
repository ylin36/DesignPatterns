using System;
using DesignPatterns.Patterns.Behavioral.Observer;
namespace DesignPatternsTest

{
    public class ObserverTest
    {
        [Fact]
        public void Test1()
        {
            var subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserverA());
            subject.Attach(new ConcreteObserverB());
            subject.GoToNextState();
        }
    }
}

