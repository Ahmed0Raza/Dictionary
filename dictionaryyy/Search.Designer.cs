namespace Dictionary
{
    partial class Search
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            meaningBox = new TextBox();
            label3 = new Label();
            wordBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SearchBtn = new Button();
            SearchBox = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaptionText;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Teal;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(476, 53);
            richTextBox1.TabIndex = 1;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "                     Welcome to Your Dictionary";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InactiveCaptionText;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Cursor = Cursors.Hand;
            richTextBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = SystemColors.Info;
            richTextBox2.Location = new Point(12, 24);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(452, 20);
            richTextBox2.TabIndex = 2;
            richTextBox2.TabStop = false;
            richTextBox2.Text = "             Explore words with ease in our app's handy dictionary!";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(2, 50);
            button4.Name = "button4";
            button4.Size = new Size(151, 64);
            button4.TabIndex = 3;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(149, 50);
            button5.Name = "button5";
            button5.Size = new Size(175, 64);
            button5.TabIndex = 4;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(321, 50);
            button6.Name = "button6";
            button6.Size = new Size(153, 64);
            button6.TabIndex = 5;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 120);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(452, 164);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(meaningBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(wordBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(SearchBtn);
            tabPage1.Controls.Add(SearchBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(444, 136);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // meaningBox
            // 
            meaningBox.Location = new Point(289, 71);
            meaningBox.Name = "meaningBox";
            meaningBox.Size = new Size(100, 23);
            meaningBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 13;
            label3.Text = "Meaning";
            // 
            // wordBox
            // 
            wordBox.Location = new Point(289, 23);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(100, 23);
            wordBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 26);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "Word";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 10;
            label1.Text = "Search";
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(78, 52);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 9;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(78, 23);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(100, 23);
            SearchBox.TabIndex = 8;
            SearchBox.TextChanged += MeaningBox_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(444, 136);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(444, 136);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(444, 136);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Suggestions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(444, 136);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Add Word";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 288);
            Controls.Add(tabControl1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            MaximizeBox = false;
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox SearchBox;
        private Label label1;
        private Button SearchBtn;
        private Label label2;
        private TextBox meaningBox;
        private Label label3;
        private TextBox wordBox;
    }
}