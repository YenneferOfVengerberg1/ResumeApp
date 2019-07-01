using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class GetFormatView
    {
        public static int GetFormat()
        {
            Console.WriteLine("Please input prefered format:");
            Console.WriteLine("0: .xml");
            Console.WriteLine("1: .json");
            return int.Parse(Console.ReadLine());
        }
    }
}
