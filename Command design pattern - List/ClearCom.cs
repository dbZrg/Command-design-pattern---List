using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class ClearCom<T> : ICommand
    {
        Receiver<T> receiver;
        List<T> copy;

        public ClearCom(Receiver<T> rec)
        {
            receiver = rec;
           
        }
        public void Execute()
        {
            copy = new List<T>(receiver.list);
            receiver.Clear();
        }

        public void Undo()
        {
            receiver.list = new List<T>(copy);
        }
    }
}
