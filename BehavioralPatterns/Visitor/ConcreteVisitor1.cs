﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ConcreteVisitor1 : Visitor
    {
        public void Visit(ConcreteElement1 element)
        {
            var message = element.Operation1();
            Console.WriteLine($"Concrete visitor 1: {message}");

        }

        public void Visit(ConcreteElement2 element)
        {
            var message = element.Operation2();
            Console.WriteLine($"Concrete visitor 2: {message}");
        }
    }
}
