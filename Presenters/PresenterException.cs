using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Presenters
{
    class PresenterException
    {
        public string Exception()
        {
            return GetNameView.GetName();
        }
    }
}
