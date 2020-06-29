namespace RefactortingTennisGame2
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
    }
}