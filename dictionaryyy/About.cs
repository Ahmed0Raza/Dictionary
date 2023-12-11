using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
   
    public partial class About : Form
    {
        protected static Trie passedAboutDict=new Trie();
        public About()
        {
            InitializeComponent();
        }
        public  About(Trie dict)
        {
            passedAboutDict = dict;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            passedAboutDict.Save("dictionary.txt");
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj3;
            obj3 = new Form1();
            obj3.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search obj4;
            obj4 = new Search();
            obj4.ShowDialog();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
