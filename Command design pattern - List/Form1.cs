using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command_design_pattern___List
{
    public partial class Form1 : Form
    {
        Invoker invoker;
        Receiver<int> receiver;
        public Form1()
        {
            InitializeComponent();

            receiver = new Receiver<int>();
            invoker = new Invoker();
            invoker.SetCommand(new AddCom<int>(receiver, 8));
            invoker.execute();
            invoker.SetCommand(new AddCom<int>(receiver, 2));
            invoker.execute();
            populateList();

        }

        private void populateList() {
            listView1.Clear();
            foreach (var item in receiver.list)
            {
                listView1.Items.Add(item.ToString());
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            invoker.undo();
            populateList();
            redoButton.Enabled = true;
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            
            invoker.redo();
            populateList();
            if (invoker.Redo.Count() == 0) {
                redoButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                invoker.SetCommand(new AddCom<int>(receiver, Convert.ToInt32(addArgument.Text)));
                invoker.execute();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");
            }
            populateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<int> ints = addRangeList.Text.Split(',').Select(int.Parse);
                
                invoker.SetCommand(new AddRangeCom<int>(receiver, ints));
                invoker.execute();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");
           
            }
            populateList();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            invoker.SetCommand(new ClearCom<int>(receiver));
            invoker.execute();

            populateList();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try { 
            invoker.SetCommand(new InsertCom<int>(receiver, Convert.ToInt32(insertArgument1.Value), Convert.ToInt32(insertArgument2.Text)));
            invoker.execute();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");
            }
            catch(System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Preveliki index na Insertu - Max:" + receiver.list.Count.ToString());
            }

            populateList();
        }

        private void insertRangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<int> ints = insertRangeArgument2.Text.Split(',').Select(int.Parse);
                invoker.SetCommand(new InsertRangeCom<int>(receiver, Convert.ToInt32(insertRangeArgument1.Value), ints));
                invoker.execute();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Preveliki index na InsertRAnge - Max:" + receiver.list.Count.ToString());
            }

            populateList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int element = Convert.ToInt32(removeArgument.Text);
                invoker.SetCommand(new RemoveCom<int>(receiver, element));
                if (receiver.list.Contains(element))
                {
                    invoker.execute();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");

            }
            populateList();
        }

        private void removeAtButton_Click(object sender, EventArgs e)
        {
            try
            {
        
                invoker.SetCommand(new RemoveAtCom<int>(receiver, Convert.ToInt32(removeAtArgument.Value)));
                invoker.execute();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Preveliki index na Remove - Max:" + (receiver.list.Count - 1).ToString() );
            }

            populateList();
        }

        private void removeRangeButton_Click(object sender, EventArgs e)
        {
            try
            {

                invoker.SetCommand(new RemoveRangeCom<int>(receiver, Convert.ToInt32(removeRangeArgument1.Value), Convert.ToInt32(removeRangeArgument2.Value)));
                invoker.execute();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Krivi format");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Preveliki index - Max:" + (receiver.list.Count - 1).ToString());
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Pokusaj brisanja izvan liste");
            }
            populateList();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            invoker.SetCommand(new ReverseCom<int>(receiver));
            invoker.execute();

            populateList();
        }
    }
}
