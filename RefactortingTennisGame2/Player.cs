namespace RefactortingTennisGame2
{
    public class Player
    {
        public string Name { get; set; }
        public int Point { get; private set; }
        public string Result { get; set; }
        public DisplayOrder DisplayOrder { get; private set; }

        public Player(string name, DisplayOrder displayOrder)
        {
            Name = name;
            Point = 0;
            Result = "";
            DisplayOrder = displayOrder;
        }

        public void ScorePlusOne()
        {
            Point++;
        }
    }
}