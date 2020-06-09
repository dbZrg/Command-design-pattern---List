using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class InsertRangeCom<T> : ICommand
    {
        Receiver<T> receiver;
        IEnumerable<T> collection;
        int index;

        public InsertRangeCom(Receiver<T> rec,int ind, IEnumerable<T> coll)
        {
            receiver = rec;
            index = ind;
            collection = coll;

        }
        public void Execute()
        {
            
            receiver.InsertRange(index,collection);
        }

        public void Undo()
        {
            receiver.RemoveRange(index, collection.Count());
        }
    }
}
