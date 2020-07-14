using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    /// <summary>
    ///  Class Polygon.
    ///   The class allows you to find the area and perimeter of a Polygon.
    /// </summary>
    public class Polygon : IFigure
    {
        #region Constructor
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
        #endregion

        #region Properties
        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        public int[,] Points { get; set; }
        #endregion

        #region Methods
        public double GetPerimeter() => Math.Round(Parties.Sum(), 2);

        /// <summary>
        ///  Method GetHashCode.
        ///  Method gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => Parties.GetHashCode() * Parties.Count;

        public double GetArea()
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < Points.GetLength(1) - 1; i++)
            {
                sum1 += Points[0, i] * Points[1, i];
                sum2 += Points[1, i] * Points[0, i + 1];
            }

            return Math.Round(Math.Abs((sum1 - sum2) / 2d), 2);
        }

        /// <summary>
        ///  Method ToString.
        ///  Allows you to get class status information as a string.
        ///  Input parameters: null.
        ///  Returned value: string.
        /// </summary>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Parties)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return $"Figure Type: {FigureType}\n Parties: {stringBuilder}\n Area: {GetArea()}\n Perimetr: {GetPerimeter()}\n";
        }

        /// <summary>
        ///  Method Equals.
        ///  Lets you compare two objects.
        ///  Input parameters: object.
        ///  Returned value: bool.
        /// </summary>
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
        #endregion
    }
}
