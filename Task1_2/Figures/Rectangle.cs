using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    public class Rectangle : IFigure
    {
        public Rectangle(string figureType, List<double> parties)
        {
            FigureType = figureType;
            Parties = parties;
        }

        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        public double GetArea()
        {
            return Parties[0] * Parties[1];
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
