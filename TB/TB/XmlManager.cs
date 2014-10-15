using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace TB
{
    public class XmlManager<T>
    {
        public Type Type;

        public T Load(string Path)
        {
            T instance;
            using (TextReader reader = new StreamReader(Path))
            {

                XmlSerializer xml = new XmlSerializer(Type);
                instance = (T)xml.Deserialize(reader);
            }
            return instance;
        }

        public void Save(string Path, object obj)
        {
            using (TextWriter writer = new StreamWriter(Path))
            {
                XmlSerializer xml = new XmlSerializer(Type);
                xml.Serialize(writer, obj);
            }
        }
    }
}
