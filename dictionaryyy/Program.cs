namespace Dictionary
{

    //public class TrieNode
    //{
    //    public Dictionary<char, TrieNode> Children { get; set; }
    //    public string Meaning { get; set; }
    //    public string FullWord { get; set; }
    //    public bool IsEndOfWord { get; set; }

    //    public TrieNode()
    //    {
    //        Children = new Dictionary<char, TrieNode>();
    //        IsEndOfWord = false;
    //    }
    //}

    //public class Trie
    //{
    //    private TrieNode root;

    //    public Trie()
    //    {
    //        root = new TrieNode();
    //    }

    //    public void Insert(string word, string meaning)
    //    {
    //        TrieNode current = root;

    //        foreach (char ch in word)
    //        {
    //            if (!current.Children.ContainsKey(ch))
    //            {
    //                current.Children[ch] = new TrieNode();
    //            }
    //            current = current.Children[ch];
    //        }

    //        current.IsEndOfWord = true;
    //        current.Meaning = meaning;
    //        current.FullWord = word; // Set the full word when IsEndOfWord is true
    //    }

    //    public bool Search(string word, out string meaning)
    //    {
    //        TrieNode current = root;

    //        foreach (char ch in word)
    //        {
    //            if (!current.Children.TryGetValue(ch, out current))
    //            {
    //                meaning = string.Empty;
    //                return false; // Word not found
    //            }
    //        }

    //        if (current.IsEndOfWord)
    //        {
    //            meaning = current.Meaning;

    //           // Console.WriteLine("Full word: " + current.FullWord); // Access the full word
    //            return true; // Word found
    //        }

    //        meaning = string.Empty;
    //        return false; // Prefix of another word
    //    }
    class Map<TKey, TValue>
    {
        private class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        private Node Insert(Node node, TKey key, TValue value)
        {
            if (node == null)
            {
                return new Node(key, value);
            }

            if (Comparer<TKey>.Default.Compare(key, node.Key) < 0)
            {
                node.Left = Insert(node.Left, key, value);
            }
            else if (Comparer<TKey>.Default.Compare(key, node.Key) > 0)
            {
                node.Right = Insert(node.Right, key, value);
            }
            else
            {
                // Key already exists, update the value
                node.Value = value;
            }

            return node;
        }

        private Node Find(Node node, TKey key)
        {
            if (node == null || Comparer<TKey>.Default.Compare(key, node.Key) == 0)
            {
                return node;
            }

            if (Comparer<TKey>.Default.Compare(key, node.Key) < 0)
            {
                return Find(node.Left, key);
            }
            else
            {
                return Find(node.Right, key);
            }
        }

        private void Print(Node node)
        {
            if (node != null)
            {
                Print(node.Left);
                Console.WriteLine($"Key: {node.Key}, Value: {node.Value}");
                Print(node.Right);
            }
        }

        public void Insert(TKey key, TValue value)
        {
            root = Insert(root, key, value);
        }

        public bool Find(TKey key, out TValue value)
        {
            Node result = Find(root, key);
            if (result != null)
            {
                value = result.Value;
                return true;
            }
            value = default(TValue);
            return false;
        }

        public void Print()
        {
            Print(root);
        }
    }

    class TrieNode
    {
        public Map<char, TrieNode> Children { get; set; }
        public bool IsEndOfWord { get; set; }

        public string meaning { get; set; }
        public TrieNode()
        {
            Children = new Map<char, TrieNode>();
            IsEndOfWord = false;
        }
    }

    public class Trie
    {
        TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word, string meaning)
        {
            TrieNode node = root;
            TrieNode outNode = null;
            foreach (char ch in word)
            {
                if (!node.Children.Find(ch, out outNode))
                {
                    node.Children.Insert(ch, new TrieNode());

                }
                node.Children.Find(ch, out node);


            }
            node.IsEndOfWord = true;
            node.meaning = meaning;
        }

        public bool Search(string word)
        {
            TrieNode outNode = null;
            TrieNode node = root;
            foreach (char ch in word)
            {
                if (!node.Children.Find(ch, out outNode))
                {
                    return false;
                }
                node = outNode;

            }
            return node.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = root;
            TrieNode outNode = null;
            foreach (char ch in prefix)
            {
                if (!node.Children.Find(ch, out outNode))
                {
                    return false;
                }
                node = outNode;
            }
            return true;
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
               
                MessageBox.Show("Error reading file: " + ex.Message);
                Console.WriteLine("Error reading file: " + ex.Message);
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
            Trie abc;
            Trie abcd;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}