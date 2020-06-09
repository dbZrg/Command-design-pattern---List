using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class RemoveAtCom<T> : ICommand
    {
        Receiver<T> receiver;
        int index;
        List<T> copy;

        public RemoveAtCom(Receiver<T> rec, int ind)
        {
            receiver = rec;
            index = ind;

        }
        public void Execute()
        {
            copy = new List<T>(receiver.list);
            receiver.RemoveAt(index);
        }

        public void Undo()
        {
            receiver.list = new List<T>(copy);
        }
    }
}
