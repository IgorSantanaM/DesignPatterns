using Bridge;
using Bridge.Abstractions;
using Bridge.Implementors;

Abstraction abstraction = new RefinedAbstraction1(
    implementor: new ConcreteImplementor2());

abstraction.Foo();