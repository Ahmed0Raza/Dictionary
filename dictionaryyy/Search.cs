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



        private void MeaningBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            wordBox.Text = string.Empty;
            meaningBox.Text = string.Empty;

            string word;
            string meaning;
            word = SearchBox.Text;
            meaning = null;
            if (passedDictionary.Search(word, ref meaning))
            {
                SearchBox.Text = string.Empty;
                wordBox.Text = word;
                meaningBox.Text = meaning;

            }
            else
            {
                SearchBox.Text = string.Empty;
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
