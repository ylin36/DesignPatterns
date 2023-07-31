## Builder Pattern
https://refactoring.guru/design-patterns/builder

* builder pattern encapsulates or hides the process of building a complex object and separates the representation of the object and its construction.
* The separation allows us to construct different representations using the same construction process
* Help simplify things to have a larger class than to inherit a subclass for every little configuration difference, however the constructors would be too complex, but builder pattern would simplify this.
* useful when constructor overload would be too much, and avoid needs to pass in nulls for unused properties
* useful for immutable objects where we don't want to expose any property setting after object is created

* consists of the following entities
```
1) Director: Optional, directs the creation using the builder.
Useful if you have specific params you want to set. Also useful if certain things needs to be built in order, so that logic can be captured here
2) Builder: eg abstract builder. Can also be interface
3) ConcreteBuilder: eg implementation of builder that builds the specific product
4) Product: the actual class being build
```

* GetResult() can be called something else, such as Build(), ToString(), etc...
* Each builder step function can return this for chaining.
* For immutable products, the product can also take the builder as constructor and the builder will pass 'this' into the Product's constructor when building
* Examples: aspnet WebApplicationBuilder in Program.cs, StringBuilder

