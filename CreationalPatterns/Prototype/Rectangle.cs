using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle(int width, int height, Color color) : IShape 
    {
        public IShape Clone()
        {
            return new Rectangle(width, height, color.Clone());
        }
    }
}
