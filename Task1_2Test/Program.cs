using System;
using System.Linq;
using Task1_2.FiguresExtensions;

namespace Task1_2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Figures.txt";

            var temp = ParseFigure.GetFigures(path);

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
