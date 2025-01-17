using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LearningResourse
    {
        public abstract string GetName();
        public abstract decimal GetPrice();
        public abstract TimeSpan GetDurantion();
        public virtual void Add(LearningResourse learningResourses) { }
        public virtual void Remove(LearningResourse learningResourses) { }

        public virtual LearningResourse? GetLearningResourse(string name)
        {
            return null;
        }
    }
}
