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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            passedDictionary.Save("dictionary.txt");
            base.OnFormClosing(e);
            Application.Exit();
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
            string meaning = null;
            if (passedDictionary.Search(toDelete, ref meaning))
            {
                passedDictionary.Delete(toDelete);
                MessageBox.Show("Deleted Succesfully!");
            }
            else
            {
                MessageBox.Show("Word not found!");
            }
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
                updatingBtn.Enabled = false;
            }
            else
            {
                updatingBtn.Enabled = true;
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
            toUpdateWord.Enabled = false;
            updatedMeaning.Enabled = false;
            updatingBtn.Enabled = false;

        }

        private void Search_Load(object sender, EventArgs e)
        {
            passedDictionary.Save("dictionary.txt");
            newWord.Enabled = false;
            addMeaning.Enabled = false;
            addMeaningBtn.Enabled = false;
            toUpdateWord.Enabled = false;
            updatedMeaning.Enabled = false;
            updatingBtn.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string toAdd = addBox.Text;
            string meaning = null;

            if (passedDictionary.Search(toAdd, ref meaning))
            {
                MessageBox.Show("Word is already saved!");
                newWord.Enabled = false;
                addMeaning.Enabled = false;
                addMeaningBtn.Enabled = false;
            }
            else
            {
                if (toAdd.Length > 0)
                {
                    newWord.Enabled = true;
                    addMeaning.Enabled = true;
                    addMeaningBtn.Enabled = true;
                    newWord.Text = toAdd;
                    addBox.Clear();

                }

            }
        }

        private void addMeaningBtn_Click(object sender, EventArgs e)
        {
            string Mean = addMeaning.Text;
            string wordToAdd = newWord.Text;
            passedDictionary.Insert(wordToAdd, Mean);
            newWord.Enabled = false;
            addMeaning.Enabled = false;
            addMeaningBtn.Enabled = false;
            newWord.Clear();
            addMeaning.Clear();
            MessageBox.Show("Inserted Successfully!");
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save to file

        }

        private void sugBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sugTxtBox.Text))
            {
                // Display a message or handle the case when sugTxtBox is empty
                MessageBox.Show("Please enter a prefix to get suggestions.");
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Words");
            int count = 0;
             
            StringLinkedList autoCompleteResults = passedDictionary.AutoComplete(sugTxtBox.Text.ToString());

            foreach (string word in autoCompleteResults.ToArray())
            {
                count++;
                if (count == 11)
                {
                    break;
                }
                dt.Rows.Add(count, word);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AllowDrop = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 30;
            sugTxtBox.Text = string.Empty;
        }




        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void sugTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
