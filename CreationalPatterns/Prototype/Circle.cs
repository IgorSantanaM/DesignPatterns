using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle(int radius, Color color) : IShape
    {
        public IShape Clone()
        {
            return new Circle(radius, color.Clone());
        }
    }
}
