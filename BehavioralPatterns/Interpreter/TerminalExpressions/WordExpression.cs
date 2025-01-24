using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.TerminalExpressions
{
    public class WordExpression(string word) : Expression
    {

        public readonly string _word = word;
        public override List<string> Interpret(List<string> words)
        {
            return words.Where(word => word.Equals(_word, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
