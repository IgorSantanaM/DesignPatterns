using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Leaf
    public class Course(string name,
        TimeSpan duration,
        decimal price) : LearningResourse
    {
        public override TimeSpan GetDurantion()
        {
            return duration;
        }

        public override string GetName()
        {
            return name;
        }

        public override decimal GetPrice()
        {
            return price;
        }
    }
}
