using System;
using DesignPatterns.Patterns.Structural.Composite;
namespace DesignPatternsTest
{
    public class CompositeTest
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var root = new Composite();
            var node1 = new Composite();
            var node2 = new Composite();
            var node3 = new Composite();
            root.Add(node1);
            root.Add(node2);
            node1.Add(new Leaf("a"));
            node1.Add(new Leaf("b"));
            node2.Add(node3);
            node3.Add(new Leaf("c"));

            // act
            var result = root.Operation();

            // assert
            Assert.Equal("a b c", result);
        }
    }
}

