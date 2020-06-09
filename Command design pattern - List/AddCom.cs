using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class AddCom<T> : ICommand
    {
        Receiver<T> receiver;
        T argument;

        public AddCom(Receiver<T> rec, T arg) {
            receiver = rec;
            argument = arg;
        }
        public void Execute()
        {
            receiver.Add(argument);
        }

        public void Undo()
        {
            receiver.RemoveAt(receiver.list.Count - 1);
        }
    }
}
