﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface Aggregate<T>
    {
        Iterator<T> CreateIterator();
        void Add(T value);
    }
}
