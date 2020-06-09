using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class RemoveRangeCom<T> : ICommand
    {
        Receiver<T> receiver;
        int index;
        int count;
        List<T> copy;

        public RemoveRangeCom(Receiver<T> rec, int ind, int count)
        {
            receiver = rec;
            index = ind;
            this.count = count;

        }
        public void Execute()
        {
            copy = new List<T>(receiver.list);
            receiver.RemoveRange(index, count);
        }

        public void Undo()
        {
            receiver.list = new List<T>(copy);
        }
    }
}