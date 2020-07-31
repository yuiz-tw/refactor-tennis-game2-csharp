using System.Collections.Generic;
using System.Linq;

namespace RefactortingTennisGame2.Constants
{
    public static class ScoreRule
    {
        private static readonly Dictionary<int, string> Rule = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public static string GetResultByPoint(int point)
        {
            return Rule.Keys.Contains(point) 
                ? Rule[point]
                : null;
        }
    }
}