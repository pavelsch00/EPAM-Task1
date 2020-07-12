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

            return Math.Round(Math.Sqrt(p * (p - Parties[0]) * (p - Parties[1]) * (p - Parties[2])), 2);
        }

        public double GetPerimeter()
        {
            return Math.Round(Parties.Sum(), 2);
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

        public override int GetHashCode()
        {
            return Parties.GetHashCode() * Parties.Count;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            Triangle triangle = (Triangle)obj;

            for (int i = 0; i < Parties.Count; i++)
            {
                if (Parties[i] != triangle.Parties[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
