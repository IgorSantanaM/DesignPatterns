using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class ComplexProductBuilder : IBuilder
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public Product Build()
        {
            return new Product(name: _name, description: _description);
        }

        public void BuildDescription()
        {
            _description = "Simple Product description";
        }

        public void BuildName()
        {
            _name = "simple Product";
        }
    }
}
