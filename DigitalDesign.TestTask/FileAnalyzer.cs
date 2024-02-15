using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDesign.TestTask
{
    class FileAnalyzer
    {
        public void Analyze(string inputFilePath, string outputFilePath)
        {
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Файл не найден");
                return;
            }

            try
            {
                WordCounter counter = new WordCounter(inputFilePath);
                Dictionary<string, int> wordCount = counter.CountWords();
                SaveToFile(wordCount, outputFilePath);
                Console.WriteLine("Файл соранен в " + outputFilePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Проблема с чтением файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ислючение: {ex.Message}");
            }
        }

        private void SaveToFile(Dictionary<string, int> wordCount, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var pair in wordCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{pair.Key}\t{pair.Value}");
                }
            }
        }
    }
}
