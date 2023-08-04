Proxy Pattern has few usage cases
1) Remote proxy
2) Protection proxy
3) Virtual proxy
4) Logging proxy
5) Caching proxy

Proxy pattern is similar to decorator with the difference that
https://refactoring.guru/design-patterns/proxy/csharp/example

Proxies delegate all of the real work to some other object.
Unlike decorator pattern which can override, or augment the real work.
Each proxy method should, in the end, refer to a service object unless the proxy is a subclass of a service.

To achieve this
The Proxy pattern suggests that you create a new proxy class with the same interface as an original service object.
Then you update your app so that it passes the proxy object to all of the original object’s clients.
Upon receiving a request from a client, the proxy creates a real service object and delegates all the work to it.

The most common applications of the Proxy pattern are
* lazy loading,
* caching,
* controlling the access,
* logging, etc.
* A Proxy can perform one of these things and then, depending on the result, pass the execution to the same method in a linked RealSubject object.
* Mock Unit Tests