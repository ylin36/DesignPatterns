# Adapter pattern
* This is a wrapper similar to Proxy and Decorator. However, the purpose here is to create a wrapper that adapts code to existing interface.
* Adapter here can take the concrete Adaptee's class into the Adapter constructor as opposed to an interface.
* It’s very often used in systems based on some legacy code. In such cases, Adapters make legacy code work with modern classes.
* Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type.
When the adapter receives a call to any of its methods, it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.