using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public class ConcreteCreator : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteEnemy();
        }
    }
}
