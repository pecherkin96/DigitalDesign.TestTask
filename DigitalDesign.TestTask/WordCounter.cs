using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDesign.TestTask
{
    class WordCounter
    {
        private string filePath;

        public WordCounter(string filePath)
        {
            this.filePath = filePath;
        }

        public Dictionary<string, int> CountWords()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        string cleanedWord = CleanWord(word);
                        if (!string.IsNullOrEmpty(cleanedWord))
                        {
                            if (wordCount.ContainsKey(cleanedWord))
                            {
                                wordCount[cleanedWord]++;
                            }
                            else
                            {
                                wordCount[cleanedWord] = 1;
                            }
                        }
                    }
                }
            }

            return wordCount;
        }

        private string CleanWord(string word)
        {
            return new string(word.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();
        }
    }
}
