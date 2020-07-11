using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1_2.Figures.Interfaces;

namespace Task1_2.FiguresExtensions
{
    public class FindEqualsFigure
    {
        public static IFigure[] FindEqualsFigures(IFigure figure, IFigure[] figures) => figures.Where(obj => obj.Equals(figure)).Select(m => m)?.ToArray();
    }
}
