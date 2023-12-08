using System.Collections.Generic;

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
    public class TrieNode
    {
        public string Meaning { get; set; }
        public bool IsEndOfWord { get; set; }
        public string FullWord { get; set; }
        public TrieNode[] children { get; set; }
        public TrieNode()
        {
            children = new TrieNode[26];
            IsEndOfWord = false;
            FullWord = string.Empty;
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
                if (ch > 'z' || ch < 'a')
                {
                    continue;
                }
                if (current.children[ch - 'a'] == null)
                {
                    current.children[ch - 'a'] = new TrieNode();
                }
                current = current.children[ch - 'a'];
            }
            current.IsEndOfWord = true;
            current.Meaning = meaning;
            current.FullWord = word;
        }
        public bool Search(string word, ref string meaning)
        {
            TrieNode current = root;
            foreach (char ch in word)
            {
                if (current.children[ch - 'a'] == null)
                {
                    meaning = string.Empty;
                    return false;
                }
                current = current.children[ch - 'a'];
            }
            if (current.IsEndOfWord)
            {
                meaning = current.Meaning;
                return true;
            }
            meaning = string.Empty;
            return false;
        }
        public bool Delete(string word)
        {
            return Delete(root, word, 0);
        }
        private bool Delete(TrieNode current, string word, int index)
        {
            if (index == word.Length)
            {
                if (!current.IsEndOfWord)
                {
                    return false;
                }
                current.IsEndOfWord = false;
                return current.children == null;
            }
            if (current.children[word[index] - 'a'] == null)
            {
                return false;
            }
            bool shouldDeleteCurrentNode = Delete(current.children[word[index] - 'a'], word, index + 1) && !current.IsEndOfWord;
            if (shouldDeleteCurrentNode)
            {
                current.children[word[index] - 'a'] = null;
                return current.children == null;
            }
            return false;
        }

        public void Load(string filename)
        {
            try
            {

                string filePath = "dictionary.txt";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Use StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read the contents of the file line by line
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Split each line into words                         

                            string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                            if (words.Length > 1)
                                Insert(words[0], words[1]);

                        }
                    }
                }
                else
                    throw new FileNotFoundException("File not found: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
        //this function traverse the whole trie tree and load the word to file
        public void writeToFile(TrieNode root, string word, StreamWriter sw)
        {
            if (root == null)
                return;
            if (root.IsEndOfWord)
            {
                sw.WriteLine(word + " " + root.Meaning);
            }
            for (int i = 0; i < 26; i++)
            {
                if (root.children[i] != null)
                {
                    writeToFile(root.children[i], word + (char)(i + 'a'), sw);
                }
            }
        }
        public void Save(string filename)
        {
            try
            {
                string filePath = "dictionary.txt";
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Use StreamWriter to write to the file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Write each word to the file
                        writeToFile(root, "", writer);
                    }
                }
                else
                    throw new FileNotFoundException("File not found: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing file: " + ex.Message);
                Console.WriteLine("Error writing file: " + ex.Message);
            }
        }
        //this function will return the list of 10 word that have the same prefix
        public List<string> AutoComplete(string prefix)
        {
            List<string> list = new List<string>();
            TrieNode current = root;
            foreach (char ch in prefix)
            {
                if (current.children[ch - 'a'] == null)
                {
                    return list;
                }
                current = current.children[ch - 'a'];
            }
            if (current.IsEndOfWord)
            {
                list.Add(current.FullWord);
            }
            for (int i = 0; i < 26; i++)
            {
                if (current.children[i] != null)
                {
                    list.AddRange(AutoComplete(current.children[i], prefix + (char)(i + 'a')));
                }
            }
            return list;
        }
        public List<string> AutoComplete(TrieNode root, string prefix)
        {
            List<string> list = new List<string>();
            if (root == null)
                return list;
            if (root.IsEndOfWord)
            {
                list.Add(prefix);
            }
            for (int i = 0; i < 26; i++)
            {
                if (root.children[i] != null)
                {
                    list.AddRange(AutoComplete(root.children[i], prefix + (char)(i + 'a')));
                }
            }
            return list;
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