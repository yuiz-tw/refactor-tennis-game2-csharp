namespace RefactortingTennisGame2
{
    public class Player
    {
        public string Name { get; }
        public int Point { get; private set; }
        public DisplayOrder DisplayOrder { get; }

        public Player(string name, DisplayOrder displayOrder)
        {
            Name = name;
            DisplayOrder = displayOrder;
            Point = 0;
        }

        public void PointPlusOne()
        {
            Point++;
        }
    }
}