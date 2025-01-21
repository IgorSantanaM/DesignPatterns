using Bridge;
using Bridge.Abstractions;
using Bridge.Implementors;

Abstraction abstraction = new RefinedAbstraction2(
    implementor: new ConcreteImplementor3());

abstraction.Foo();