# State Pattern
The State pattern is commonly used in C# to convert massive switch-base state machines into objects.
Consists of
* Context - the interface of interest to the client. Hold state object, and deals with taking input from client and delegating it to the state.
          - All states reference context to help with transitions
* State   - Abstract base class. Holds methods dealing with context
* Concrete states - Deal with handling inputs delegated by context