using System;
using DesignPatterns.Patterns.Behavioral.Strategy;
namespace DesignPatternsTest
{
    public class StrategyTest
    {
        [Fact]
        public void Test1()
        {
            var list = new List<string> { "hello", "world", "this", "is", "a", "test" };

            // start with one strategy
            var context = new Context(new ConcreteStrategyA());

            var result = context.BusinessSortOperation(list);

            // test it
            var ascSorted = list.Order();
            for (int i = 0; i < list.Count; i++)
            {
                Assert.Equal(ascSorted.ElementAt(i), result[i]);
            }

            // change strategy
            context.SetStrategy(new ConcreteStrategyB());
            result = context.BusinessSortOperation(list);

            // test it
            var descSorted = list.OrderDescending();
            for (int i = 0; i < list.Count; i++)
            {
                Assert.Equal(descSorted.ElementAt(i), result[i]);
            }

        }
    }
}

