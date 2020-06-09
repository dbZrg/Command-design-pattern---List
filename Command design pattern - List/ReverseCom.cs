using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class ReverseCom<T> : ICommand
    {
        Receiver<T> receiver;

        public ReverseCom(Receiver<T> rec)
        {
            receiver = rec;
        }
        public void Execute()
        {
            receiver.Reverse();
        }

        public void Undo()
        {
            receiver.Reverse();
        }
    }
}