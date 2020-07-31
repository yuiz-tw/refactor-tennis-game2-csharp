using RefactortingTennisGame2.Constants;
using RefactortingTennisGame2.ScoreCalculator;

namespace RefactortingTennisGame2
{
    public class TennisGame : ITennisGame
    {
        private readonly Player p1;
        private readonly Player p2;

        public TennisGame(string player1Name, string player2Name)
        {
            this.p1 = new Player(player1Name, DisplayOrder.First);
            this.p2 = new Player(player2Name, DisplayOrder.Second);
        }

        public string GetScore()
        {
            if (p1.Point == p2.Point)
            {
                return new EqualScoreCalculator(p1.Point).GetScore();
            }

            if (p1.Point > p2.Point)
            {
                return new UnequalScoreCalculator(p1, p2).GetScore();
            }

            if (p2.Point > p1.Point)
            {                
                return new UnequalScoreCalculator(p2, p1).GetScore();
            }

            return null;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                p1.PointPlusOne();
            else
                p2.PointPlusOne();
        }
    }
}