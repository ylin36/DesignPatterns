Iterator Pattern
* Extract the traversal behavior of a collection into a separate object called an iterator.
* All iterators must implement the same interface. This makes client code compatible with any collection type.
* If you need a way to traverse a complex collection, just implement iterator to hide the complexity.
* C# IEnumerable is an example of iterator pattern. IEnumerable returns an IEnumerator

but traditionally, iterator just need
interface
* bool hasNext
* Profile getNext
* void reset

Iterator : IEnumerator
IteratorAggregate : IEnumerable

IEnumberable collection must return an IEnumerator, and instead of implementing itself,
a good way is to delegates the work to an IEnumerator object that'll act on it.

In this example, the extra abstract class Iterator and IteratorAggregate are not absolutely necessary

Look at IEnumerable<T> instead of just IEnumerable
yield keyword in GetEnumerator eliminate need to implement Iterator.

example below:
Itergers is called once, and an iterator is returned that'll keep producing until all yields end.
```
public void Consumer()
{
    foreach(int i in Integers())
    {
        Console.WriteLine(i.ToString());
    }
}

public IEnumerable<int> Integers()
{
    yield return 1;
    yield return 2;
    yield return 4;
    yield return 8;
    yield return 16;
    yield return 16777216;
}
```