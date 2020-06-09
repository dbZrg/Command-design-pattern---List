using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_design_pattern___List
{
    public class Receiver<T>
    {
        public List<T> list;

        public Receiver(){
            list = new List<T>();
        }

        public void Add(T t) {
            list.Add(t);
        }

        public void AddRange(IEnumerable<T> collection) {
            list.AddRange(collection);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Insert(int index,T t)
        {
            list.Insert(index, t);
        }

        public void InsertRange(int index, IEnumerable<T> collection)
        {
            list.InsertRange(index, collection);
        }

        public void Remove(T t)
        {
            list.Remove(t);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public void RemoveRange(int index, int count) {
            list.RemoveRange(index, count);
        }
        public void Reverse()
        {
            list.Reverse();
        }
    }
}
