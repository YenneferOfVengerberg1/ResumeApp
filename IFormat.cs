using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    public interface IFormat
    {
        string Extension { get; set; }    
    }

    public class Xml: IFormat
    {
        public string Extension { get; set; } = ".xml";

    }

    public class Json : IFormat
    {
        public string Extension { get; set; } = ".json";
    }
}
