using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDesign.TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (true)
            {
                menu.Show();
                string option = Console.ReadLine();
                menu.PerformAction(option);
            }
        }
    }
    
}
