namespace RefactortingTennisGame2
{
    public class TennisGame : ITennisGame
    {
        private readonly Player p1;
        private readonly Player p2;

        public TennisGame(string player1Name, string player2Name)
        {
            this.p1 = new Player(player1Name);
            this.p2 = new Player(player2Name);
        }

        public string GetScore()
        {
            string score = "";
            if (p1.Point == p2.Point)
            {
                if (p1.Point < 4)
                {
                    score = ScoreRule.GetResultByPoint(p1.Point);
                    score += "-All";
                }
                if (p1.Point >= 3)
                {
                    score = "Deuce";
                }
            }

            if (p1.Point > p2.Point)
            {
                if (p1.Point < 4)
                {
                    score = CalculateScoreByPointsOfEachPlayer();
                }
                if (p2.Point >= 3)
                {
                    score = "Advantage player1";
                }
                if (p1.Point >= 4 && p2.Point >= 0 && (p1.Point - p2.Point) >= 2)
                {
                    score = "Win for player1";
                }
            }

            if (p2.Point > p1.Point)
            {
                if (p2.Point < 4)
                {
                    score = CalculateScoreByPointsOfEachPlayer();
                }
                if (p1.Point >= 3)
                {
                    score = "Advantage player2";
                }
                if (p2.Point >= 4 && p1.Point >= 0 && (p2.Point - p1.Point) >= 2)
                {
                    score = "Win for player2";
                }
            }

            return score;
        }

        private string CalculateScoreByPointsOfEachPlayer()
        {
            p1.Result = ScoreRule.GetResultByPoint(p1.Point);
            p2.Result = ScoreRule.GetResultByPoint(p2.Point);
            return p1.Result + "-" + p2.Result;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                p1.ScorePlusOne();
            else
                p2.ScorePlusOne();
        }
    }
}