//Structural Patterns
//[Creeatoinal and Behavioral]
// Bridge, Adapter, Composite, Decorator, Facade, Flyweight, Proxy


//Bridge
//Decouple an abstraction from its implementation so that the two can vary indendently

using Bridge;
using Bridge.Abstractions;
using Bridge.Implementors;

Abstraction abstraction = new RefinedAbstraction1(
    implementor: new ConcreteImplementor1()
);

abstraction.Foo();

abstraction = new RefinedAbstraction1(
    implementor: new ConcreteImplementor2()
);

abstraction.Foo();
