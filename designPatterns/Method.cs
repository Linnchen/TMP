using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _15012020_design_patterns
{
    abstract class Method
    {
        public string Path;

        public abstract List<string> Execute();
    }

    class BinaryRead : Method
    {
        public BinaryRead(string pPath)
        {
            Path = pPath;            
        }

        public override List<string> Execute()
        {
            List<string> result = new List<string>();

            using (BinaryReader reader = new BinaryReader(File.Open(Path, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    int number = reader.ReadInt32();
                    result.Add(Convert.ToString(number));
                }
            }

            return result;
        }
    }

    class TextRead : Method
    {
        public TextRead(string pPath)
        {
            Path = pPath;
        }

        public override List<string> Execute()
        {
            List<string> result = new List<string>();

            using (StreamReader reader = new StreamReader(File.Open(Path, FileMode.Open)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {                  
                    result.Add(line);
                }
            }

            return result;
        }
    }
}
