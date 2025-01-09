using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void BuildName();
        void BuildDescription();
        Product Build();
    }
}
