using System;
using System.IO;

namespace Task1_2.FileExtensions
{
    /// <summary>
    ///  Class FileExtension.
    ///  The class reads lines from a file into an array of strings.
    /// </summary>
    public class FileExtension
    {
        /// <summary>
        ///  Class FileExtension.
        ///  The class reads lines from a file into an array of strings.
        ///  Input parameters: string (path in file).
        ///  Returned value: string[.
        /// </summary>
        public static string[] GetFromFile(string path)
        {
            string figure;
            var figures = new string[File.ReadAllLines(path).Length];

            try
            {
                using var sr = new StreamReader(path);
                for (int i = 0; (figure = sr.ReadLine()) != null; i++)
                {
                    figures[i] = figure;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return figures;
        }
    }
}
