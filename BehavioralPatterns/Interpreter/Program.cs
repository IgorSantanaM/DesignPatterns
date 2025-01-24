using Interpreter.NonTerminalExpression;
using Interpreter.TerminalExpressions;

List<string> context = ["hello", "world", "elephant", "help"];

//var expression = new ContainsExpression(str: "el");
//var expression = new WordExpression(word: "hello");
//var expression = new NotExpression(word: "hello");
var expression = new AndExpression(
    left: new NotExpression(word: "hello"),
    right: new ContainsExpression(str: "el")
);

var result = expression.Interpret(context);

Console.WriteLine(string.Join(", ", result));