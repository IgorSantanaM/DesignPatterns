using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class ConcreteCreator : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProduct();
        }
    }
}
