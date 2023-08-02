# Mediater Pattern
* Remove direct communication between components. They will collaborate with each other through a mediator in the middle
* Use the Mediator pattern when it’s hard to change some of the classes because they are tightly coupled to a bunch of other classes.
    - Extract all relationships to a diff class
* Use when we cannot reuse component in a diff program due to too much dependency

* Mediator knows about all component concrete types, and dictate the Notify routing rule for receivers
* All components must inherit BaseComponent which registers itself to mediator.
* Each compoennt trigger communication through mediator, and mediator directs event to others based on business rule.