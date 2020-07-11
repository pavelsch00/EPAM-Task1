using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    public class Polygon : IFigure
    {
        public Polygon(string figureType, List<double> parties, int [,] points)
        {
            FigureType = figureType;
            Parties = parties;
            Points = points;
        }

        public Polygon(string figureType, List<double> parties)
        {
            FigureType = figureType;
            Parties = parties;
        }

        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        public int[,] Points { get; set; }

        public double GetArea()
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < Points.GetLength(1) - 1; i++)
            {
                sum1 += Points[0, i] * Points[1, i];
                sum2 += Points[1, i] * Points[0, i + 1];
            }

            return Math.Abs((sum1 - sum2) / 2d);
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

        public override int GetHashCode()
        {
            return Parties.GetHashCode() * Parties.Count;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            Polygon polygon = (Polygon)obj;

            for (int i = 0; i < Parties.Count; i++)
            {
                if (Parties[i] != polygon.Parties[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
