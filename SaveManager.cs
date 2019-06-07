using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResumeApp
{
    class SaveManager
    {
        public void Save(Resume resume)
        {
            string fileName = $"Resume of {resume.User.Name} {resume.User.Surname}";          
            string path = $"E:\\Work\\{fileName}";
            path = Path.ChangeExtension(path, $"{resume.Format.Extension}");
            File.WriteAllText(path, $"{resume.User.Name} {resume.User.Surname}");
        }
    }
}
