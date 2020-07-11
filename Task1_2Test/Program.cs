using System;
using System.Linq;
using Task1_2.Figures;
using Task1_2.FiguresExtensions;

namespace Task1_2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Figures.txt";

            //Square square = new Square();

            var temp = ParseFigure.GetFigure(path);

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
