using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class InsertCom<T> : ICommand
    {
        Receiver<T> receiver;
        int index;
        T t;

        public InsertCom(Receiver<T> rec,int ind, T t)
        {
            receiver = rec;
            this.t = t;
            index = ind;


        }
        public void Execute()
        {
            receiver.Insert(index,t);
        }

        public void Undo()
        {
            receiver.RemoveAt(index);
        }
    }
}
