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

            var temp = ParseFigure.GetFirus(path);

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Equals Figure: \n");
            Console.WriteLine(FindEqualsFigure.FindEqualsFigures(temp[1], temp)[0].ToString());
            Console.WriteLine(FindEqualsFigure.FindEqualsFigures(temp[5], temp)[1].ToString());
        }
    }
}
