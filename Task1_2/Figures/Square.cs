using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1_2.Figures
{
    public class Square : Figure
    {
        public Square(Figure figure)
        {
            FigureType = figure.FigureType;
            Parties = figure.Parties;
        }

        public double GetArea()
        {
            return Parties[0] * 4;
        }

        public double GetPerimeter()
        {
            return Parties.Sum();
        }
    }
}
