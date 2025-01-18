using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Composite
    public class Bundle(string name) : LearningResourse
    {

        private readonly List<LearningResourse> _children = [];
        public override TimeSpan GetDurantion()
        {
            return new(_children.Sum(x => x.GetDurantion().Ticks));
        }

        public override string GetName()
        {
            return name;
        }

        public override decimal GetPrice()
        {
            return _children.Sum(x => x.GetPrice() * 0.8m);
        }

        public override void Add(LearningResourse learningResourses)
        {
            _children.Add(learningResourses);
        }

        public override void Remove(LearningResourse learningResourses)
        {
            _children.Remove(learningResourses);
        }

        public override LearningResourse? GetLearningResourse(string name)
        {
            return _children.SingleOrDefault(x => x.GetName() == name);
        }
    }
}
