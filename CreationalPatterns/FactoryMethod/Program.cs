using FactoryMethod.Creators;
using FactoryMethod.Products;

Creator creator = new ConcreteCreator();
Product prodc = creator.CreateProduct();