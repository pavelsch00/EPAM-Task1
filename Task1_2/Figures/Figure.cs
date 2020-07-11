using System;
using System.Collections.Generic;
using System.Text;
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

        public string FigureType { get; set; }

        public List<double> Parties { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Parties)
            {
                stringBuilder.Append(item).Append(" ");
            }

            return $"FigureType: Figure Type: {FigureType}\n Parties: {stringBuilder}";
        }
    }
}
