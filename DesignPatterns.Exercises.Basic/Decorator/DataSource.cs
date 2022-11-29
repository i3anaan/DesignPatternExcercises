using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Basic.Decorator
{
    public class DataSource
    {
        public const string DataFileLocation = "../../../../DesignPatterns.Exercises.Basic/Decorator/Data.txt";

        public void WriteData(string data)
        {
            using var file = File.Open(DataFileLocation, FileMode.Truncate);
            using var streamWriter = new StreamWriter(file);
            streamWriter.Write(data);
        }

        public string ReadData()
        {
            using var file = File.Open(DataFileLocation, FileMode.OpenOrCreate);
            using var streamReader = new StreamReader(file);
            var data = streamReader.ReadToEnd();
            
            // Break here if desired
            return data;
        }
    }
}
