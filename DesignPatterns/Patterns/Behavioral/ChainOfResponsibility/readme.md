# Chain of Responsibility Pattern
Chain of responsibility allows client to chain up all potential handlers.
The handlers will call from the first in the chain down the list like a linked list,
until it is either handled by one of the chains and return the call stack or result in end of the chain and return up a null;