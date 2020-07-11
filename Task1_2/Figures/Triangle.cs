using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    public class Triangle : IFigure
    {
        public Triangle(string figureType, List<double> parties)
        {
            FigureType = figureType;
            Parties = parties;
        }


        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        public double GetArea()
        {
            var p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - Parties[0]) * (p - Parties[1]) * (p - Parties[2]));
        }

        public double GetPerimeter()
        {
            return Parties.Sum();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Parties)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return $"Figure Type: {FigureType}\n Parties: {stringBuilder}\n Area: {GetArea()}\n Perimetr: {GetPerimeter()}\n";
        }
    }
}
