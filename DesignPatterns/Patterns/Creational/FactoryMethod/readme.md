Factory method is composed of
* Creator
    - Aircraft
* Concrete creator
    - Boeing747
* Product
    - Engine
* Concrete Product
    - Boeing747Engine
    

where Creator contains
    - someOperation (that calls the createProduct which has the overriden implementation, and then uses that Product's interface to call methods')
    - abstract createProduct()

Concrete Creator implements the createProduct() method

Product
    - the abstract product

ConcreteProduct
    - implementation of the abstract product that the concrete creator's override will end up creating to use its methods exposed by Product abstract

    https://refactoring.guru/design-patterns/factory-method