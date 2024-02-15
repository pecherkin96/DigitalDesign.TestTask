using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDesign.TestTask
{
    class Menu
    {
        public void Show()
        {
            Console.WriteLine("Посчитаем слова!");
            Console.WriteLine("Выбери меню:");
            Console.WriteLine("1. Проанализировать файл");
            Console.WriteLine("2. Выод");
        }

        public void PerformAction(string option)
        {
            switch (option)
            {
                case "1":
                    Start();
                    break;
                case "2":
                    Exit();
                    break;
                default:
                    InvalidOption();
                    break;
            }
        }

        private void Start()
        {
            Console.WriteLine("Уажи путь  файлу, который будем сканировать :");
            string inputFilePath = Console.ReadLine();

            Console.WriteLine("Укажи путь, куда сохранить файл с подсчётом:");
            string outputFilePath = Console.ReadLine();

            FileAnalyzer fileAnalyzer = new FileAnalyzer();
            fileAnalyzer.Analyze(inputFilePath, outputFilePath);
        }

        private void Exit()
        {
            Environment.Exit(0);
        }

        private void InvalidOption()
        {
            Console.WriteLine("Такого варианта нет. Повтори.");
        }
    }
    
}
