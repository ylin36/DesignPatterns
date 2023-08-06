# Strategy Pattern
* take a class that does something specific in a lot of different ways and extract all of these algorithms into separate classes called strategies.
* The original class, called context, must have a field for storing a reference to one of the strategies.
* The context delegates the work to a linked strategy object instead of executing it on its own.
* Context doesn't select the appropriate algo, the client passes it in.

Benefit
* allow swapping algos used inside during runtime.
* replace inheritance (tightly coupled) with composition (loosely coupled)

Similar to template pattern but instead of override via inheritance, strategy takes implementation from DI strategy in Context

* very common in C# code. It’s often used in various frameworks to provide users a way to change the behavior of a class without extending it.
* Strategy pattern can be recognized by a method that lets a nested object do the actual work, as well as a setter that allows replacing that object with a different one.