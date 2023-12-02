namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Trie dictionary = new Trie();

            // Load data from file into the Trie
            dictionary.Load("dictionary.txt");
            textBoxLoad.Text = "Loaded ";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search obj;
            obj = new Search();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            About obj1;
            obj1 = new About();
            obj1.ShowDialog();
        }

        private void textBoxLoad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
