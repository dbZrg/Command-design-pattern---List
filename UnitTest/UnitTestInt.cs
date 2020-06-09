using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command_design_pattern___List;
using System.Linq;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTestInt
    {
        [TestMethod]
        public void TestAdd()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            invoker.SetCommand(new AddCom<int>(receiver, 8));
            invoker.execute();
            invoker.SetCommand(new AddCom<int>(receiver, 2));
            invoker.execute();

            CollectionAssert.AreEqual(new List<int>() {8,2 }, receiver.list);
        }

        [TestMethod]
        public void TestAddUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            invoker.SetCommand(new AddCom<int>(receiver, 8));
            invoker.execute();
            invoker.SetCommand(new AddCom<int>(receiver, 2));
            invoker.execute();
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 8 }, receiver.list);
            invoker.undo();
            Assert.AreEqual(receiver.list.Count(), 0);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 8 }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 8, 2 }, receiver.list);
        }

        [TestMethod]
        public void TestAddRange()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 2, 3, 4 };
            List<int> listaZaUbacit = new List<int>() { 5, 6 };
            invoker.SetCommand(new AddRangeCom<int>(receiver, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1,2,3,4,5,6 }, receiver.list);
            invoker.SetCommand(new AddRangeCom<int>(receiver, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5, 6,5,6 }, receiver.list);
        }

        [TestMethod]
        public void TestAddRangeUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 2, 3, 4 };
            List<int> listaZaUbacit = new List<int>() { 5, 6 };
            invoker.SetCommand(new AddRangeCom<int>(receiver, listaZaUbacit));
            invoker.execute();
            invoker.SetCommand(new AddRangeCom<int>(receiver, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1,2,3,4,5, 6, 5, 6 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() {  1,2,3,4,5, 6 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4}, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4,5,6 }, receiver.list);
        }

        [TestMethod]
        public void TestClearUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 2, 3, 4 };
            invoker.SetCommand(new ClearCom<int>(receiver));
            invoker.execute();
            Assert.AreEqual(receiver.list.Count, 0);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4 }, receiver.list);
            invoker.redo();
            Assert.AreEqual(receiver.list.Count, 0);

        }

        [TestMethod]
        public void TestInsertUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 3, 5 };
            invoker.SetCommand(new InsertCom<int>(receiver,1,2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 5 }, receiver.list);
            invoker.SetCommand(new InsertCom<int>(receiver, 3, 4));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 3, 5 }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 1,2, 3, 5 }, receiver.list);

        }

        [TestMethod]
        public void TestInsertRangeUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 4, 5 };
            List<int> listaZaUbacit = new List<int>() { 2, 3 };
            invoker.SetCommand(new InsertRangeCom<int>(receiver, 1, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);
            invoker.SetCommand(new InsertRangeCom<int>(receiver, 5, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5, 2, 3 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 4, 5 }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);
        }

        [TestMethod]
        public void TestRemoveUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1,2, 3,4, 5 };
            invoker.SetCommand(new RemoveCom<int>(receiver, 3));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5 }, receiver.list);
            invoker.SetCommand(new RemoveCom<int>(receiver, 4));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3 , 4, 5 }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5 }, receiver.list);

        }

        [TestMethod]
        public void TestRemoveAtUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 2, 3, 4, 5 };
            invoker.SetCommand(new RemoveAtCom<int>(receiver, 2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5 }, receiver.list);
            invoker.SetCommand(new RemoveAtCom<int>(receiver, 2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 4, 5 }, receiver.list);

        }

        [TestMethod]
        public void TestRemoveRangeUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 2, 3, 4, 5 };
            invoker.SetCommand(new RemoveRangeCom<int>(receiver, 1,2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 1,  4, 5 }, receiver.list);
            invoker.SetCommand(new RemoveRangeCom<int>(receiver,0,2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() {  5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 4, 5 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 1, 4, 5 }, receiver.list);

        }

        [TestMethod]
        public void TestReverseUndoAndRedo()
        {
            Receiver<int> receiver = new Receiver<int>();
            Invoker invoker = new Invoker();
            receiver.list = new List<int>() { 1, 2, 3, 4, 5 };
            invoker.SetCommand(new ReverseCom<int>(receiver));
            invoker.execute();
            CollectionAssert.AreEqual(new List<int>() { 5,4,3,2,1 }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, receiver.list);        
            invoker.redo();
            CollectionAssert.AreEqual(new List<int>() { 5, 4, 3, 2, 1 }, receiver.list);

        }

    }
}
