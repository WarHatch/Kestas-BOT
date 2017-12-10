using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineAndVirusGenerator
{
    class FileGenerator
    {
        string _filename;
        private static Random random = new Random();

        public FileGenerator(string filename)
        {
            _filename = filename;
        }

        public void GenerateFile(int lines)
        {
            string generatedText = GenerateText(lines);

            using (StreamWriter sw = File.CreateText(_filename))
            {
                sw.Write(generatedText);
            }
        }

        private string GenerateText(int lines)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i<lines; i++)
            {
                sb.Append(RandomString(8));
                for (int j = 0; j<10; j++)
                {
                    string boolValue = random.Next(0, 2).ToString();

                    sb.Append(" ").Append(boolValue);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
