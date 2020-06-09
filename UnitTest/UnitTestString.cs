using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command_design_pattern___List;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTestString
    {
        [TestMethod]
        public void TestAdd()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            invoker.SetCommand(new AddCom<string>(receiver, "a"));
            invoker.execute();
            invoker.SetCommand(new AddCom<string>(receiver, "b"));
            invoker.execute();

            CollectionAssert.AreEqual(new List<string>() { "a", "b" }, receiver.list);
        }

        [TestMethod]
        public void TestAddUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            invoker.SetCommand(new AddCom<string>(receiver, "a"));
            invoker.execute();
            invoker.SetCommand(new AddCom<string>(receiver, "b"));
            invoker.execute();
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a" }, receiver.list);
            invoker.undo();
            Assert.AreEqual(receiver.list.Count(), 0);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b" }, receiver.list);
        }

        [TestMethod]
        public void TestAddRange()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d" };
            List<string> listaZaUbacit = new List<string>() { "e", "f" };
            invoker.SetCommand(new AddRangeCom<string>(receiver, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e", "f" }, receiver.list);
            invoker.SetCommand(new AddRangeCom<string>(receiver, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e", "f", "e", "f" }, receiver.list);
        }

        [TestMethod]
        public void TestAddRangeUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d" };
            List<string> listaZaUbacit = new List<string>() { "e", "f" };
            invoker.SetCommand(new AddRangeCom<string>(receiver, listaZaUbacit));
            invoker.execute();
            invoker.SetCommand(new AddRangeCom<string>(receiver, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e", "f", "e", "f" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e", "f" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e", "f" }, receiver.list);
        }

        [TestMethod]
        public void TestClearUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d" };
            invoker.SetCommand(new ClearCom<string>(receiver));
            invoker.execute();
            Assert.AreEqual(receiver.list.Count, 0);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d" }, receiver.list);
            invoker.redo();
            Assert.AreEqual(receiver.list.Count, 0);

        }

        [TestMethod]
        public void TestInsertUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "c", "e" };
            invoker.SetCommand(new InsertCom<string>(receiver, 1, "b"));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "e" }, receiver.list);
            invoker.SetCommand(new InsertCom<string>(receiver, 3, "d"));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d","e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "c", "e" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "e" }, receiver.list);

        }

        [TestMethod]
        public void TestInsertRangeUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "d", "e" };
            List<string> listaZaUbacit = new List<string>() { "b","c" };
            invoker.SetCommand(new InsertRangeCom<string>(receiver, 1, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
            invoker.SetCommand(new InsertRangeCom<string>(receiver, 5, listaZaUbacit));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e","b","c" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "d", "e" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
        }

        [TestMethod]
        public void TestRemoveUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d", "e" };
            invoker.SetCommand(new RemoveCom<string>(receiver, "c"));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "d", "e" }, receiver.list);
            invoker.SetCommand(new RemoveCom<string>(receiver, "d"));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "d", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "d", "e" }, receiver.list);

        }

        [TestMethod]
        public void TestRemoveAtUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d", "e" };
            invoker.SetCommand(new RemoveAtCom<string>(receiver, 2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "d", "e" }, receiver.list);
            invoker.SetCommand(new RemoveAtCom<string>(receiver, 2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "d", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "d", "e" }, receiver.list);

        }

        [TestMethod]
        public void TestRemoveRangeUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d", "e" };
            invoker.SetCommand(new RemoveRangeCom<string>(receiver, 1, 2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "a", "d", "e" }, receiver.list);
            invoker.SetCommand(new RemoveRangeCom<string>(receiver, 0, 2));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() { "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "d", "e" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "a", "d", "e" }, receiver.list);

        }

        [TestMethod]
        public void TestReverseUndoAndRedo()
        {
            Receiver<string> receiver = new Receiver<string>();
            Invoker invoker = new Invoker();
            receiver.list = new List<string>() { "a", "b", "c", "d", "e" };
            invoker.SetCommand(new ReverseCom<string>(receiver));
            invoker.execute();
            CollectionAssert.AreEqual(new List<string>() {"e","d","c","b","a" }, receiver.list);
            invoker.undo();
            CollectionAssert.AreEqual(new List<string>() { "a", "b", "c", "d", "e" }, receiver.list);
            invoker.redo();
            CollectionAssert.AreEqual(new List<string>() { "e", "d", "c", "b", "a" }, receiver.list);

        }
    }
}
