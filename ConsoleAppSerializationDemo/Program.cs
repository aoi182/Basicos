using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppSerializationDemo
{
    internal class Program
    {
        private const string FileName = @"..\..\SavedDictionary.bin";

        private static Dictionary<string, int> _dictionary = new Dictionary<string, int>
        {

        };

        private static void Main(string[] args)
        {
            //Deserialize();

            for (int i = 0; i < 1000; i++)
            {
                var x = i;
            }
        }

        private static void Deserialize()
        {
            Stream testFileStream = File.OpenRead(FileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            _dictionary = (Dictionary<string, int>) deserializer.Deserialize(testFileStream);
            testFileStream.Close();
        }

        private static void Serialize()
        {
            Stream testFileStream = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(testFileStream, _dictionary);
            testFileStream.Close();
        }
    }
}