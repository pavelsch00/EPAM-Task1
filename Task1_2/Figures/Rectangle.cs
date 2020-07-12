using System;
using System.Collections.Generic;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    public class Rectangle : IFigure
    {
        #region Constructor
        public Rectangle(string figureType, List<double> parties)
        {
            FigureType = figureType;
            Parties = parties;
        }
        #endregion

        #region Properties
        public string FigureType { get; set; }

        public List<double> Parties { get; set; }
        #endregion

        #region Methods
        public double GetArea() => Math.Round(Parties[0] * Parties[1], 2);

        public double GetPerimeter() => Math.Round((Parties[0]+ Parties[1]) * 2, 2);

        public override int GetHashCode() => Parties.GetHashCode() * Parties.Count;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Parties)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return $"Figure Type: {FigureType}\n Parties: {stringBuilder}\n Area: {GetArea()}\n Perimetr: {GetPerimeter()}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            Rectangle rectangle = (Rectangle)obj;

            for (int i = 0; i < Parties.Count; i++)
            {
                if (Parties[i] != rectangle.Parties[i])
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
