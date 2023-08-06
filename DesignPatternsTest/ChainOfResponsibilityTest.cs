using System;
using DesignPatterns.Patterns.Behavioral.ChainOfResponsibility;
namespace DesignPatternsTest
{
    public class ChainOfResponsibilityTest
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var processChain = new FruitProcessor();
            processChain.SetNext(new MeatProcessor()).SetNext(new VegetableProcessor());
            List<string> groceryItems = new() { "Meat", "Fruit", "Vegetable", "Can" };

            // act
            List<object> results = new();
            groceryItems.ForEach(item =>
            {
                results.Add(processChain.Handle(item));
            });

            // assert
            Assert.Equal("Diced meat", results[0]);
            Assert.Equal("Sliced fruit", results[1]);
            Assert.Equal("Diced vegetable", results[2]);
            Assert.Null(results[3]);
        }
    }
}