using RefactortingTennisGame2.Constants;

namespace RefactortingTennisGame2.ScoreCalculator
{
    class UnequalScoreCalculator : IScoreCalculator
    {
        private readonly Player frontRunner;
        private readonly Player follower;

        public UnequalScoreCalculator(Player frontRunner, Player follower)
        {
            this.frontRunner = frontRunner;
            this.follower = follower;
        }

        public string GetScore()
        {
            if (frontRunner.Point >= 4 && follower.Point >= 0 && (frontRunner.Point - follower.Point) >= 2)
            {
                return "Win for " + frontRunner.Name;
            }

            if (follower.Point >= 3)
            {
                return "Advantage " + frontRunner.Name;
            }

            if (frontRunner.Point < 4)
            {
                return CalculateScoreByPointsOfEachPlayer();
            }

            return null;
        }

        private string CalculateScoreByPointsOfEachPlayer()
        {
            var p1 = frontRunner.DisplayOrder == DisplayOrder.First ? frontRunner : follower;
            var p2 = frontRunner.DisplayOrder == DisplayOrder.Second ? frontRunner : follower;
            return ScoreRule.GetResultByPoint(p1.Point) + "-" + ScoreRule.GetResultByPoint(p2.Point);
        }
    }
}