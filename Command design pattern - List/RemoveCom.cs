using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class RemoveCom<T> : ICommand
    {
        Receiver<T> receiver;
        readonly T t;
        List<T> copy;

        public RemoveCom(Receiver<T> rec, T t)
        {
            receiver = rec;
            this.t = t;

        }
        public void Execute()
        {
            copy = new List<T>(receiver.list);
            receiver.Remove(t);
            
        }

        public void Undo()
        {
            receiver.list = new List<T>(copy);
        }
    }
}
