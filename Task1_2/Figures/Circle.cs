using System;
using System.Collections.Generic;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    public class Circle : IFigure
    {
        #region Constructor
        public Circle(string figureType, List<double> parties)
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
        public double GetArea() => Math.Round(Math.PI * Math.Pow(Parties[0], 2), 2);

        public double GetPerimeter() => Math.Round(2 * Math.PI * Parties[0], 2);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Parties)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return $"Figure Type: {FigureType}\n Parties: {stringBuilder}\n Area: {GetArea()}\n Perimetr: {GetPerimeter()}\n Hash: {GetHashCode()}";
        }

        public override int GetHashCode() => Parties.GetHashCode() * Parties.Count;

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            Circle circle = (Circle)obj;

            return GetArea() == circle.GetArea();
    
        }
        #endregion
    }
}
