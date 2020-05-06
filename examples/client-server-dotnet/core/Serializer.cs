using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace core
{   
    public class Serializer
    {
        public static MemoryStream ToStream(object obj)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);

            return stream;
        }

        public static object FromStream(MemoryStream stream)
        {
            var formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);

            return formatter.Deserialize(stream);
        }
    }
}
