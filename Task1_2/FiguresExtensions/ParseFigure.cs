using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1_2.FiguresExtensions
{
    public class ParseFigure
    {
        public static List<Figure> GetFigures(string path)
        {
            List<Figure> figures = new List<Figure>();

            string figuresType;
            string[] figuresArr = FileExtensions.FileExtension.GetFromFile(path);
            string pattern = @"([A-z]+) ([A-z]+)";
            string patternPoints = @"(\d+|-\d+)";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < figuresArr.Length; i++)
            {
                List<double> figuresSides = new List<double>();

                foreach (Match match in regex.Matches(figuresArr[i]))
                {
                    figuresType = match.Groups[1].Value;

                    Regex regexPoints = new Regex(patternPoints);

                    var matchSides = Regex.Matches(figuresArr[i], patternPoints);
                        for (int k = 0; k < matchSides.Count; k += match.Groups[2].Value == "points" ? 2 : 1)
                        {
                            if (match.Groups[2].Value == "points")
                            {
                                if(k + 2 == matchSides.Count)
                                    figuresSides.Add(FindingSideByPoints(int.Parse(matchSides[k].Groups[0].Value), int.Parse(matchSides[k + 1].Groups[0].Value), int.Parse(matchSides[0].Groups[0].Value), int.Parse(matchSides[1].Groups[0].Value)));
                                else
                                figuresSides.Add(FindingSideByPoints(int.Parse(matchSides[k].Groups[0].Value), int.Parse(matchSides[k + 1].Groups[0].Value), int.Parse(matchSides[k + 2].Groups[0].Value), int.Parse(matchSides[k + 3].Groups[0].Value)));
                            }
                            else
                            {
                                figuresSides.Add(int.Parse(matchSides[k].Groups[0].Value));
                            }
                        }

                    figures.Add(new Figure(figuresType, figuresSides));
                }
            }

            return figures;
        }

        private  static double FindingSideByPoints(int X1, int Y1, int X2, int Y2) => Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
    }
}
