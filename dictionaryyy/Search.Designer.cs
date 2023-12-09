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
            deleteBtn = new Button();
            deleteBox = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            updatingBtn = new Button();
            updatedMeaning = new TextBox();
            toUpdateWord = new TextBox();
            label7 = new Label();
            label6 = new Label();
            updateBtn = new Button();
            updateBox = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            sugBtn = new Button();
            sugTxtBox = new TextBox();
            tabPage5 = new TabPage();
            addMeaningBtn = new Button();
            addBtn = new Button();
            newWord = new TextBox();
            addMeaning = new TextBox();
            addBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
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
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 132);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(476, 212);
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
            tabPage1.Size = new Size(468, 184);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // meaningBox
            // 
            meaningBox.Location = new Point(289, 71);
            meaningBox.Name = "meaningBox";
            meaningBox.Size = new Size(149, 23);
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
            label1.Size = new Size(37, 15);
            label1.TabIndex = 10;
            label1.Text = "Enter";
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            SearchBox.Size = new Size(101, 23);
            SearchBox.TabIndex = 8;
            SearchBox.TextChanged += MeaningBox_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(deleteBtn);
            tabPage2.Controls.Add(deleteBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(468, 184);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(69, 40);
            deleteBtn.Margin = new Padding(2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(78, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // deleteBox
            // 
            deleteBox.Location = new Point(69, 17);
            deleteBox.Margin = new Padding(2);
            deleteBox.Multiline = true;
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(197, 20);
            deleteBox.TabIndex = 1;
            deleteBox.TextChanged += deleteBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 0;
            label4.Text = "Enter";
            label4.Click += label4_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(updatingBtn);
            tabPage3.Controls.Add(updatedMeaning);
            tabPage3.Controls.Add(toUpdateWord);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(updateBtn);
            tabPage3.Controls.Add(updateBox);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(468, 184);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // updatingBtn
            // 
            updatingBtn.Location = new Point(277, 90);
            updatingBtn.Name = "updatingBtn";
            updatingBtn.Size = new Size(75, 23);
            updatingBtn.TabIndex = 7;
            updatingBtn.Text = "Enter";
            updatingBtn.UseVisualStyleBackColor = true;
            updatingBtn.Click += updatingBtn_Click;
            // 
            // updatedMeaning
            // 
            updatedMeaning.Location = new Point(278, 61);
            updatedMeaning.Name = "updatedMeaning";
            updatedMeaning.Size = new Size(163, 23);
            updatedMeaning.TabIndex = 6;
            // 
            // toUpdateWord
            // 
            toUpdateWord.Location = new Point(277, 29);
            toUpdateWord.Name = "toUpdateWord";
            toUpdateWord.Size = new Size(100, 23);
            toUpdateWord.TabIndex = 5;
            toUpdateWord.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(217, 32);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 4;
            label7.Text = "Word";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(191, 64);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 3;
            label6.Text = "New Meaning";
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(60, 53);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // updateBox
            // 
            updateBox.Location = new Point(60, 24);
            updateBox.Name = "updateBox";
            updateBox.Size = new Size(100, 23);
            updateBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 27);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 0;
            label5.Text = "Enter";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(sugBtn);
            tabPage4.Controls.Add(sugTxtBox);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(468, 184);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Suggestions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(388, 108);
            dataGridView1.TabIndex = 2;
            // 
            // sugBtn
            // 
            sugBtn.Location = new Point(154, 21);
            sugBtn.Name = "sugBtn";
            sugBtn.Size = new Size(75, 23);
            sugBtn.TabIndex = 1;
            sugBtn.Text = "Enter";
            sugBtn.UseVisualStyleBackColor = true;
            sugBtn.Click += sugBtn_Click;
            // 
            // sugTxtBox
            // 
            sugTxtBox.Location = new Point(30, 21);
            sugTxtBox.Name = "sugTxtBox";
            sugTxtBox.Size = new Size(100, 23);
            sugTxtBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(addMeaningBtn);
            tabPage5.Controls.Add(addBtn);
            tabPage5.Controls.Add(newWord);
            tabPage5.Controls.Add(addMeaning);
            tabPage5.Controls.Add(addBox);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(label8);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(468, 184);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Add Word";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // addMeaningBtn
            // 
            addMeaningBtn.Location = new Point(295, 80);
            addMeaningBtn.Name = "addMeaningBtn";
            addMeaningBtn.Size = new Size(75, 25);
            addMeaningBtn.TabIndex = 7;
            addMeaningBtn.Text = "Enter";
            addMeaningBtn.UseVisualStyleBackColor = true;
            addMeaningBtn.Click += addMeaningBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(83, 50);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 6;
            addBtn.Text = "Enter";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // newWord
            // 
            newWord.Location = new Point(295, 18);
            newWord.Name = "newWord";
            newWord.Size = new Size(100, 23);
            newWord.TabIndex = 5;
            // 
            // addMeaning
            // 
            addMeaning.Location = new Point(295, 51);
            addMeaning.Name = "addMeaning";
            addMeaning.Size = new Size(100, 23);
            addMeaning.TabIndex = 4;
            addMeaning.TextChanged += textBox2_TextChanged;
            // 
            // addBox
            // 
            addBox.Location = new Point(83, 21);
            addBox.Name = "addBox";
            addBox.Size = new Size(100, 23);
            addBox.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(245, 21);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 2;
            label10.Text = "Word";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(235, 59);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 1;
            label9.Text = "Meaning";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 21);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 0;
            label8.Text = "Word";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 344);
            Controls.Add(tabControl1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            FormClosing += Search_FormClosing;
            Load += Search_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
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
        private TextBox deleteBox;
        private Label label4;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox updateBox;
        private Label label5;
        private Label label6;
        private TextBox updatedMeaning;
        private TextBox toUpdateWord;
        private Label label7;
        private Button updatingBtn;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox addMeaning;
        private TextBox addBox;
        private TextBox newWord;
        private Button addMeaningBtn;
        private Button addBtn;
        private TextBox sugTxtBox;
        private Button sugBtn;
        private DataGridView dataGridView1;
    }
}