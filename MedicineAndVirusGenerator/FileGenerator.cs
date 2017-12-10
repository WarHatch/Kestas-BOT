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
        private static Random _random = new Random();

        public FileGenerator(string filename)
        {
            _filename = filename;
        }

        public void WriteToFile(string text)
        {
            using (StreamWriter sw = File.CreateText(_filename))
            {
                sw.Write(text);
            }
        }

        public void KestasGenerate(int lines)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lines; i++)
            {
                sb.Append(RandomString(8));
                for (int j = 0; j < 10; j++)
                {
                    string boolValue = _random.Next(0, 2).ToString();
                    sb.Append(" ").Append(boolValue);
                }
                sb.AppendLine();
            }
            string generatedText = sb.ToString();

            WriteToFile(generatedText);
        }

        public void BinaryGenerate(int lines, int lineLength)
        {
            StringBuilder sb = new StringBuilder();

            ///generate lines except last one
            for (int i = 0; i < lines-1; i++)
            {
                ///generate last bool in line
                for (int j = 0; j < lineLength-1; j++)
                {
                    string boolValue = _random.Next(0, 2).ToString();
                    sb.Append(boolValue).Append(" ");
                }
                string lastBool = _random.Next(0, 2).ToString();
                sb.Append(lastBool);
                sb.AppendLine();
            }
            ///generate last line in file
            for (int j = 0; j < lineLength - 1; j++)
            {
                string boolValue = _random.Next(0, 2).ToString();
                sb.Append(boolValue).Append(" ");
            }
            ///generate last bool in file
            string lastFileBool = _random.Next(0, 2).ToString();
            sb.Append(lastFileBool);

            string generatedText = sb.ToString();

            WriteToFile(generatedText);
        }

        public void IntegerGenerate(int lines, int lineLength, int maxInteger)
        {
            maxInteger++;

            StringBuilder sb = new StringBuilder();

            ///generate lines except last one
            for (int i = 0; i < lines - 1; i++)
            {
                ///generate last bool in line
                for (int j = 0; j < lineLength - 1; j++)
                {
                    string intValue = _random.Next(0, maxInteger).ToString();
                    sb.Append(intValue).Append(" ");
                }
                string lastInt = _random.Next(0, maxInteger).ToString();
                sb.Append(lastInt);
                sb.AppendLine();
            }
            ///generate last line in file
            for (int j = 0; j < lineLength - 1; j++)
            {
                string intValue = _random.Next(0, maxInteger).ToString();
                sb.Append(intValue).Append(" ");
            }
            ///generate last bool in file
            string lastFileInt = _random.Next(0, maxInteger).ToString();
            sb.Append(lastFileInt);

            string generatedText = sb.ToString();

            WriteToFile(generatedText);
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }


    }
}
