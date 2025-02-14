
using AbstractFactory.Factories;
using AbstractFactory.Products;

// Using the abstract factory pattern
AbstractFactory.Factories.AbstractFactory abstractFactory = new ConcreteFactory();

Product1 product1 = abstractFactory.CreateProduct1();
Product2 product2 = abstractFactory.CreateProduct2();

// Not using the abstract factory pattern
ConcreteProduct1 concreteProduct1 = new();
ConcreteProduct2 concreteProduct2 = new();