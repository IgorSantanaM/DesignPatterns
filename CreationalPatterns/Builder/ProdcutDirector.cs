using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ProdcutDirector(IBuilder builder)
    {
        public void ConstructProduct()
        {
            builder.BuildName();
            builder.BuildDescription();
        }
    }
}
