using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public abstract class Creator
    {
        public abstract Product CreateProduct();
    }
}
