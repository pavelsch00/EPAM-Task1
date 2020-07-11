using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    public class Circle : IFigure
    {
        public Circle(string figureType, List<double> parties)
        {
            FigureType = figureType;
            Parties = parties;
        }

        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Parties[0], 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Parties[0];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Parties)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return $"Figure Type: {FigureType}\n Parties: {stringBuilder}\n Area: {GetArea()}\n Perimetr: {GetPerimeter()}\n Hash: {GetHashCode()}";
        }

        public override int GetHashCode()
        {
            return Parties.GetHashCode() * Parties.Count;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            Circle circle = (Circle)obj;

            return GetArea() == circle.GetArea();
        }
    }
}
