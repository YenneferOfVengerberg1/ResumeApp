using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class GetNameView
    {
        public static string GetName()
        {
            Console.WriteLine("Hello, please input your name:");
            return Console.ReadLine();
        }
    }
}
