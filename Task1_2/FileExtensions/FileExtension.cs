using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task1_2.FileExtensions
{
    public class FileExtension
    {
        public static string[] GetFromFile(string path)
        {
            string figure;
            var firures = new string[File.ReadAllLines(path).Length];

            try
            {
                using var sr = new StreamReader(path);
                for (int i = 0; (figure = sr.ReadLine()) != null; i++)
                {
                    firures[i] = figure;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return firures;
        }
    }
}
