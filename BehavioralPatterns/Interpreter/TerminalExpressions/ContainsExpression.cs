using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.TerminalExpressions
{
    public class ContainsExpression(string str) : Expression
    {

        public readonly string _str = str;
        public override List<string> Interpret(List<string> words)
        {
            return words.Where(word => _str.Contains(word, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
