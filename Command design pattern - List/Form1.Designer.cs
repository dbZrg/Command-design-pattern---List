namespace Command_design_pattern___List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.addArgument = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addRangeList = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.insertArgument2 = new System.Windows.Forms.TextBox();
            this.insertArgument1 = new System.Windows.Forms.NumericUpDown();
            this.insertRangeButton = new System.Windows.Forms.Button();
            this.insertRangeArgument2 = new System.Windows.Forms.TextBox();
            this.insertRangeArgument1 = new System.Windows.Forms.NumericUpDown();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeArgument = new System.Windows.Forms.TextBox();
            this.removeAtButton = new System.Windows.Forms.Button();
            this.removeAtArgument = new System.Windows.Forms.NumericUpDown();
            this.removeRangeButton = new System.Windows.Forms.Button();
            this.removeRangeArgument1 = new System.Windows.Forms.NumericUpDown();
            this.removeRangeArgument2 = new System.Windows.Forms.NumericUpDown();
            this.reverseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insertArgument1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertRangeArgument1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeAtArgument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeRangeArgument1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeRangeArgument2)).BeginInit();
            this.SuspendLayout();
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(12, 54);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(145, 55);
            this.undoButton.TabIndex = 0;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Enabled = false;
            this.redoButton.Location = new System.Drawing.Point(163, 54);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(152, 55);
            this.redoButton.TabIndex = 1;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 451);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(802, 71);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 325);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 39);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addArgument
            // 
            this.addArgument.Location = new System.Drawing.Point(39, 386);
            this.addArgument.Name = "addArgument";
            this.addArgument.Size = new System.Drawing.Size(54, 20);
            this.addArgument.TabIndex = 4;
            this.addArgument.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "AddRange( list )";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addRangeList
            // 
            this.addRangeList.Location = new System.Drawing.Point(184, 388);
            this.addRangeList.Name = "addRangeList";
            this.addRangeList.Size = new System.Drawing.Size(105, 20);
            this.addRangeList.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 179);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 42);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(365, 324);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(151, 39);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // insertArgument2
            // 
            this.insertArgument2.Location = new System.Drawing.Point(443, 386);
            this.insertArgument2.Name = "insertArgument2";
            this.insertArgument2.Size = new System.Drawing.Size(69, 20);
            this.insertArgument2.TabIndex = 10;
            // 
            // insertArgument1
            // 
            this.insertArgument1.Location = new System.Drawing.Point(365, 386);
            this.insertArgument1.Name = "insertArgument1";
            this.insertArgument1.Size = new System.Drawing.Size(55, 20);
            this.insertArgument1.TabIndex = 11;
            // 
            // insertRangeButton
            // 
            this.insertRangeButton.Location = new System.Drawing.Point(584, 324);
            this.insertRangeButton.Name = "insertRangeButton";
            this.insertRangeButton.Size = new System.Drawing.Size(192, 39);
            this.insertRangeButton.TabIndex = 12;
            this.insertRangeButton.Text = "InsertRange";
            this.insertRangeButton.UseVisualStyleBackColor = true;
            this.insertRangeButton.Click += new System.EventHandler(this.insertRangeButton_Click);
            // 
            // insertRangeArgument2
            // 
            this.insertRangeArgument2.Location = new System.Drawing.Point(669, 384);
            this.insertRangeArgument2.Name = "insertRangeArgument2";
            this.insertRangeArgument2.Size = new System.Drawing.Size(107, 20);
            this.insertRangeArgument2.TabIndex = 13;
            // 
            // insertRangeArgument1
            // 
            this.insertRangeArgument1.Location = new System.Drawing.Point(584, 385);
            this.insertRangeArgument1.Name = "insertRangeArgument1";
            this.insertRangeArgument1.Size = new System.Drawing.Size(51, 20);
            this.insertRangeArgument1.TabIndex = 14;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(184, 179);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(105, 42);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeArgument
            // 
            this.removeArgument.Location = new System.Drawing.Point(202, 241);
            this.removeArgument.Name = "removeArgument";
            this.removeArgument.Size = new System.Drawing.Size(65, 20);
            this.removeArgument.TabIndex = 16;
            // 
            // removeAtButton
            // 
            this.removeAtButton.Location = new System.Drawing.Point(365, 179);
            this.removeAtButton.Name = "removeAtButton";
            this.removeAtButton.Size = new System.Drawing.Size(128, 42);
            this.removeAtButton.TabIndex = 17;
            this.removeAtButton.Text = "RemoveAt";
            this.removeAtButton.UseVisualStyleBackColor = true;
            this.removeAtButton.Click += new System.EventHandler(this.removeAtButton_Click);
            // 
            // removeAtArgument
            // 
            this.removeAtArgument.Location = new System.Drawing.Point(393, 241);
            this.removeAtArgument.Name = "removeAtArgument";
            this.removeAtArgument.Size = new System.Drawing.Size(66, 20);
            this.removeAtArgument.TabIndex = 18;
            // 
            // removeRangeButton
            // 
            this.removeRangeButton.Location = new System.Drawing.Point(584, 179);
            this.removeRangeButton.Name = "removeRangeButton";
            this.removeRangeButton.Size = new System.Drawing.Size(192, 42);
            this.removeRangeButton.TabIndex = 19;
            this.removeRangeButton.Text = "RemoveRange";
            this.removeRangeButton.UseVisualStyleBackColor = true;
            this.removeRangeButton.Click += new System.EventHandler(this.removeRangeButton_Click);
            // 
            // removeRangeArgument1
            // 
            this.removeRangeArgument1.Location = new System.Drawing.Point(585, 242);
            this.removeRangeArgument1.Name = "removeRangeArgument1";
            this.removeRangeArgument1.Size = new System.Drawing.Size(50, 20);
            this.removeRangeArgument1.TabIndex = 20;
            // 
            // removeRangeArgument2
            // 
            this.removeRangeArgument2.Location = new System.Drawing.Point(708, 241);
            this.removeRangeArgument2.Name = "removeRangeArgument2";
            this.removeRangeArgument2.Size = new System.Drawing.Size(68, 20);
            this.removeRangeArgument2.TabIndex = 21;
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(12, 227);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(98, 46);
            this.reverseButton.TabIndex = 22;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lista (1,2,3..)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lista (1,2,3..)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Broj";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Index";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Index";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(720, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 575);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.removeRangeArgument2);
            this.Controls.Add(this.removeRangeArgument1);
            this.Controls.Add(this.removeRangeButton);
            this.Controls.Add(this.removeAtArgument);
            this.Controls.Add(this.removeAtButton);
            this.Controls.Add(this.removeArgument);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.insertRangeArgument1);
            this.Controls.Add(this.insertRangeArgument2);
            this.Controls.Add(this.insertRangeButton);
            this.Controls.Add(this.insertArgument1);
            this.Controls.Add(this.insertArgument2);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addRangeList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addArgument);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.insertArgument1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertRangeArgument1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeAtArgument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeRangeArgument1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeRangeArgument2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addArgument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addRangeList;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox insertArgument2;
        private System.Windows.Forms.NumericUpDown insertArgument1;
        private System.Windows.Forms.Button insertRangeButton;
        private System.Windows.Forms.TextBox insertRangeArgument2;
        private System.Windows.Forms.NumericUpDown insertRangeArgument1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox removeArgument;
        private System.Windows.Forms.Button removeAtButton;
        private System.Windows.Forms.NumericUpDown removeAtArgument;
        private System.Windows.Forms.Button removeRangeButton;
        private System.Windows.Forms.NumericUpDown removeRangeArgument1;
        private System.Windows.Forms.NumericUpDown removeRangeArgument2;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

