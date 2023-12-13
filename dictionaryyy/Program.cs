using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{

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
        public bool HasCapitalLetter(string input)
        {
            // Convert the entire string to lowercase
            string lowercaseInput = input.ToLower();

            // Check if the original string contains any capital letters
            return !input.Equals(lowercaseInput);
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
        public void Delete(string word)
        {
            Delete(root, word, 0);
        }

        private void Delete(TrieNode current, string word, int index)
        {
            if (index == word.Length)
            {
                current.IsEndOfWord = false;
                return;
            }

            Delete(current.children[word[index] - 'a'], word, index + 1);

            // If this is a leaf node (no children) and not the end of another word, we can safely remove it.
            if (current.children.All(child => child == null) && !current.IsEndOfWord)
            {
                current.children = null;
            }
        }


        public bool Load(string filename)
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
                    return true;
                }
                else
                    throw new FileNotFoundException("File not found: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
                Console.WriteLine("Error reading file: " + ex.Message);
                return false;
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

        public StringLinkedList AutoComplete(string prefix)
        {
            StringLinkedList list = new StringLinkedList();
            TrieNode current = root;
            if (HasCapitalLetter(prefix))
            {
                prefix= prefix.ToLower();
            }
            foreach (char ch in prefix)
            {
                if (current.children[ch - 'a'] == null)
                {
                    return list;
                }
                current = current.children[ch - 'a'];
            }

            AutoCompleteHelper(current, prefix, list);

            return list;
        }

        private void AutoCompleteHelper(TrieNode node, string currentPrefix, StringLinkedList list)
        {
            if (node == null)
                return;

            if (node.IsEndOfWord)
            {
                list.AddSorted(currentPrefix);
            }
            for (int i = 0; i < 26; i++)
            {
                if (node.children[i] != null)
                {
                    char nextChar = (char)('a' + i);
                    AutoCompleteHelper(node.children[i], currentPrefix + nextChar, list);
                }
            }        }


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
        //this function will return the list of 10 word that have the same prefi
        public bool ContainsNonAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return true; // Input contains a non-alphabetic character
                }
            }
            return false; // Input contains only alphabets
        }

    }


    public class StringLinkedList
    {
        public class Node
        {
            public string Value { get; set; }
            public Node Next { get; set; }

            public Node(string val)
            {
                Value = val;
                Next = null;
            }
        }

        private Node head;

        public StringLinkedList()
        {
            head = null;
        }


        public void AddSorted(string value)
        {
            Node newNode = new Node(value);

            if (head == null || string.Compare(value, head.Value, StringComparison.OrdinalIgnoreCase) < 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node current = head;

            while (current.Next != null && string.Compare(value, current.Next.Value, StringComparison.OrdinalIgnoreCase) > 0)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public string[] ToArray()
        {
            int size = Count();
            string[] result = new string[size];

            Node current = head;
            int index = 0;

            while (current != null)
            {
                result[index++] = current.Value;
                current = current.Next;
            }

            return result;
        }

        public int Count()
        {
            int count = 0;
            Node current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
        ~StringLinkedList()
        {
            Node current = head;
            while (current != null)
            {
                Node next = current.Next;
                current = null; // Release the reference to the current node
                current = next;
            }
            head = null;

        }

    }


    internal static class Program
    {
        /// <summary/>
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