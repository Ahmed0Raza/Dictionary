namespace Dictionary
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            richTextBox3 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(2, 50);
            btn3.Name = "btn3";
            btn3.Size = new Size(151, 64);
            btn3.TabIndex = 3;
            btn3.Text = "Home";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(149, 50);
            btn4.Name = "btn4";
            btn4.Size = new Size(177, 64);
            btn4.TabIndex = 4;
            btn4.Text = "Search";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(322, 50);
            btn5.Name = "btn5";
            btn5.Size = new Size(151, 64);
            btn5.TabIndex = 5;
            btn5.Text = "About";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button3_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(59, 120);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(366, 139);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
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
            richTextBox1.TabIndex = 7;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "                     Welcome to Your Dictionary";
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
            richTextBox2.TabIndex = 8;
            richTextBox2.TabStop = false;
            richTextBox2.Text = "             Explore words with ease in our app's handy dictionary!";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 288);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox3);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private RichTextBox richTextBox3;
    }
}