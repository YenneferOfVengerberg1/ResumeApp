using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace ResumeApp
{
    public interface IFormat
    {        
        void Save(User user);
    }

    public class Xml: IFormat
    { 
        void IFormat.Save(User user)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(User));

            using (FileStream fs = new FileStream($"Resume of {user.Name} {user.Surname}.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fs, user);
            }
        }
    }

    public class Json : IFormat
    {
        public string Extension { get; set; } = ".json";
        void IFormat.Save(User user)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(User));

            using (FileStream fs = new FileStream($"Resume of {user.Name} {user.Surname}.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, user);
            }
        }
    }
}
