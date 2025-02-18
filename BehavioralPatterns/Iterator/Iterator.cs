﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Next();
        void Reset();
    }
}
