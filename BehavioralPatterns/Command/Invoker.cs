using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        public readonly List<ICommand?> _commands = [];
        public readonly Stack<ICommand?> _undoStack = [];

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void UndoLastCommand() 
        {
            var command = _undoStack.Pop();
            command?.Undo();
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command?.Execute();
                _undoStack.Push(command);
            }

            _commands.Clear();
        }
    }
}
