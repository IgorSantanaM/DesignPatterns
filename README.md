# Design Patterns in [Your Language]

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)

## 📖 About This Project

This repository serves as a practical catalog and learning exercise, containing implementations of the 23 classic design patterns described in the seminal book **"Design Patterns: Elements of Reusable Object-Oriented Software"** by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides (the "Gang of Four" or GoF).

The goal is to provide clear and concise examples of each pattern in the C# language, serving as a resource for study, review, and quick reference.

---

## 🗺️ Pattern Index

The patterns are organized according to their three main categories: **Creational**, **Structural**, and **Behavioral**.

### 🏛️ Creational Patterns

Patterns that abstract the object-instantiation process. They help make a system independent of how its objects are created, composed, and represented.

| Pattern | Brief Description |
| :--- | :--- | 
| **Abstract Factory** | Provides an interface for creating families of related or dependent objects without specifying their concrete classes. 
| **Builder** | Separates the construction of a complex object from its representation, allowing the same construction process to create various representations. |
| **Factory Method** | Defines an interface for creating an object, but lets subclasses alter the type of objects that will be created. 
| **Prototype** | Specifies the kinds of objects to create using a prototypical instance, and creates new objects by copying this prototype.
| **Singleton** | Ensures a class has only one instance and provides a global point of access to it.

### 🏗️ Structural Patterns

Patterns concerned with how classes and objects are composed to form larger structures, while keeping these structures flexible and efficient.

| Pattern | Brief Description |
| :--- | :--- |
| **Adapter** | Converts the interface of a class into another interface clients expect, letting classes work together that couldn't otherwise because of incompatible interfaces.
| **Bridge** | Decouples an abstraction from its implementation so that the two can vary independently.
| **Composite** | Composes objects into tree structures to represent part-whole hierarchies. Lets clients treat individual objects and compositions of objects uniformly.
| **Decorator** | Attaches additional responsibilities to an object dynamically. Provides a flexible alternative to subclassing for extending functionality.
| **Facade** | Provides a unified interface to a set of interfaces in a subsystem, making the subsystem easier to use.
| **Flyweight** | Uses sharing to support large numbers of fine-grained objects efficiently.
| **Proxy** | Provides a surrogate or placeholder for another object to control access to it.

### 🏃‍♂️ Behavioral Patterns

Patterns that are concerned with algorithms and the assignment of responsibilities between objects, describing patterns of communication between them.

| Pattern | Brief Description |
| :--- | :--- |
| **Chain of Responsibility** | Avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
| **Command** | Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
| **Interpreter** | Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language. 
| **Iterator** | Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
| **Mediator** | Defines an object that encapsulates how a set of objects interact, promoting loose coupling by keeping objects from referring to each other explicitly. 
| **Memento** | Without violating encapsulation, captures and externalizes an object's internal state so that the object can be restored to this state later. 
| **Observer** | Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. 
| **State** | Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.
| **Strategy** | Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Lets the algorithm vary independently from clients that use it.
| **Template Method** | Defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. Lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
| **Visitor** | Represents an operation to be performed on the elements of an object structure. Lets you define a new operation without changing the classes of the elements on which it operates.

---

## 🚀 How to Use

Each pattern is contained within its own directory or file for easy navigation. To understand a specific pattern:
1.  Find the pattern in the table above.
2.  Read the brief description to understand its purpose.
3.  Within each example, the code is generally commented to explain the roles of the pattern participants (e.g., `ConcreteBuilder`, `Director`).

## 🙌 Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this project better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".

## 🙏 Acknowledgements

* Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides for the foundational book that continues to guide generations of software developers.
