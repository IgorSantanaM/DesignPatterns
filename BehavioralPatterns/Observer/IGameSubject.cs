﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IGameSubject
    {
        void Attach(IGameObserver observer);
        void Deattach(IGameObserver observer);
        void Notify();
    }
}
