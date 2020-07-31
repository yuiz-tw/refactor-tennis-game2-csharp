namespace RefactortingTennisGame2
{
    class EqualScoreCalculator : IScoreCalculator
    {
        private readonly int point;

        public EqualScoreCalculator(int point)
        {
            this.point = point;
        }

        public string GetScore()
        {
            if (point >= 3)
            {
                return "Deuce";
            }

            if (point < 4)
            {
                return ScoreRule.GetResultByPoint(point) + "-All";
            }

            return null;
        }
    }
}