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
            if (p1.Point == p2.Point && p1.Point < 4)
            {
                if (p1.Point == 0)
                    score = "Love";
                if (p1.Point == 1)
                    score = "Fifteen";
                if (p1.Point == 2)
                    score = "Thirty";
                score += "-All";
            }

            if (p1.Point == p2.Point && p1.Point >= 3)
                score = "Deuce";

            if (p1.Point > 0 && p2.Point == 0)
            {
                if (p1.Point == 1)
                    p1.Result = "Fifteen";
                if (p1.Point == 2)
                    p1.Result = "Thirty";
                if (p1.Point == 3)
                    p1.Result = "Forty";

                p2.Result = "Love";
                score = p1.Result + "-" + p2.Result;
            }

            if (p2.Point > 0 && p1.Point == 0)
            {
                if (p2.Point == 1)
                    p2.Result = "Fifteen";
                if (p2.Point == 2)
                    p2.Result = "Thirty";
                if (p2.Point == 3)
                    p2.Result = "Forty";

                p1.Result = "Love";
                score = p1.Result + "-" + p2.Result;
            }

            if (p1.Point > p2.Point && p1.Point < 4)
            {
                if (p1.Point == 2)
                    p1.Result = "Thirty";
                if (p1.Point == 3)
                    p1.Result = "Forty";
                if (p2.Point == 1)
                    p2.Result = "Fifteen";
                if (p2.Point == 2)
                    p2.Result = "Thirty";
                score = p1.Result + "-" + p2.Result;
            }

            if (p2.Point > p1.Point && p2.Point < 4)
            {
                if (p2.Point == 2)
                    p2.Result = "Thirty";
                if (p2.Point == 3)
                    p2.Result = "Forty";
                if (p1.Point == 1)
                    p1.Result = "Fifteen";
                if (p1.Point == 2)
                    p1.Result = "Thirty";
                score = p1.Result + "-" + p2.Result;
            }

            if (p1.Point > p2.Point && p2.Point >= 3)
            {
                score = "Advantage player1";
            }

            if (p2.Point > p1.Point && p1.Point >= 3)
            {
                score = "Advantage player2";
            }

            if (p1.Point >= 4 && p2.Point >= 0 && (p1.Point - p2.Point) >= 2)
            {
                score = "Win for player1";
            }

            if (p2.Point >= 4 && p1.Point >= 0 && (p2.Point - p1.Point) >= 2)
            {
                score = "Win for player2";
            }

            return score;
        }

        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        public void P1Score()
        {
            p1.Point++;
        }

        public void P2Score()
        {
            p2.Point++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }
    }
}