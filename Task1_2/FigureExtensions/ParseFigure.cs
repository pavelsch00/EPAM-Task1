using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Task1_2.Figures;
using Task1_2.Figures.Interfaces;

namespace Task1_2.FiguresExtensions
{
    public class ParseFigure
    {
        public static IFigure[] GetFigures(string path)
        {
            string figuresType;
            string[] figuresArr = FileExtensions.FileExtension.GetFromFile(path);
            var figures = new IFigure[figuresArr.Length];
            var pattern = @"([A-z]+) ([A-z]+)";
            var patternPoints = @"(\d+|-\d+)";
            var regex = new Regex(pattern);

            for (int i = 0; i < figuresArr.Length; i++)
            {
                List<double> figuresSides = new List<double>();

                foreach (Match match in regex.Matches(figuresArr[i]))
                {
                    figuresType = match.Groups[1].Value;
                    var matchSides = Regex.Matches(figuresArr[i], patternPoints);
                    var points = new int[2, matchSides.Count / 2];

                    for (int k = 0, j = 0, d =0; k < matchSides.Count; k += match.Groups[2].Value == "points" ? 2 : 1, j++, d += 2)
                    {
                        if (match.Groups[2].Value == "points")
                        {
                            if(match.Groups[1].Value == "Polygon")
                            {
                                points[0, j] = int.Parse(matchSides[d].Groups[0].Value);
                                points[1, j] = int.Parse(matchSides[d + 1].Groups[0].Value);
                            }

                            if (k + 2 == matchSides.Count)
                                figuresSides.Add(FindingSideByPoints(int.Parse(matchSides[k].Groups[0].Value), int.Parse(matchSides[k + 1].Groups[0].Value), int.Parse(matchSides[0].Groups[0].Value), int.Parse(matchSides[1].Groups[0].Value)));
                            else
                                figuresSides.Add(FindingSideByPoints(int.Parse(matchSides[k].Groups[0].Value), int.Parse(matchSides[k + 1].Groups[0].Value), int.Parse(matchSides[k + 2].Groups[0].Value), int.Parse(matchSides[k + 3].Groups[0].Value)));
                        }
                        else
                        {
                            figuresSides.Add(int.Parse(matchSides[k].Groups[0].Value));
                        }
                    }

                    switch (match.Groups[1].Value)
                    {
                        case "Polygon":
                            figures[i] = new Polygon(figuresType, figuresSides, points);
                            break;
                        case "Square":
                            figures[i] = new Square(figuresType, figuresSides);
                            break;
                        case "Triangle":
                            figures[i] = new Triangle(figuresType, figuresSides);
                            break;
                        case "Circle":
                            figures[i] = new Circle(figuresType, figuresSides);
                            break;
                        case "Rectangle":
                            figures[i] = new Rectangle(figuresType, figuresSides);
                            break;
                        default:
                            break;
                    }
                }
            }

            return figures;
        }


        private  static double FindingSideByPoints(int X1, int Y1, int X2, int Y2) => Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)), 1);
    }
}
