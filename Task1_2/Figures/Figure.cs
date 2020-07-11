using System;
using System.Collections.Generic;
using Task1_2.Figures;
using Task1_2.Figures.Interfaces;

namespace Task1_2
{
    public class Figure : IFigureProperties
    {
        public Figure()
        {

        }

        public Figure(string figureType, List<double> parties)
        {
            FigureType = figureType;
            Parties = parties;
        }

        public Figure(string figureType, List<Point> points)
        {
            FigureType = figureType;
            for (int i = 0; i < points.Count; i =+ 2)
            {
                Parties.Add(GetSide(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y));
            }  
        }

        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        private double GetSide(int X1, int Y1, int X2, int Y2) => Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
    }
}
