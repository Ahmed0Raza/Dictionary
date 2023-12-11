namespace Dictionary
{
    public partial class Form1 : Form
    {
        Trie dictionary = new Trie();
        
        public Form1()
        {

            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            dictionary.Save("dictionary.txt");
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data from file into the Trie
            if(dictionary.Load("dictionary.txt"))
            {
                textBoxLoad.Text = "Dictionary loaded successfully!";
            }
            else
            {
                textBoxLoad.Text = "Error: Dictionary not loaded !";
            }
            dictionary.Save("dictionary.txt");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search obj;
            obj = new Search(dictionary);
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            About obj1;
            obj1 = new About(dictionary);
            obj1.ShowDialog();
        }

        private void textBoxLoad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
