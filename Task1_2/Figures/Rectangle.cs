using System;
using System.Collections.Generic;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.Figures
{
    /// <summary>
    ///  Class Rectangle.
    ///   The class allows you to find the area and perimeter of a Rectangle.
    /// </summary>
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

        /// <summary>
        ///  Method GetHashCode.
        ///  Ьethod gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => Parties.GetHashCode() * Parties.Count;

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
