using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    class Presenter
    {     
        public string GetName()
        {
            return GetNameView.GetName();
        }
    }
}
