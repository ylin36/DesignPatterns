# Decorator Pattern
(Dynamically change functionality of an object at runtime)

* Extending a class is the first thing that comes to mind when you need to alter an object’s behavior.
* However, inheritance has several serious caveats that you need to be aware of.
1) Inheritance is static. You can’t alter the behavior of an existing object at runtime. You can only replace the whole object with another one that’s created from a different subclass.
2) Subclasses can have just one parent class. In most languages, inheritance doesn’t let a class inherit behaviors of multiple classes at the same time.

“Wrapper” is the alternative nickname for the Decorator pattern that clearly expresses the main idea of the pattern.
decorator pattern adds new functionality to objects without modifying their defining classes.

Decorator is useful to add additional functionalities to just *an existing object* without adding it to an entire class of objects.
It is used alot with streams to wrap a stream. eg, using GZipStream around a FileStream for added compression.

consists of
1) Component (IAircraft)
2) Concrete Component (Boeing747 : IAircraft), defining basic implementation. 
3) Decorator (abstract class Boeing747Decorator : IAircraft) See why we need this extra decorator abstract. It helps with inheriting more decorators without having to implement every IComponent interface again. It also shows this is a decorator.
https://stackoverflow.com/questions/2016765/decorator-pattern-why-do-we-need-an-abstract-decorator#:~:text=Using%20the%20abstract%20decorator%20implementation,decorator%20class%20implementation%20per%20decoration.&text=The%20base%20Decorator%20makes%20it%20easier%20to%20create%20additional%20decorators.
4) Concerete Decorator (LimitedTrim : Boeing747Decorator), (EconomyTrim : Boeing747Decorator), takes concrete component as a DI