# Visitor Pattern
* separate algorithms from the objects on which they operate.

1) The Visitor pattern suggests that you place the new behavior into a separate class called visitor,
instead of trying to integrate it into existing classes.
2) The original object that had to perform the behavior is now passed to one of the visitor’s methods as an argument,
providing the method access to all necessary data contained within the object.

* Use the Visitor when you need to perform an operation on all elements of a complex object structure (for example, an object tree).
* Use the Visitor to clean up the business logic of auxiliary behaviors.
* Use the pattern when a behavior makes sense only in some classes of a class hierarchy, but not in others.

Consider using it when you have a hierarchy of classes and want to run different method based on concrete type but avoiding *instanceof or typeof* operators.

For each concrete component
* Allow different visitors to provide their different implementation of visit for that component

For each concrete visitor
* it must provide method for implementation for all concrete components that allows it to visit