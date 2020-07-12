using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    /// <summary>
    ///  Class Triangle.
    ///   The class allows you to find the area and perimeter of a Triangle.
    /// </summary>
    public class Triangle : IFigure
    {
        #region Constructor
        public Triangle(string figureType, List<double> parties)
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
        /// <summary>
        ///  Method GetHashCode.
        ///  Ьethod gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => Parties.GetHashCode() * Parties.Count;

        public double GetArea()
        {
            var p = GetPerimeter() / 2;

            return Math.Round(Math.Sqrt(p * (p - Parties[0]) * (p - Parties[1]) * (p - Parties[2])), 2);
        }

        public double GetPerimeter() => Math.Round(Parties.Sum(), 2);

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
        #endregion
    }
}
