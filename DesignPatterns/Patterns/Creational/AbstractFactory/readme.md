## Abstract Factory Pattern

The Factory Pattern Design is mainly used in the following situations:

A class does not know the type of object before its creation.
A class requires its subclasses to specify the objects it creates.
You want to localize the logic of your program to instantiate an instance of the class.
It is useful when you need to abstract the creation of an object away from its actual implementation.

Contains
```
1) AbstractFactory
2) ConcreteFactory
3) AbstractProduct
4) ConcreteProduct
```

* Note that factory can also be used with DI to create specific implementation of an abstraction during runtime where DI would not know what is needed yet at compile time.
* Example, injecting a factory to create multiple different implementation of a product.
* DI would otherwise need to inject the many different product in constructor.