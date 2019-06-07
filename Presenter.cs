using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class Presenter
    {
        private Resume resume = new Resume();
        private User user = new User();
        private SaveManager saveManager = new SaveManager();
        private View view = new View();
        public void Start()
        {
            user.Name = view.GetName();
            user.Surname = view.GetSurname();
            resume.User = user;
            string extension = view.GetFormat();

            if (extension == "1")
            {
                Xml xml = new Xml();
                resume.Format = xml;
                saveManager.Save(resume);
            }
            else if (extension == "2")
            {
                Json json = new Json();
                resume.Format = json;
                saveManager.Save(resume);
            }
            else
            {
                view.Exception();
            }
        }
    }
}
