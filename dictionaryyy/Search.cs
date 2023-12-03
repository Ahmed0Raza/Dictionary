using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
                MessageBox.Show("Word not found!");
                SearchBox.Text = string.Empty;
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void deleteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string toDelete = deleteBox.Text;
            if (!passedDictionary.Delete(toDelete))
            {
                MessageBox.Show("Word not found!");
            }
            else
            {
                MessageBox.Show("Deleted Succesfully!");
            }
            deleteBox.Text = string.Empty;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string word = updateBox.Text;
            string meaning = null;
            if (!passedDictionary.Search(word, ref meaning))
            {
                updateBox.Text = string.Empty;
                MessageBox.Show("Word not found!");
                toUpdateWord.Enabled = false;
                updatedMeaning.Enabled = false;
            }
            else
            {
                toUpdateWord.Enabled = true;
                updatedMeaning.Enabled = true;
                updateBox.Text = string.Empty;
                MessageBox.Show("Word found, Please enter the updated meaning of word in below box.");
                toUpdateWord.Text = word;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatingBtn_Click(object sender, EventArgs e)
        {
            string word = toUpdateWord.Text;
            string meaning;
            meaning = updatedMeaning.Text;
            passedDictionary.Insert(word, meaning);
            MessageBox.Show("Meaning Updated!");
            toUpdateWord.Text = string.Empty;
            updatedMeaning.Text = string.Empty;

        }

        private void Search_Load(object sender, EventArgs e)
        {
            toUpdateWord.Enabled = false;
            updatedMeaning.Enabled = false;
        }
    }
}
