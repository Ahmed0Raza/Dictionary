namespace Dictionary
{

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }
        public string Meaning { get; set; }
        public string FullWord { get; set; }
        public bool IsEndOfWord { get; set; }

        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word, string meaning)
        {
            TrieNode current = root;

            foreach (char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children[ch] = new TrieNode();
                }
                current = current.Children[ch];
            }

            current.IsEndOfWord = true;
            current.Meaning = meaning;
            current.FullWord = word; // Set the full word when IsEndOfWord is true
        }

        public bool Search(string word, out string meaning)
        {
            TrieNode current = root;

            foreach (char ch in word)
            {
                if (!current.Children.TryGetValue(ch, out current))
                {
                    meaning = string.Empty;
                    return false; // Word not found
                }
            }

            if (current.IsEndOfWord)
            {
                meaning = current.Meaning;

               // Console.WriteLine("Full word: " + current.FullWord); // Access the full word
                return true; // Word found
            }

            meaning = string.Empty;
            return false; // Prefix of another word
        }

        public void Load(string filename)
        {
            try
            {
                using (StreamReader file = new StreamReader(filename))
                {
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] parts = line.Split(' ');
                        string word = parts[0];
                        string meaning = parts[1];

                        // Remove any punctuation or special characters from the word
                        word = new string(word.ToCharArray().Where(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)).ToArray());

                        Insert(word, meaning);
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}