using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class Invoker
    {
        public Stack<ICommand> Undo;
        public Stack<ICommand> Redo;
        ICommand command;
        public Invoker() {
            Undo = new Stack<ICommand>();
            Redo = new Stack<ICommand>();
        }

        public void SetCommand(ICommand command) {
            this.command = command;
        }
        public void execute() {
            Redo.Clear();
            Undo.Push(command);
            command.Execute();
        }
        public void undo()
        {
            command = Undo.Pop();
            Redo.Push(command);
            command.Undo();
        }
        public void redo()
        {
            
            command = Redo.Pop();
            Undo.Push(command);
            command.Execute();
        }

    }
}
