namespace DesignPatternsTest;
using DesignPatterns.Patterns.Behavioral.Mediator;
using Moq;

public class MediatorTest
{
    [Fact]
    public void Test1()
    {
        // arrange 
        var comp1 = new Mock<Component1>();
        var comp2 = new Mock<Component2>();

        // act
        var concreteMediator = new ConcreteMediator(comp1.Object, comp2.Object);

        comp1.Setup(s => s.DoA()).CallBase();
        comp2.Setup(s => s.DoD()).CallBase();
        comp1.Object.DoA();
        comp2.Object.DoD();

        // assert
        comp1.Verify(s => s.DoB(), Times.Once());
        comp2.Verify(s => s.DoC(), Times.Exactly(2));
    }
}
