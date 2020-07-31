namespace RefactortingTennisGame2
{
    public class Player
    {
        public string Name { get; set; }
        public int Point { get; set; }
        public string Result { get; set; }

        public Player(string name)
        {
            Name = name;
            Point = 0;
            Result = "";
        }
    }
}