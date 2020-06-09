using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class AddRangeCom<T> : ICommand
    {
        Receiver<T> receiver;
        IEnumerable<T> collection;

        public AddRangeCom(Receiver<T> rec, IEnumerable<T> coll)
        {
            receiver = rec;
            collection = coll;
        }
        public void Execute()
        {
            receiver.AddRange(collection);
        }

        public void Undo()
        {
            receiver.RemoveRange(receiver.list.Count() - collection.Count() , collection.Count());
        }
    }
}
