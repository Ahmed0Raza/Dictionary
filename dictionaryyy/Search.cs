﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Dictionary
{
    public partial class Search : Form
    {
        public Search()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            About form2 = new About();
            form2.ShowDialog();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            string word = textBoxInput.Text;
            string meaning = string.Empty;
        }

        private void MeaningBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}