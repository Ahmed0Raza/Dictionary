using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Dictionary
{

    public partial class Search : Form
    {
        protected static Trie passedDictionary;
        public Search()
        {

            InitializeComponent();
        }
        public Search(Trie dict)
        {
            passedDictionary = dict;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Save the input from the TextBox
            string userInput = deleteBox.Text;

            // Display the input or perform other actions
            MessageBox.Show($"Input saved: {userInput}", "Information");

            // Clear the TextBox after saving
            deleteBox.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word = updateBox.Text;

            // You can display the input or perform other actions here
            MessageBox.Show($"Input saved: {word}", "Information");

            // Clear the TextBox after saving
            updateBox.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
