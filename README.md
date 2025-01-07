# Design Patterns
## Creational Patterns

### Singleton Pattern
The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. This is typically achieved by restricting instantiation and using a static property or method to manage the single instance.

### Factory Pattern
The Factory pattern delegates the responsibility of object creation to a factory class, promoting the use of abstractions rather than directly instantiating concrete classes. Subclasses or implementations of the factory can determine the specific type of object to be created, allowing the client to remain decoupled from the actual instantiation logic.

## Behavioral Patterns
### Strategy
Defines a family of algorithms, encapsulates each one, and makes them interchangeable. The client can select the desired algorithm at runtime.

## Structural Patterns

### Decorator Pattern
The Decorator pattern allows for dynamic modification of an object's behavior by wrapping it with one or more decorator classes. Each decorator adds new functionality without altering the original object's structure, enabling flexible and runtime-composable enhancements.
