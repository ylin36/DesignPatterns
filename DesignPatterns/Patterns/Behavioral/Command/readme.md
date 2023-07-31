# Command Pattern
Turns a request into a stand-alone object that contains all information about the request.
This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

MVVM pattern uses this. For example, Xamarin uses this for MVVM binding where for example, buttons don't link to onClickEvent but they get {Binding ClickCommand}
Command objects serve as links between various GUI and business logic objects.
From now on, the GUI object doesn’t need to know what business logic object will receive the request and how it’ll be processed.
The GUI object just triggers the command, which handles all the details.

CQRS uses this

Difference between Command and Event
Event => something happened
Command => invoke event

When to use?
* Use the Command pattern when you want to parametrize objects with operations.
    - Turn specific methods into a standalone object
* Use the Command pattern when you want to queue operations, schedule their execution, or execute them remotely.
    - Because command is an object, it can be be serialized, and sent over the network (methods are not serialized)
* Use the Command pattern when you want to implement reversible operations.
    - A command history log would contain everything.

Composed of
* ICommand interface
* Simple or Complex command implementations
* Receiver that is passed into the complex commands to do the work along with args. (Can be decoupled from command using Mediator)
* Invoker 