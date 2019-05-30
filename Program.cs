using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume();
            User user = new User();
            Console.WriteLine("Hello, please input your name:");          
            user.Name = Console.ReadLine();

            Console.WriteLine("Input your surname:");
            user.Surname = Console.ReadLine();
            resume.User = user;

            Console.WriteLine("What format do you want?");
            Console.WriteLine("1: .xml");
            Console.WriteLine("2: .json");
            string extencion = Console.ReadLine();

            if (extencion == "1")
            {
                Xml xml = new Xml();
                resume.Format = xml;
            } else if (extencion == "2")
            {
                Json json = new Json();
                resume.Format = json;
            }
            else
            {
                Console.WriteLine("Your input on format was wrong");
            }

            SaveManager saveManager = new SaveManager();
            saveManager.Save(resume);
            
        }
    }
}
