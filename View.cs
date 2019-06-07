using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class View
    {
        public string GetName()
        {
            Console.WriteLine("Hello, please input your name:");          
            return Console.ReadLine();
        }

        public string GetSurname()
        {
            Console.WriteLine("Input your surname:");
            return Console.ReadLine();
        }

        public string GetFormat()
        {
            Console.WriteLine("What format do you want?");
            Console.WriteLine("1: .xml");
            Console.WriteLine("2: .json");
            return Console.ReadLine();
        }

        public void Exception()
        {
            Console.WriteLine("Your input on format was wrong");
        }
    }
}
